namespace KiPKadryIPlace.UserInterface.Forms.Login
{
    partial class LoginForm
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
            this.lblKiP = new System.Windows.Forms.Label();
            this.pbKiP = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pKiP = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKiP)).BeginInit();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKiP
            // 
            this.lblKiP.AutoSize = true;
            this.lblKiP.BackColor = System.Drawing.Color.Green;
            this.lblKiP.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblKiP.ForeColor = System.Drawing.Color.White;
            this.lblKiP.Location = new System.Drawing.Point(25, 20);
            this.lblKiP.Name = "lblKiP";
            this.lblKiP.Size = new System.Drawing.Size(188, 30);
            this.lblKiP.TabIndex = 26;
            this.lblKiP.Text = "KiP - Kadry i Płace";
            // 
            // pbKiP
            // 
            this.pbKiP.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbKiP.Location = new System.Drawing.Point(300, 5);
            this.pbKiP.Name = "pbKiP";
            this.pbKiP.Size = new System.Drawing.Size(64, 64);
            this.pbKiP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbKiP.TabIndex = 27;
            this.pbKiP.TabStop = false;
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
            // pKiP
            // 
            this.pKiP.BackColor = System.Drawing.Color.Green;
            this.pKiP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pKiP.Location = new System.Drawing.Point(0, 0);
            this.pKiP.Name = "pKiP";
            this.pKiP.Size = new System.Drawing.Size(384, 72);
            this.pKiP.TabIndex = 37;
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.Green;
            this.pButtons.Controls.Add(this.btnConfiguration);
            this.pButtons.Controls.Add(this.btnSave);
            this.pButtons.Controls.Add(this.btnCancel);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 262);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(384, 79);
            this.pButtons.TabIndex = 38;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.White;
            this.btnConfiguration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguration.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.Location = new System.Drawing.Point(20, 15);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(130, 50);
            this.btnConfiguration.TabIndex = 37;
            this.btnConfiguration.Text = "Konfiguracja";
            this.btnConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Value";
            this.cbUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(190, 130);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(165, 25);
            this.cbUser.TabIndex = 40;
            this.cbUser.ValueMember = "Id";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(20, 135);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 19);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "Nazwa użytkownika";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(190, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 25);
            this.txtPassword.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(20, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 19);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Hasło";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserInfo.Location = new System.Drawing.Point(20, 80);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(335, 41);
            this.lblUserInfo.TabIndex = 43;
            this.lblUserInfo.Text = "Wprowadź swoją nazwę użytkownika oraz hasło dostępu do programu.";
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWarning.Location = new System.Drawing.Point(20, 195);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(335, 59);
            this.lblWarning.TabIndex = 44;
            this.lblWarning.Text = "UWAGA: W haśle dostępu mają znaczenie duże i małe litery. Sprawdź, czy nie jest w" +
    "ciśnięty klawisz CAPS LOCK.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbKiP);
            this.Controls.Add(this.lblKiP);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pKiP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.pbKiP)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiP;
        private System.Windows.Forms.PictureBox pbKiP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pKiP;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnConfiguration;
    }
}