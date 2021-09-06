namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.number_of_people_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xvs_metering_device_comboBox = new System.Windows.Forms.ComboBox();
            this.gvs_metering_device_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ee_metering_device_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.result_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.xvs_previous_readings_textBox = new System.Windows.Forms.TextBox();
            this.xvs_previous_readings_label = new System.Windows.Forms.Label();
            this.xvs_current_readings_textBox = new System.Windows.Forms.TextBox();
            this.xvs_current_readings_label = new System.Windows.Forms.Label();
            this.ee_previous_readings_day_textBox = new System.Windows.Forms.TextBox();
            this.ee_current_readings_day_textBox = new System.Windows.Forms.TextBox();
            this.ee_previous_readings_night_textBox = new System.Windows.Forms.TextBox();
            this.ee_current_readings_night_textBox = new System.Windows.Forms.TextBox();
            this.ee_current_readings_day_label = new System.Windows.Forms.Label();
            this.ee_day_label = new System.Windows.Forms.Label();
            this.ee_previous_readings_day_label = new System.Windows.Forms.Label();
            this.ee_night_label = new System.Windows.Forms.Label();
            this.ee_current_readings_night_label = new System.Windows.Forms.Label();
            this.ee_previous_readings_night_label = new System.Windows.Forms.Label();
            this.xvs_panel = new System.Windows.Forms.Panel();
            this.gvs_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gvs_current_readings_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvs_previous_readings_textBox = new System.Windows.Forms.TextBox();
            this.ee_panel = new System.Windows.Forms.Panel();
            this.xvs_panel.SuspendLayout();
            this.gvs_panel.SuspendLayout();
            this.ee_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество людей проживающих в помещении";
            // 
            // number_of_people_textBox
            // 
            this.number_of_people_textBox.Location = new System.Drawing.Point(274, 6);
            this.number_of_people_textBox.Name = "number_of_people_textBox";
            this.number_of_people_textBox.Size = new System.Drawing.Size(69, 20);
            this.number_of_people_textBox.TabIndex = 1;
            this.number_of_people_textBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "У вас есть прибор учета по услуге ХВС?";
            // 
            // xvs_metering_device_comboBox
            // 
            this.xvs_metering_device_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xvs_metering_device_comboBox.FormattingEnabled = true;
            this.xvs_metering_device_comboBox.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.xvs_metering_device_comboBox.Location = new System.Drawing.Point(274, 52);
            this.xvs_metering_device_comboBox.Name = "xvs_metering_device_comboBox";
            this.xvs_metering_device_comboBox.Size = new System.Drawing.Size(69, 21);
            this.xvs_metering_device_comboBox.TabIndex = 3;
            this.xvs_metering_device_comboBox.SelectedIndexChanged += new System.EventHandler(this.Xvs_metering_device_comboBox_SelectedIndexChanged);
            // 
            // gvs_metering_device_comboBox
            // 
            this.gvs_metering_device_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gvs_metering_device_comboBox.FormattingEnabled = true;
            this.gvs_metering_device_comboBox.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.gvs_metering_device_comboBox.Location = new System.Drawing.Point(274, 93);
            this.gvs_metering_device_comboBox.Name = "gvs_metering_device_comboBox";
            this.gvs_metering_device_comboBox.Size = new System.Drawing.Size(69, 21);
            this.gvs_metering_device_comboBox.TabIndex = 5;
            this.gvs_metering_device_comboBox.SelectedIndexChanged += new System.EventHandler(this.Gvs_metering_device_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "У вас есть прибор учета по услуге ГВС?";
            // 
            // ee_metering_device_comboBox
            // 
            this.ee_metering_device_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ee_metering_device_comboBox.FormattingEnabled = true;
            this.ee_metering_device_comboBox.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.ee_metering_device_comboBox.Location = new System.Drawing.Point(274, 134);
            this.ee_metering_device_comboBox.Name = "ee_metering_device_comboBox";
            this.ee_metering_device_comboBox.Size = new System.Drawing.Size(69, 21);
            this.ee_metering_device_comboBox.TabIndex = 7;
            this.ee_metering_device_comboBox.SelectedIndexChanged += new System.EventHandler(this.Ee_metering_device_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "У вас есть прибор учета по услуге ЭЭ?";
            // 
            // calculate_Button
            // 
            this.calculate_Button.Location = new System.Drawing.Point(352, 267);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(75, 23);
            this.calculate_Button.TabIndex = 14;
            this.calculate_Button.Text = "Рассчитать";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // result_richTextBox
            // 
            this.result_richTextBox.Location = new System.Drawing.Point(18, 321);
            this.result_richTextBox.Name = "result_richTextBox";
            this.result_richTextBox.Size = new System.Drawing.Size(722, 162);
            this.result_richTextBox.TabIndex = 17;
            this.result_richTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Результат";
            // 
            // xvs_previous_readings_textBox
            // 
            this.xvs_previous_readings_textBox.Location = new System.Drawing.Point(325, 12);
            this.xvs_previous_readings_textBox.Name = "xvs_previous_readings_textBox";
            this.xvs_previous_readings_textBox.Size = new System.Drawing.Size(69, 20);
            this.xvs_previous_readings_textBox.TabIndex = 24;
            this.xvs_previous_readings_textBox.Text = "0";
            // 
            // xvs_previous_readings_label
            // 
            this.xvs_previous_readings_label.AutoSize = true;
            this.xvs_previous_readings_label.Location = new System.Drawing.Point(191, 19);
            this.xvs_previous_readings_label.Name = "xvs_previous_readings_label";
            this.xvs_previous_readings_label.Size = new System.Drawing.Size(128, 13);
            this.xvs_previous_readings_label.TabIndex = 23;
            this.xvs_previous_readings_label.Text = "предыдущие показания\r\n";
            // 
            // xvs_current_readings_textBox
            // 
            this.xvs_current_readings_textBox.Location = new System.Drawing.Point(116, 12);
            this.xvs_current_readings_textBox.Name = "xvs_current_readings_textBox";
            this.xvs_current_readings_textBox.Size = new System.Drawing.Size(69, 20);
            this.xvs_current_readings_textBox.TabIndex = 22;
            // 
            // xvs_current_readings_label
            // 
            this.xvs_current_readings_label.AutoSize = true;
            this.xvs_current_readings_label.Location = new System.Drawing.Point(3, 19);
            this.xvs_current_readings_label.Name = "xvs_current_readings_label";
            this.xvs_current_readings_label.Size = new System.Drawing.Size(107, 13);
            this.xvs_current_readings_label.TabIndex = 21;
            this.xvs_current_readings_label.Text = "текущие показания\r\n";
            // 
            // ee_previous_readings_day_textBox
            // 
            this.ee_previous_readings_day_textBox.Location = new System.Drawing.Point(325, 30);
            this.ee_previous_readings_day_textBox.Name = "ee_previous_readings_day_textBox";
            this.ee_previous_readings_day_textBox.Size = new System.Drawing.Size(69, 20);
            this.ee_previous_readings_day_textBox.TabIndex = 24;
            this.ee_previous_readings_day_textBox.Text = "0";
            // 
            // ee_current_readings_day_textBox
            // 
            this.ee_current_readings_day_textBox.Location = new System.Drawing.Point(116, 30);
            this.ee_current_readings_day_textBox.Name = "ee_current_readings_day_textBox";
            this.ee_current_readings_day_textBox.Size = new System.Drawing.Size(69, 20);
            this.ee_current_readings_day_textBox.TabIndex = 22;
            // 
            // ee_previous_readings_night_textBox
            // 
            this.ee_previous_readings_night_textBox.Location = new System.Drawing.Point(325, 85);
            this.ee_previous_readings_night_textBox.Name = "ee_previous_readings_night_textBox";
            this.ee_previous_readings_night_textBox.Size = new System.Drawing.Size(69, 20);
            this.ee_previous_readings_night_textBox.TabIndex = 24;
            this.ee_previous_readings_night_textBox.Text = "0";
            // 
            // ee_current_readings_night_textBox
            // 
            this.ee_current_readings_night_textBox.Location = new System.Drawing.Point(116, 85);
            this.ee_current_readings_night_textBox.Name = "ee_current_readings_night_textBox";
            this.ee_current_readings_night_textBox.Size = new System.Drawing.Size(69, 20);
            this.ee_current_readings_night_textBox.TabIndex = 22;
            // 
            // ee_current_readings_day_label
            // 
            this.ee_current_readings_day_label.AutoSize = true;
            this.ee_current_readings_day_label.Location = new System.Drawing.Point(3, 37);
            this.ee_current_readings_day_label.Name = "ee_current_readings_day_label";
            this.ee_current_readings_day_label.Size = new System.Drawing.Size(107, 13);
            this.ee_current_readings_day_label.TabIndex = 29;
            this.ee_current_readings_day_label.Text = "текущие показания\r\n";
            // 
            // ee_day_label
            // 
            this.ee_day_label.AutoSize = true;
            this.ee_day_label.Location = new System.Drawing.Point(3, 5);
            this.ee_day_label.Name = "ee_day_label";
            this.ee_day_label.Size = new System.Drawing.Size(241, 13);
            this.ee_day_label.TabIndex = 30;
            this.ee_day_label.Text = "Показания прибора учета ЭЭ - дневная шкала";
            // 
            // ee_previous_readings_day_label
            // 
            this.ee_previous_readings_day_label.AutoSize = true;
            this.ee_previous_readings_day_label.Location = new System.Drawing.Point(191, 37);
            this.ee_previous_readings_day_label.Name = "ee_previous_readings_day_label";
            this.ee_previous_readings_day_label.Size = new System.Drawing.Size(128, 13);
            this.ee_previous_readings_day_label.TabIndex = 31;
            this.ee_previous_readings_day_label.Text = "предыдущие показания\r\n";
            // 
            // ee_night_label
            // 
            this.ee_night_label.AutoSize = true;
            this.ee_night_label.Location = new System.Drawing.Point(3, 66);
            this.ee_night_label.Name = "ee_night_label";
            this.ee_night_label.Size = new System.Drawing.Size(234, 13);
            this.ee_night_label.TabIndex = 32;
            this.ee_night_label.Text = "Показания прибора учета ЭЭ - ночная шкала";
            // 
            // ee_current_readings_night_label
            // 
            this.ee_current_readings_night_label.AutoSize = true;
            this.ee_current_readings_night_label.Location = new System.Drawing.Point(3, 92);
            this.ee_current_readings_night_label.Name = "ee_current_readings_night_label";
            this.ee_current_readings_night_label.Size = new System.Drawing.Size(107, 13);
            this.ee_current_readings_night_label.TabIndex = 33;
            this.ee_current_readings_night_label.Text = "текущие показания\r\n";
            // 
            // ee_previous_readings_night_label
            // 
            this.ee_previous_readings_night_label.AutoSize = true;
            this.ee_previous_readings_night_label.Location = new System.Drawing.Point(191, 92);
            this.ee_previous_readings_night_label.Name = "ee_previous_readings_night_label";
            this.ee_previous_readings_night_label.Size = new System.Drawing.Size(128, 13);
            this.ee_previous_readings_night_label.TabIndex = 34;
            this.ee_previous_readings_night_label.Text = "предыдущие показания\r\n";
            // 
            // xvs_panel
            // 
            this.xvs_panel.Controls.Add(this.xvs_current_readings_label);
            this.xvs_panel.Controls.Add(this.xvs_current_readings_textBox);
            this.xvs_panel.Controls.Add(this.xvs_previous_readings_label);
            this.xvs_panel.Controls.Add(this.xvs_previous_readings_textBox);
            this.xvs_panel.Location = new System.Drawing.Point(352, 38);
            this.xvs_panel.Name = "xvs_panel";
            this.xvs_panel.Size = new System.Drawing.Size(403, 35);
            this.xvs_panel.TabIndex = 35;
            this.xvs_panel.Visible = false;
            // 
            // gvs_panel
            // 
            this.gvs_panel.Controls.Add(this.label5);
            this.gvs_panel.Controls.Add(this.gvs_current_readings_textBox);
            this.gvs_panel.Controls.Add(this.label6);
            this.gvs_panel.Controls.Add(this.gvs_previous_readings_textBox);
            this.gvs_panel.Location = new System.Drawing.Point(352, 79);
            this.gvs_panel.Name = "gvs_panel";
            this.gvs_panel.Size = new System.Drawing.Size(403, 35);
            this.gvs_panel.TabIndex = 36;
            this.gvs_panel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "текущие показания\r\n";
            // 
            // gvs_current_readings_textBox
            // 
            this.gvs_current_readings_textBox.Location = new System.Drawing.Point(116, 12);
            this.gvs_current_readings_textBox.Name = "gvs_current_readings_textBox";
            this.gvs_current_readings_textBox.Size = new System.Drawing.Size(69, 20);
            this.gvs_current_readings_textBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "предыдущие показания\r\n";
            // 
            // gvs_previous_readings_textBox
            // 
            this.gvs_previous_readings_textBox.Location = new System.Drawing.Point(325, 12);
            this.gvs_previous_readings_textBox.Name = "gvs_previous_readings_textBox";
            this.gvs_previous_readings_textBox.Size = new System.Drawing.Size(69, 20);
            this.gvs_previous_readings_textBox.TabIndex = 24;
            this.gvs_previous_readings_textBox.Text = "0";
            // 
            // ee_panel
            // 
            this.ee_panel.Controls.Add(this.ee_day_label);
            this.ee_panel.Controls.Add(this.ee_current_readings_day_textBox);
            this.ee_panel.Controls.Add(this.ee_previous_readings_night_textBox);
            this.ee_panel.Controls.Add(this.ee_current_readings_day_label);
            this.ee_panel.Controls.Add(this.ee_previous_readings_night_label);
            this.ee_panel.Controls.Add(this.ee_previous_readings_day_textBox);
            this.ee_panel.Controls.Add(this.ee_current_readings_night_label);
            this.ee_panel.Controls.Add(this.ee_previous_readings_day_label);
            this.ee_panel.Controls.Add(this.ee_night_label);
            this.ee_panel.Controls.Add(this.ee_current_readings_night_textBox);
            this.ee_panel.Location = new System.Drawing.Point(352, 134);
            this.ee_panel.Name = "ee_panel";
            this.ee_panel.Size = new System.Drawing.Size(405, 113);
            this.ee_panel.TabIndex = 37;
            this.ee_panel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 502);
            this.Controls.Add(this.ee_panel);
            this.Controls.Add(this.gvs_panel);
            this.Controls.Add(this.xvs_panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.result_richTextBox);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.ee_metering_device_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvs_metering_device_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xvs_metering_device_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_of_people_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет платы за коммунальные услуги";
            this.xvs_panel.ResumeLayout(false);
            this.xvs_panel.PerformLayout();
            this.gvs_panel.ResumeLayout(false);
            this.gvs_panel.PerformLayout();
            this.ee_panel.ResumeLayout(false);
            this.ee_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number_of_people_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox xvs_metering_device_comboBox;
        private System.Windows.Forms.ComboBox gvs_metering_device_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ee_metering_device_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.RichTextBox result_richTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xvs_previous_readings_textBox;
        private System.Windows.Forms.Label xvs_previous_readings_label;
        private System.Windows.Forms.TextBox xvs_current_readings_textBox;
        private System.Windows.Forms.Label xvs_current_readings_label;
        private System.Windows.Forms.TextBox ee_previous_readings_day_textBox;
        private System.Windows.Forms.TextBox ee_current_readings_day_textBox;
        private System.Windows.Forms.TextBox ee_previous_readings_night_textBox;
        private System.Windows.Forms.TextBox ee_current_readings_night_textBox;
        private System.Windows.Forms.Label ee_current_readings_day_label;
        private System.Windows.Forms.Label ee_day_label;
        private System.Windows.Forms.Label ee_previous_readings_day_label;
        private System.Windows.Forms.Label ee_night_label;
        private System.Windows.Forms.Label ee_current_readings_night_label;
        private System.Windows.Forms.Label ee_previous_readings_night_label;
        private System.Windows.Forms.Panel xvs_panel;
        private System.Windows.Forms.Panel gvs_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gvs_current_readings_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gvs_previous_readings_textBox;
        private System.Windows.Forms.Panel ee_panel;
    }
}

