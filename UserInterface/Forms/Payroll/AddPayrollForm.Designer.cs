namespace KiPKadryIPlace.UserInterface.Forms.Payroll
{
    partial class AddPayrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbPayroll = new System.Windows.Forms.PictureBox();
            this.lblPayroll = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtDaysWorked = new System.Windows.Forms.TextBox();
            this.lblDaysWorked = new System.Windows.Forms.Label();
            this.txtHourDay = new System.Windows.Forms.TextBox();
            this.cbFullName = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDatePay = new System.Windows.Forms.DateTimePicker();
            this.lblDatePay = new System.Windows.Forms.Label();
            this.lblHourDay = new System.Windows.Forms.Label();
            this.txtRateHour = new System.Windows.Forms.TextBox();
            this.lblRateHour = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.eFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eRateHour = new System.Windows.Forms.ErrorProvider(this.components);
            this.eHourDay = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDaysWorked = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDatePay = new System.Windows.Forms.ErrorProvider(this.components);
            this.eMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDescription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPayroll)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRateHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHourDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDaysWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDatePay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPayroll
            // 
            this.pbPayroll.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbPayroll.Location = new System.Drawing.Point(430, 15);
            this.pbPayroll.Name = "pbPayroll";
            this.pbPayroll.Size = new System.Drawing.Size(64, 64);
            this.pbPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPayroll.TabIndex = 4;
            this.pbPayroll.TabStop = false;
            // 
            // lblPayroll
            // 
            this.lblPayroll.AutoSize = true;
            this.lblPayroll.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPayroll.Location = new System.Drawing.Point(25, 40);
            this.lblPayroll.Name = "lblPayroll";
            this.lblPayroll.Size = new System.Drawing.Size(101, 30);
            this.lblPayroll.TabIndex = 3;
            this.lblPayroll.Text = "Lista płac";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblMonth);
            this.gbData.Controls.Add(this.cbMonth);
            this.gbData.Controls.Add(this.txtDaysWorked);
            this.gbData.Controls.Add(this.lblDaysWorked);
            this.gbData.Controls.Add(this.txtHourDay);
            this.gbData.Controls.Add(this.cbFullName);
            this.gbData.Controls.Add(this.txtDescription);
            this.gbData.Controls.Add(this.lblDescription);
            this.gbData.Controls.Add(this.dtpDatePay);
            this.gbData.Controls.Add(this.lblDatePay);
            this.gbData.Controls.Add(this.lblHourDay);
            this.gbData.Controls.Add(this.txtRateHour);
            this.gbData.Controls.Add(this.lblRateHour);
            this.gbData.Controls.Add(this.lblFullName);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbData.Location = new System.Drawing.Point(40, 100);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(430, 259);
            this.gbData.TabIndex = 5;
            this.gbData.TabStop = false;
            this.gbData.Text = "Dane do listy";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(10, 185);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(80, 19);
            this.lblMonth.TabIndex = 15;
            this.lblMonth.Text = "Za miesiąc";
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.cbMonth.Location = new System.Drawing.Point(240, 180);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(165, 25);
            this.cbMonth.TabIndex = 14;
            // 
            // txtDaysWorked
            // 
            this.txtDaysWorked.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDaysWorked.Location = new System.Drawing.Point(240, 120);
            this.txtDaysWorked.Name = "txtDaysWorked";
            this.txtDaysWorked.Size = new System.Drawing.Size(165, 25);
            this.txtDaysWorked.TabIndex = 13;
            // 
            // lblDaysWorked
            // 
            this.lblDaysWorked.AutoSize = true;
            this.lblDaysWorked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDaysWorked.Location = new System.Drawing.Point(10, 125);
            this.lblDaysWorked.Name = "lblDaysWorked";
            this.lblDaysWorked.Size = new System.Drawing.Size(199, 19);
            this.lblDaysWorked.TabIndex = 12;
            this.lblDaysWorked.Text = "Liczba przepracowanych dni";
            // 
            // txtHourDay
            // 
            this.txtHourDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHourDay.Location = new System.Drawing.Point(240, 90);
            this.txtHourDay.Name = "txtHourDay";
            this.txtHourDay.Size = new System.Drawing.Size(165, 25);
            this.txtHourDay.TabIndex = 11;
            // 
            // cbFullName
            // 
            this.cbFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFullName.FormattingEnabled = true;
            this.cbFullName.Location = new System.Drawing.Point(240, 30);
            this.cbFullName.Name = "cbFullName";
            this.cbFullName.Size = new System.Drawing.Size(165, 25);
            this.cbFullName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(240, 210);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(165, 25);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(10, 215);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 19);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Krótki opis";
            // 
            // dtpDatePay
            // 
            this.dtpDatePay.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDatePay.CustomFormat = " dd-MM-yyyy";
            this.dtpDatePay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDatePay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePay.Location = new System.Drawing.Point(240, 150);
            this.dtpDatePay.Name = "dtpDatePay";
            this.dtpDatePay.Size = new System.Drawing.Size(165, 25);
            this.dtpDatePay.TabIndex = 7;
            // 
            // lblDatePay
            // 
            this.lblDatePay.AutoSize = true;
            this.lblDatePay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDatePay.Location = new System.Drawing.Point(10, 155);
            this.lblDatePay.Name = "lblDatePay";
            this.lblDatePay.Size = new System.Drawing.Size(97, 19);
            this.lblDatePay.TabIndex = 6;
            this.lblDatePay.Text = "Data wypłaty";
            // 
            // lblHourDay
            // 
            this.lblHourDay.AutoSize = true;
            this.lblHourDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHourDay.Location = new System.Drawing.Point(10, 95);
            this.lblHourDay.Name = "lblHourDay";
            this.lblHourDay.Size = new System.Drawing.Size(149, 19);
            this.lblHourDay.TabIndex = 4;
            this.lblHourDay.Text = "Liczba godzin w dniu";
            // 
            // txtRateHour
            // 
            this.txtRateHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRateHour.Location = new System.Drawing.Point(240, 60);
            this.txtRateHour.Name = "txtRateHour";
            this.txtRateHour.Size = new System.Drawing.Size(165, 25);
            this.txtRateHour.TabIndex = 3;
            // 
            // lblRateHour
            // 
            this.lblRateHour.AutoSize = true;
            this.lblRateHour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRateHour.Location = new System.Drawing.Point(10, 65);
            this.lblRateHour.Name = "lblRateHour";
            this.lblRateHour.Size = new System.Drawing.Size(135, 19);
            this.lblRateHour.TabIndex = 1;
            this.lblRateHour.Text = "Stawka godzinowa";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(10, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(111, 19);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Imię i nazwisko";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(320, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(180, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // eFullName
            // 
            this.eFullName.ContainerControl = this;
            // 
            // eRateHour
            // 
            this.eRateHour.ContainerControl = this;
            // 
            // eHourDay
            // 
            this.eHourDay.ContainerControl = this;
            // 
            // eDaysWorked
            // 
            this.eDaysWorked.ContainerControl = this;
            // 
            // eDatePay
            // 
            this.eDatePay.ContainerControl = this;
            // 
            // eMonth
            // 
            this.eMonth.ContainerControl = this;
            // 
            // eDescription
            // 
            this.eDescription.ContainerControl = this;
            // 
            // AddPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.pbPayroll);
            this.Controls.Add(this.lblPayroll);
            this.Name = "AddPayrollForm";
            this.Text = "Dodaj listę płac";
            ((System.ComponentModel.ISupportInitialize)(this.pbPayroll)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRateHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHourDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDaysWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDatePay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPayroll;
        private System.Windows.Forms.Label lblPayroll;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDatePay;
        private System.Windows.Forms.Label lblDatePay;
        private System.Windows.Forms.Label lblHourDay;
        private System.Windows.Forms.TextBox txtRateHour;
        private System.Windows.Forms.Label lblRateHour;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFullName;
        private System.Windows.Forms.TextBox txtHourDay;
        private System.Windows.Forms.Label lblDaysWorked;
        private System.Windows.Forms.TextBox txtDaysWorked;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ErrorProvider eFullName;
        private System.Windows.Forms.ErrorProvider eRateHour;
        private System.Windows.Forms.ErrorProvider eHourDay;
        private System.Windows.Forms.ErrorProvider eDaysWorked;
        private System.Windows.Forms.ErrorProvider eDatePay;
        private System.Windows.Forms.ErrorProvider eMonth;
        private System.Windows.Forms.ErrorProvider eDescription;
    }
}