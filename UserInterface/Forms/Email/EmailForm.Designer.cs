namespace KiPKadryIPlace.UserInterface.Forms.Email
{
    partial class EmailForm
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.gbCredentials = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.eAddressServer = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePort = new System.Windows.Forms.ErrorProvider(this.components);
            this.eUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.gbCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eAddressServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPort.Location = new System.Drawing.Point(180, 140);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(145, 25);
            this.txtPort.TabIndex = 49;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServerAddress.Location = new System.Drawing.Point(180, 110);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(145, 25);
            this.txtServerAddress.TabIndex = 44;
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblServerAddress.Location = new System.Drawing.Point(30, 115);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(105, 19);
            this.lblServerAddress.TabIndex = 43;
            this.lblServerAddress.Text = "Adres serwera";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPort.Location = new System.Drawing.Point(30, 145);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 19);
            this.lblPort.TabIndex = 45;
            this.lblPort.Text = "Port";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblEmail.Location = new System.Drawing.Point(25, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 30);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Poczta";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(90, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
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
            // gbCredentials
            // 
            this.gbCredentials.Controls.Add(this.txtPassword);
            this.gbCredentials.Controls.Add(this.lblPassword);
            this.gbCredentials.Controls.Add(this.txtUser);
            this.gbCredentials.Controls.Add(this.lblUser);
            this.gbCredentials.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbCredentials.Location = new System.Drawing.Point(20, 170);
            this.gbCredentials.Name = "gbCredentials";
            this.gbCredentials.Size = new System.Drawing.Size(350, 120);
            this.gbCredentials.TabIndex = 50;
            this.gbCredentials.TabStop = false;
            this.gbCredentials.Text = "Poświadczenia";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(150, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 25);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(10, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 19);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Hasło";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.Location = new System.Drawing.Point(150, 30);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 25);
            this.txtUser.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(10, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 19);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Użytkownik";
            // 
            // eAddressServer
            // 
            this.eAddressServer.ContainerControl = this;
            // 
            // ePort
            // 
            this.ePort.ContainerControl = this;
            // 
            // eUser
            // 
            this.eUser.ContainerControl = this;
            // 
            // ePassword
            // 
            this.ePassword.ContainerControl = this;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.gbCredentials);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguracja poczty";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.gbCredentials.ResumeLayout(false);
            this.gbCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eAddressServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbCredentials;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ErrorProvider eAddressServer;
        private System.Windows.Forms.ErrorProvider ePort;
        private System.Windows.Forms.ErrorProvider eUser;
        private System.Windows.Forms.ErrorProvider ePassword;
    }
}