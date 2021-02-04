namespace KiPKadryIPlace.UserInterface.Forms.Departaments
{
    partial class EditDepartamentForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.eParentDepartament = new System.Windows.Forms.ErrorProvider(this.components);
            this.eManager = new System.Windows.Forms.ErrorProvider(this.components);
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblParentDepartament = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.cbParentDepartament = new System.Windows.Forms.ComboBox();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eParentDepartament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // eParentDepartament
            // 
            this.eParentDepartament.ContainerControl = this;
            // 
            // eManager
            // 
            this.eManager.ContainerControl = this;
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(180, 170);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(145, 45);
            this.txtLocation.TabIndex = 51;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(30, 175);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 19);
            this.lblLocation.TabIndex = 50;
            this.lblLocation.Text = "Lokalizacja";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(90, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblParentDepartament
            // 
            this.lblParentDepartament.AutoSize = true;
            this.lblParentDepartament.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblParentDepartament.Location = new System.Drawing.Point(30, 225);
            this.lblParentDepartament.Name = "lblParentDepartament";
            this.lblParentDepartament.Size = new System.Drawing.Size(151, 19);
            this.lblParentDepartament.TabIndex = 46;
            this.lblParentDepartament.Text = "Kierownik nadrzędny";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(180, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 25);
            this.txtName.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Nazwa";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblManager.Location = new System.Drawing.Point(30, 145);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(120, 19);
            this.lblManager.TabIndex = 45;
            this.lblManager.Text = "Kierownik działu";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(290, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 42;
            this.pbEmployee.TabStop = false;
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDepartament.Location = new System.Drawing.Point(25, 40);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(60, 30);
            this.lblDepartament.TabIndex = 41;
            this.lblDepartament.Text = "Dział";
            // 
            // cbParentDepartament
            // 
            this.cbParentDepartament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbParentDepartament.FormattingEnabled = true;
            this.cbParentDepartament.Location = new System.Drawing.Point(180, 220);
            this.cbParentDepartament.Name = "cbParentDepartament";
            this.cbParentDepartament.Size = new System.Drawing.Size(145, 25);
            this.cbParentDepartament.TabIndex = 53;
            // 
            // cbManager
            // 
            this.cbManager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(180, 140);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(145, 25);
            this.cbManager.TabIndex = 52;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(110, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 19);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "ID działu";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(180, 45);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(32, 25);
            this.txtID.TabIndex = 55;
            // 
            // EditDepartamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cbParentDepartament);
            this.Controls.Add(this.cbManager);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblParentDepartament);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblDepartament);
            this.Name = "EditDepartamentForm";
            this.Text = "Modyfikuj dział";
            ((System.ComponentModel.ISupportInitialize)(this.eParentDepartament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider eParentDepartament;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblParentDepartament;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.ErrorProvider eManager;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ComboBox cbParentDepartament;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}