using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQLite
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;



namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xvs_metering_device_comboBox.SelectedIndex = 0;
            gvs_metering_device_comboBox.SelectedIndex = 0;
            ee_metering_device_comboBox.SelectedIndex = 0;
        }



        // Класс для работы с базой sqllite\base.db.
        static class SQLiteBase
        {

            static string GetSQLiteData(string sqlExpression)
            {
                string pathToFile = "Data Source ="+Environment.CurrentDirectory.ToString() + @"\sqlite\base.db; Version=3;";
                string sqlResult="";

                SQLiteConnection connection = new SQLiteConnection(pathToFile);
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                SQLiteDataReader Reader = command.ExecuteReader();
                if (Reader.Read()) sqlResult = Reader.GetValue(0).ToString();
                connection.Close();
                return sqlResult;
            }

            // Метод получающий название исходя из идентификатора услуги
            public static string GetService(int ServiceId)
            {
                string sqlExpression = "SELECT service FROM tariffs_and_regulations WHERE service_id=" + ServiceId;
                return GetSQLiteData(sqlExpression);
            }

            // Метод получающий тариф исходя из идентификатора услуги
            public static string GetServiceTariff( int ServiceId)
            {
                string sqlExpression = "SELECT tariff FROM tariffs_and_regulations WHERE service_id="+ ServiceId;
                return GetSQLiteData(sqlExpression);
            }


            // Метод получающий норматив исходя из идентификатора услуги
            public static string GetServiceStandart(int ServiceId)
            {
                string sqlExpression = "SELECT standard FROM tariffs_and_regulations WHERE service_id=" + ServiceId;
                return GetSQLiteData(sqlExpression);
            }

            // Метод получающий единицу измерения исходя из идентификатора услуги
            public static string GetUnitOfMeasurement(int ServiceId)
            {
                string sqlExpression = "SELECT unit_of_measurement FROM tariffs_and_regulations WHERE service_id=" + ServiceId;
                return GetSQLiteData(sqlExpression);
            }
            

        }

        // Класс для расчета начислений.
        static class Accruals
        {
            // Метод для расчета начислений c прибором учета по услуге.
            public static double GetAccruals(int ServiceId, double currentReadings = 0.0, double previousReadings = 0.0)
            {
                double summ = 0;
                summ = (currentReadings - previousReadings) * Convert.ToDouble(SQLiteBase.GetServiceTariff(ServiceId));
                return summ;
            }

            // Метод для расчета начислений без прибора учета по услуге.
            public static double GetAccruals(int ServiceId, int numberOfPeople = 1)
            {
                double summ = 0;
                summ = numberOfPeople * Convert.ToDouble(SQLiteBase.GetServiceTariff(ServiceId)) * Convert.ToDouble(SQLiteBase.GetServiceStandart(ServiceId));
                return summ;
            }


        }





            // Класс для проверок.
            static class Check
        {


            // Метод для проверки показаний. На входе числовая строка, на выходе число.
            public static bool CheckReadings(string inReadings, out double outReadings)
            {
                bool convertSuccess;
                convertSuccess = Double.TryParse(inReadings, out outReadings);
                if (outReadings < 0) convertSuccess = false; // Значения меньше нуля тоже ошибочны.
                return convertSuccess;
            }

        }

        


    // Нажатие на кнопку Рассчитать.
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            
            bool convertSuccess;

            // Значения с формы.
            int numberOfPeople;
            double xvsCurrentReadings = 0;
            double xvsPreviousReadings = 0;

            double gvsCurrentReadings = 0;
            double gvsPreviousReadings = 0;

            double eeCurrentReadingsDay = 0;
            double eePreviousReadingsDay = 0;
            double eeCurrentReadingsNight = 0;
            double eePreviousReadingsNight = 0;

            // Суммы.
            double xvsSumm = 0;
            double gvsSumm = 0;
            double gvsHotSumm = 0;
            double eeSumm = 0;
            double eeDaySumm = 0;
            double eeNightSumm = 0;
            double finalSumm = 0;

            // Получаем данные с формы. Проверяем данные и выводим сообщения в случае ошибки.
            convertSuccess = Int32.TryParse(number_of_people_textBox.Text, out numberOfPeople);
            if (numberOfPeople <= 0 )
            {
                MessageBox.Show("Введите количество людей проживающих в помещении.", "Сообщение", MessageBoxButtons.OK);
                return;
            }

            // Получаем значения comboBox.
            // ХВС.
            bool xvsMeteringDevice;
            if (xvs_metering_device_comboBox.SelectedIndex == 1) xvsMeteringDevice = true; else xvsMeteringDevice = false;
            // ГВС. 
            bool gvsMeteringDevice;
            if (gvs_metering_device_comboBox.SelectedIndex == 1) gvsMeteringDevice = true; else gvsMeteringDevice = false;
            // ЭЭ.
            bool eeMeteringDevice;
            if (ee_metering_device_comboBox.SelectedIndex == 1) eeMeteringDevice = true; else eeMeteringDevice = false;



            // Получаем значения прибора учета ХВС.
            if (xvsMeteringDevice == true)
            {
                // Текущие.
                if ( Check.CheckReadings(xvs_current_readings_textBox.Text, out xvsCurrentReadings)==false)
                {
                    MessageBox.Show("Ошибка в текущих показаниях ХВС. Введите верные показания ХВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие.
                if (Check.CheckReadings(xvs_previous_readings_textBox.Text, out xvsPreviousReadings) == false)
                {
                    MessageBox.Show("Ошибка в предыдущих показаниях ХВС. Введите верные показания ХВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие не могут быть больше текущих.
                if (xvsPreviousReadings > xvsCurrentReadings)
                {
                    MessageBox.Show("Ошибка - предыдущие показания не могут быть больше текущих. Введите верные показания ХВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

            }



            // Получаем значения прибора учета ГВС.
            if (gvsMeteringDevice == true)
            {
                // Текущие.
                if (Check.CheckReadings(gvs_current_readings_textBox.Text, out gvsCurrentReadings) == false)
                {
                    MessageBox.Show("Ошибка в текущих показаниях ГВС. Введите верные показания ГВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие.
                if (Check.CheckReadings(gvs_previous_readings_textBox.Text, out gvsPreviousReadings) == false)
                {
                    MessageBox.Show("Ошибка в предыдущих показаниях ГВС. Введите верные показания ГВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие не могут быть больше текущих.
                if (gvsPreviousReadings > gvsCurrentReadings)
                {
                    MessageBox.Show("Ошибка - предыдущие показания не могут быть больше текущих. Введите верные показания ГВС.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

            }




            // Получаем значения прибора учета ЭЭ.
            if (eeMeteringDevice == true)
            {
                // Получаем значения дневного учета ЭЭ.
                // Текущие.
                if (Check.CheckReadings(ee_current_readings_day_textBox.Text, out eeCurrentReadingsDay) == false)
                {
                    MessageBox.Show("Ошибка в текущих показаниях дневного учета ЭЭ. Введите верные показания.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие.
                if (Check.CheckReadings(ee_previous_readings_day_textBox.Text, out eePreviousReadingsDay) == false)
                {
                    MessageBox.Show("Ошибка в предыдущих показаниях дневного учета ЭЭ. Введите верные показания.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие не могут быть больше текущих.
                if (eePreviousReadingsDay > eeCurrentReadingsDay)
                {
                    MessageBox.Show("Ошибка - предыдущие показания дневного учета не могут быть больше текущих. Введите верные показания ЭЭ.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Получаем значения ночного учета ЭЭ.
                // Текущие.
                if (Check.CheckReadings(ee_current_readings_night_textBox.Text, out eeCurrentReadingsNight) == false)
                {
                    MessageBox.Show("Ошибка в текущих показаниях показаниях ночного учета ЭЭ. Введите верные показания.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие.
                if (Check.CheckReadings(ee_previous_readings_night_textBox.Text, out eePreviousReadingsNight) == false)
                {
                    MessageBox.Show("Ошибка в предыдущих показаниях ночного учета ЭЭ. Введите верные показания.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

                // Предыдущие не могут быть больше текущих.
                if (eePreviousReadingsNight > eeCurrentReadingsNight)
                {
                    MessageBox.Show("Ошибка - предыдущие показания ночного учета не могут быть больше текущих. Введите верные показания ЭЭ.", "Сообщение", MessageBoxButtons.OK);
                    return;
                }

            }


            // Расчет.        
            result_richTextBox.Clear();

            // Расчет ХВС.
            // Расчет без прибора учета.
            if (xvsMeteringDevice == false) xvsSumm = Accruals.GetAccruals(1, numberOfPeople);
            // Расчет с прибором учета.
            if (xvsMeteringDevice == true) xvsSumm = Accruals.GetAccruals(1, xvsCurrentReadings, xvsPreviousReadings);


            // Расчет ГВС.
            // Расчет без прибора учета.
            if (gvsMeteringDevice == false) gvsSumm = Accruals.GetAccruals(2, numberOfPeople);
            // Расчет с прибором учета.
            if (gvsMeteringDevice == true) gvsSumm = Accruals.GetAccruals(2, gvsCurrentReadings, gvsPreviousReadings);
            // Расчет нагрева без прибора учета.
            if (gvsMeteringDevice == false) gvsHotSumm = Accruals.GetAccruals(7, numberOfPeople);
            // Расчет нагрева с прибором учета.
            if (gvsMeteringDevice == true) gvsHotSumm =  Accruals.GetAccruals(7, gvsCurrentReadings, gvsPreviousReadings);

            // Расчет ЭЭ.
            // Расчет без прибора учета.
            if (eeMeteringDevice == false) eeSumm = Accruals.GetAccruals(3, numberOfPeople);
            // Расчет с прибором учета.
            // Расчет ЭЭ.
            if (eeMeteringDevice == true)
            {
                eeDaySumm = Accruals.GetAccruals(4, eeCurrentReadingsDay, eePreviousReadingsDay);
                eeNightSumm = Accruals.GetAccruals(5, eeCurrentReadingsNight, eePreviousReadingsNight);
            }

            // Сумма за все услуги.
            finalSumm = xvsSumm + gvsSumm + gvsHotSumm + eeSumm + eeDaySumm + eeNightSumm;

            // Вывод.
          
            result_richTextBox.AppendText("Расчет платы за коммунальные услуги \n");
            result_richTextBox.AppendText("Сумма за ХВС: " + xvsSumm.ToString()+"\n");
            result_richTextBox.AppendText("Сумма за ГВС: " + gvsSumm.ToString() + "\n");
            result_richTextBox.AppendText("Сумма за нагрев ГВС: " + gvsHotSumm.ToString() + "\n");
            if (eeMeteringDevice == false) result_richTextBox.AppendText("Сумма за ЭЭ: " + eeSumm.ToString() + "\n");
            else result_richTextBox.AppendText("Сумма за дневное ЭЭ: " + eeDaySumm.ToString()+ ", Сумма за ночное ЭЭ: " + eeNightSumm.ToString() + "\n");
            result_richTextBox.AppendText("Итого: " + finalSumm.ToString() + "\n");

        }


        // Код ниже - управление интерфейсом.
        private void Xvs_metering_device_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xvs_metering_device_comboBox.SelectedIndex == 1) xvs_panel.Visible = true;         
            else
            xvs_panel.Visible = false;       
        }

        private void Gvs_metering_device_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvs_metering_device_comboBox.SelectedIndex == 1) gvs_panel.Visible = true;
            else
            gvs_panel.Visible = false;
        }

        private void Ee_metering_device_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (ee_metering_device_comboBox.SelectedIndex == 1) ee_panel.Visible = true;
             else
             ee_panel.Visible = false;
        }

   
    }
}
