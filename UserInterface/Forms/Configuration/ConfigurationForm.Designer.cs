namespace KiPKadryIPlace.UserInterface.Forms.Configuration
{
    partial class ConfigurationForm
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
            this.pbConfiguration = new System.Windows.Forms.PictureBox();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.pConfiguration = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguration)).BeginInit();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbConfiguration
            // 
            this.pbConfiguration.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbConfiguration.Location = new System.Drawing.Point(300, 5);
            this.pbConfiguration.Name = "pbConfiguration";
            this.pbConfiguration.Size = new System.Drawing.Size(64, 64);
            this.pbConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbConfiguration.TabIndex = 46;
            this.pbConfiguration.TabStop = false;
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.BackColor = System.Drawing.Color.Green;
            this.lblConfiguration.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblConfiguration.ForeColor = System.Drawing.Color.White;
            this.lblConfiguration.Location = new System.Drawing.Point(25, 20);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(132, 30);
            this.lblConfiguration.TabIndex = 45;
            this.lblConfiguration.Text = "Konfiguracja";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(160, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(270, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(190, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 25);
            this.txtPassword.TabIndex = 52;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(20, 205);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 19);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Hasło";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.Location = new System.Drawing.Point(20, 145);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(93, 19);
            this.lblDatabase.TabIndex = 49;
            this.lblDatabase.Text = "Baza danych";
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.Green;
            this.pButtons.Controls.Add(this.btnSave);
            this.pButtons.Controls.Add(this.btnCancel);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 262);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(384, 79);
            this.pButtons.TabIndex = 48;
            // 
            // pConfiguration
            // 
            this.pConfiguration.BackColor = System.Drawing.Color.Green;
            this.pConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConfiguration.Location = new System.Drawing.Point(0, 0);
            this.pConfiguration.Name = "pConfiguration";
            this.pConfiguration.Size = new System.Drawing.Size(384, 72);
            this.pConfiguration.TabIndex = 47;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.Location = new System.Drawing.Point(190, 170);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 25);
            this.txtUser.TabIndex = 53;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDatabase.Location = new System.Drawing.Point(190, 140);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(165, 25);
            this.txtDatabase.TabIndex = 54;
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServerName.Location = new System.Drawing.Point(190, 110);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(165, 25);
            this.txtServerName.TabIndex = 55;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblServerName.Location = new System.Drawing.Point(20, 115);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(111, 19);
            this.lblServerName.TabIndex = 56;
            this.lblServerName.Text = "Nazwa serwera";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(20, 175);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 19);
            this.lblUser.TabIndex = 57;
            this.lblUser.Text = "Nazwa użytkownika";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pbConfiguration);
            this.Controls.Add(this.lblConfiguration);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pConfiguration);
            this.Name = "ConfigurationForm";
            this.Text = "Konfiguracja";
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguration)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConfiguration;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pConfiguration;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblUser;
    }
}