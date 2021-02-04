namespace KiPKadryIPlace.UserInterface.Forms.Contracts
{
    partial class AddContractForm
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
            this.lblContract = new System.Windows.Forms.Label();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.cbLastName = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbContract = new System.Windows.Forms.GroupBox();
            this.cbDepartament = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpConclusionDate = new System.Windows.Forms.DateTimePicker();
            this.cbTypeContract = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblConclusionDate = new System.Windows.Forms.Label();
            this.lblTypeContract = new System.Windows.Forms.Label();
            this.gbSalary = new System.Windows.Forms.GroupBox();
            this.cbTypeRate = new System.Windows.Forms.ComboBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.lblTypeRate = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.eLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eTypeContract = new System.Windows.Forms.ErrorProvider(this.components);
            this.eConclusionDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDateFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDateTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePosition = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDepartament = new System.Windows.Forms.ErrorProvider(this.components);
            this.eSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.eCurrency = new System.Windows.Forms.ErrorProvider(this.components);
            this.eTypeRate = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.gbEmployee.SuspendLayout();
            this.gbContract.SuspendLayout();
            this.gbSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTypeContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eConclusionDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDepartament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTypeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblContract.Location = new System.Drawing.Point(25, 40);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(87, 30);
            this.lblContract.TabIndex = 1;
            this.lblContract.Text = "Umowa";
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.cbFirstName);
            this.gbEmployee.Controls.Add(this.cbLastName);
            this.gbEmployee.Controls.Add(this.lblFirstName);
            this.gbEmployee.Controls.Add(this.lblLastName);
            this.gbEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbEmployee.Location = new System.Drawing.Point(50, 110);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(380, 110);
            this.gbEmployee.TabIndex = 2;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Pracownik";
            // 
            // cbFirstName
            // 
            this.cbFirstName.DisplayMember = "Value";
            this.cbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFirstName.FormattingEnabled = true;
            this.cbFirstName.Location = new System.Drawing.Point(170, 60);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(165, 25);
            this.cbFirstName.TabIndex = 15;
            this.cbFirstName.ValueMember = "Id";
            // 
            // cbLastName
            // 
            this.cbLastName.DisplayMember = "Value";
            this.cbLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLastName.FormattingEnabled = true;
            this.cbLastName.Location = new System.Drawing.Point(170, 30);
            this.cbLastName.Name = "cbLastName";
            this.cbLastName.Size = new System.Drawing.Size(165, 25);
            this.cbLastName.TabIndex = 14;
            this.cbLastName.ValueMember = "Id";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(10, 65);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(38, 19);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(10, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 19);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nazwisko";
            // 
            // gbContract
            // 
            this.gbContract.Controls.Add(this.cbDepartament);
            this.gbContract.Controls.Add(this.cbPosition);
            this.gbContract.Controls.Add(this.lblDepartament);
            this.gbContract.Controls.Add(this.dtpDateFrom);
            this.gbContract.Controls.Add(this.dtpConclusionDate);
            this.gbContract.Controls.Add(this.cbTypeContract);
            this.gbContract.Controls.Add(this.lblPosition);
            this.gbContract.Controls.Add(this.dtpDateTo);
            this.gbContract.Controls.Add(this.lblDateTo);
            this.gbContract.Controls.Add(this.lblDateFrom);
            this.gbContract.Controls.Add(this.lblConclusionDate);
            this.gbContract.Controls.Add(this.lblTypeContract);
            this.gbContract.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbContract.Location = new System.Drawing.Point(50, 230);
            this.gbContract.Name = "gbContract";
            this.gbContract.Size = new System.Drawing.Size(380, 223);
            this.gbContract.TabIndex = 4;
            this.gbContract.TabStop = false;
            this.gbContract.Text = "Umowa";
            // 
            // cbDepartament
            // 
            this.cbDepartament.DisplayMember = "Value";
            this.cbDepartament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartament.FormattingEnabled = true;
            this.cbDepartament.Location = new System.Drawing.Point(170, 180);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.Size = new System.Drawing.Size(165, 25);
            this.cbDepartament.TabIndex = 17;
            this.cbDepartament.ValueMember = "Id";
            // 
            // cbPosition
            // 
            this.cbPosition.DisplayMember = "Value";
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(170, 150);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(165, 25);
            this.cbPosition.TabIndex = 16;
            this.cbPosition.ValueMember = "Id";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartament.Location = new System.Drawing.Point(10, 185);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(42, 19);
            this.lblDepartament.TabIndex = 13;
            this.lblDepartament.Text = "Dział";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateFrom.CustomFormat = " yyyy-MM-dd";
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(170, 90);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(165, 25);
            this.dtpDateFrom.TabIndex = 12;
            // 
            // dtpConclusionDate
            // 
            this.dtpConclusionDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpConclusionDate.CustomFormat = " yyyy-MM-dd";
            this.dtpConclusionDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpConclusionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConclusionDate.Location = new System.Drawing.Point(170, 60);
            this.dtpConclusionDate.Name = "dtpConclusionDate";
            this.dtpConclusionDate.Size = new System.Drawing.Size(165, 25);
            this.dtpConclusionDate.TabIndex = 11;
            // 
            // cbTypeContract
            // 
            this.cbTypeContract.DisplayMember = "Value";
            this.cbTypeContract.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeContract.FormattingEnabled = true;
            this.cbTypeContract.Location = new System.Drawing.Point(170, 30);
            this.cbTypeContract.Name = "cbTypeContract";
            this.cbTypeContract.Size = new System.Drawing.Size(165, 25);
            this.cbTypeContract.TabIndex = 10;
            this.cbTypeContract.ValueMember = "Id";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(10, 155);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(85, 19);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Stanowisko";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateTo.CustomFormat = " yyyy-MM-dd";
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(170, 120);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(165, 25);
            this.dtpDateTo.TabIndex = 7;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateTo.Location = new System.Drawing.Point(10, 125);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(62, 19);
            this.lblDateTo.TabIndex = 6;
            this.lblDateTo.Text = "Data do";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateFrom.Location = new System.Drawing.Point(10, 95);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(62, 19);
            this.lblDateFrom.TabIndex = 4;
            this.lblDateFrom.Text = "Data od";
            // 
            // lblConclusionDate
            // 
            this.lblConclusionDate.AutoSize = true;
            this.lblConclusionDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConclusionDate.Location = new System.Drawing.Point(10, 65);
            this.lblConclusionDate.Name = "lblConclusionDate";
            this.lblConclusionDate.Size = new System.Drawing.Size(103, 19);
            this.lblConclusionDate.TabIndex = 1;
            this.lblConclusionDate.Text = "Data zawarcia";
            // 
            // lblTypeContract
            // 
            this.lblTypeContract.AutoSize = true;
            this.lblTypeContract.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeContract.Location = new System.Drawing.Point(10, 35);
            this.lblTypeContract.Name = "lblTypeContract";
            this.lblTypeContract.Size = new System.Drawing.Size(55, 19);
            this.lblTypeContract.TabIndex = 0;
            this.lblTypeContract.Text = "Rodzaj";
            // 
            // gbSalary
            // 
            this.gbSalary.Controls.Add(this.cbTypeRate);
            this.gbSalary.Controls.Add(this.cbCurrency);
            this.gbSalary.Controls.Add(this.nudSalary);
            this.gbSalary.Controls.Add(this.lblTypeRate);
            this.gbSalary.Controls.Add(this.lblCurrency);
            this.gbSalary.Controls.Add(this.lblSalary);
            this.gbSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbSalary.Location = new System.Drawing.Point(50, 465);
            this.gbSalary.Name = "gbSalary";
            this.gbSalary.Size = new System.Drawing.Size(380, 150);
            this.gbSalary.TabIndex = 5;
            this.gbSalary.TabStop = false;
            this.gbSalary.Text = "Wynagrodzenie";
            // 
            // cbTypeRate
            // 
            this.cbTypeRate.DisplayMember = "Value";
            this.cbTypeRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeRate.FormattingEnabled = true;
            this.cbTypeRate.Location = new System.Drawing.Point(170, 90);
            this.cbTypeRate.Name = "cbTypeRate";
            this.cbTypeRate.Size = new System.Drawing.Size(165, 25);
            this.cbTypeRate.TabIndex = 16;
            this.cbTypeRate.ValueMember = "Id";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Value";
            this.cbCurrency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(170, 60);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(165, 25);
            this.cbCurrency.TabIndex = 15;
            this.cbCurrency.ValueMember = "Id";
            // 
            // nudSalary
            // 
            this.nudSalary.Location = new System.Drawing.Point(170, 30);
            this.nudSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(165, 25);
            this.nudSalary.TabIndex = 14;
            // 
            // lblTypeRate
            // 
            this.lblTypeRate.AutoSize = true;
            this.lblTypeRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeRate.Location = new System.Drawing.Point(10, 95);
            this.lblTypeRate.Name = "lblTypeRate";
            this.lblTypeRate.Size = new System.Drawing.Size(101, 19);
            this.lblTypeRate.TabIndex = 12;
            this.lblTypeRate.Text = "Rodzaj stawki";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrency.Location = new System.Drawing.Point(10, 65);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(55, 19);
            this.lblCurrency.TabIndex = 11;
            this.lblCurrency.Text = "Waluta";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalary.Location = new System.Drawing.Point(10, 35);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 19);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Kwota";
            // 
            // eLastName
            // 
            this.eLastName.ContainerControl = this;
            // 
            // eFirstName
            // 
            this.eFirstName.ContainerControl = this;
            // 
            // eTypeContract
            // 
            this.eTypeContract.ContainerControl = this;
            // 
            // eConclusionDate
            // 
            this.eConclusionDate.ContainerControl = this;
            // 
            // eDateFrom
            // 
            this.eDateFrom.ContainerControl = this;
            // 
            // eDateTo
            // 
            this.eDateTo.ContainerControl = this;
            // 
            // ePosition
            // 
            this.ePosition.ContainerControl = this;
            // 
            // eDepartament
            // 
            this.eDepartament.ContainerControl = this;
            // 
            // eSalary
            // 
            this.eSalary.ContainerControl = this;
            // 
            // eCurrency
            // 
            this.eCurrency.ContainerControl = this;
            // 
            // eTypeRate
            // 
            this.eTypeRate.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(340, 630);
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
            this.btnSave.Location = new System.Drawing.Point(200, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(400, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 3;
            this.pbEmployee.TabStop = false;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 711);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSalary);
            this.Controls.Add(this.gbContract);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.lblContract);
            this.Name = "AddContractForm";
            this.Text = "Dodaj umowę";
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.gbContract.ResumeLayout(false);
            this.gbContract.PerformLayout();
            this.gbSalary.ResumeLayout(false);
            this.gbSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTypeContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eConclusionDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDepartament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTypeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.GroupBox gbContract;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblConclusionDate;
        private System.Windows.Forms.Label lblTypeContract;
        private System.Windows.Forms.ComboBox cbTypeContract;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpConclusionDate;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.GroupBox gbSalary;
        private System.Windows.Forms.Label lblTypeRate;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.ComboBox cbTypeRate;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider eLastName;
        private System.Windows.Forms.ErrorProvider eFirstName;
        private System.Windows.Forms.ErrorProvider eTypeContract;
        private System.Windows.Forms.ErrorProvider eConclusionDate;
        private System.Windows.Forms.ErrorProvider eDateFrom;
        private System.Windows.Forms.ErrorProvider eDateTo;
        private System.Windows.Forms.ErrorProvider ePosition;
        private System.Windows.Forms.ErrorProvider eDepartament;
        private System.Windows.Forms.ErrorProvider eSalary;
        private System.Windows.Forms.ErrorProvider eCurrency;
        private System.Windows.Forms.ErrorProvider eTypeRate;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.ComboBox cbLastName;
        private System.Windows.Forms.ComboBox cbDepartament;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}