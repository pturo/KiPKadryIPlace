namespace KiPKadryIPlace.UserInterface.Forms.Departaments
{
    partial class AddDepartamentForm
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
            this.lblParentDepartament = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eManager = new System.Windows.Forms.ErrorProvider(this.components);
            this.eParentDepartament = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPosition = new System.Windows.Forms.PictureBox();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.cbParentDepartament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eParentDepartament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParentDepartament
            // 
            this.lblParentDepartament.AutoSize = true;
            this.lblParentDepartament.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblParentDepartament.Location = new System.Drawing.Point(30, 225);
            this.lblParentDepartament.Name = "lblParentDepartament";
            this.lblParentDepartament.Size = new System.Drawing.Size(117, 19);
            this.lblParentDepartament.TabIndex = 31;
            this.lblParentDepartament.Text = "Dział nadrzędny";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(180, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 25);
            this.txtName.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nazwa";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblManager.Location = new System.Drawing.Point(30, 145);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(120, 19);
            this.lblManager.TabIndex = 29;
            this.lblManager.Text = "Kierownik działu";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDepartament.Location = new System.Drawing.Point(25, 40);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(60, 30);
            this.lblDepartament.TabIndex = 25;
            this.lblDepartament.Text = "Dział";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(30, 175);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 19);
            this.lblLocation.TabIndex = 36;
            this.lblLocation.Text = "Lokalizacja";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(180, 170);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(145, 45);
            this.txtLocation.TabIndex = 37;
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // eManager
            // 
            this.eManager.ContainerControl = this;
            // 
            // eParentDepartament
            // 
            this.eParentDepartament.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 34;
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
            this.btnSave.Location = new System.Drawing.Point(90, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPosition
            // 
            this.pbPosition.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbPosition.Location = new System.Drawing.Point(290, 15);
            this.pbPosition.Name = "pbPosition";
            this.pbPosition.Size = new System.Drawing.Size(64, 64);
            this.pbPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPosition.TabIndex = 26;
            this.pbPosition.TabStop = false;
            // 
            // cbManager
            // 
            this.cbManager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(180, 140);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(145, 25);
            this.cbManager.TabIndex = 38;
            // 
            // cbParentDepartament
            // 
            this.cbParentDepartament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbParentDepartament.FormattingEnabled = true;
            this.cbParentDepartament.Location = new System.Drawing.Point(180, 220);
            this.cbParentDepartament.Name = "cbParentDepartament";
            this.cbParentDepartament.Size = new System.Drawing.Size(145, 25);
            this.cbParentDepartament.TabIndex = 39;
            // 
            // AddDepartamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.cbParentDepartament);
            this.Controls.Add(this.cbManager);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblParentDepartament);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.pbPosition);
            this.Controls.Add(this.lblDepartament);
            this.Name = "AddDepartamentForm";
            this.Text = "Dodaj dział";
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eParentDepartament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblParentDepartament;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.PictureBox pbPosition;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ErrorProvider eManager;
        private System.Windows.Forms.ErrorProvider eParentDepartament;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.ComboBox cbParentDepartament;
    }
}