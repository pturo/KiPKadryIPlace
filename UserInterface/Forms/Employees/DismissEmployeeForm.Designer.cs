namespace KiPKadryIPlace.UserInterface.Forms.Employees
{
    partial class DismissEmployeeForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblMethodOfTerminationContract = new System.Windows.Forms.Label();
            this.lblTerminationContractDate = new System.Windows.Forms.Label();
            this.cbMethodOfTerminationContract = new System.Windows.Forms.ComboBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.eMethodOfTerminationContract = new System.Windows.Forms.ErrorProvider(this.components);
            this.eTerminationContractDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMethodOfTerminationContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTerminationContractDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblEmployee.Location = new System.Drawing.Point(25, 40);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(304, 30);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Imię Nazwisko (Kod) - STATUS";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(415, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 5;
            this.pbEmployee.TabStop = false;
            // 
            // lblMethodOfTerminationContract
            // 
            this.lblMethodOfTerminationContract.AutoSize = true;
            this.lblMethodOfTerminationContract.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMethodOfTerminationContract.Location = new System.Drawing.Point(40, 125);
            this.lblMethodOfTerminationContract.Name = "lblMethodOfTerminationContract";
            this.lblMethodOfTerminationContract.Size = new System.Drawing.Size(196, 19);
            this.lblMethodOfTerminationContract.TabIndex = 6;
            this.lblMethodOfTerminationContract.Text = "Sposób rozwiązania umowy";
            // 
            // lblTerminationContractDate
            // 
            this.lblTerminationContractDate.AutoSize = true;
            this.lblTerminationContractDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTerminationContractDate.Location = new System.Drawing.Point(40, 165);
            this.lblTerminationContractDate.Name = "lblTerminationContractDate";
            this.lblTerminationContractDate.Size = new System.Drawing.Size(179, 19);
            this.lblTerminationContractDate.TabIndex = 7;
            this.lblTerminationContractDate.Text = "Data zakończenia umowy";
            // 
            // cbMethodOfTerminationContract
            // 
            this.cbMethodOfTerminationContract.DisplayMember = "Value";
            this.cbMethodOfTerminationContract.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMethodOfTerminationContract.FormattingEnabled = true;
            this.cbMethodOfTerminationContract.Location = new System.Drawing.Point(300, 120);
            this.cbMethodOfTerminationContract.Name = "cbMethodOfTerminationContract";
            this.cbMethodOfTerminationContract.Size = new System.Drawing.Size(165, 25);
            this.cbMethodOfTerminationContract.TabIndex = 8;
            this.cbMethodOfTerminationContract.ValueMember = "Id";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(300, 160);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(165, 25);
            this.dtpDateBirth.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(340, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(200, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // eMethodOfTerminationContract
            // 
            this.eMethodOfTerminationContract.ContainerControl = this;
            // 
            // eTerminationContractDate
            // 
            this.eTerminationContractDate.ContainerControl = this;
            // 
            // FireEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.cbMethodOfTerminationContract);
            this.Controls.Add(this.lblTerminationContractDate);
            this.Controls.Add(this.lblMethodOfTerminationContract);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "FireEmployee";
            this.Text = "Zwolnij pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMethodOfTerminationContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTerminationContractDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblMethodOfTerminationContract;
        private System.Windows.Forms.Label lblTerminationContractDate;
        private System.Windows.Forms.ComboBox cbMethodOfTerminationContract;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider eMethodOfTerminationContract;
        private System.Windows.Forms.ErrorProvider eTerminationContractDate;
    }
}