namespace KiPKadryIPlace.UserInterface.Forms.Users
{
    partial class AddUserForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbPermission = new System.Windows.Forms.GroupBox();
            this.chbShowPayroll = new System.Windows.Forms.CheckBox();
            this.chbShowSalary = new System.Windows.Forms.CheckBox();
            this.chbShowOrganizationalStructure = new System.Windows.Forms.CheckBox();
            this.chbEditDepartaments = new System.Windows.Forms.CheckBox();
            this.chbEditPayroll = new System.Windows.Forms.CheckBox();
            this.chbShowDepartaments = new System.Windows.Forms.CheckBox();
            this.chbEditPositions = new System.Windows.Forms.CheckBox();
            this.chbShowPositions = new System.Windows.Forms.CheckBox();
            this.chbDeleteContracts = new System.Windows.Forms.CheckBox();
            this.chbShowContracts = new System.Windows.Forms.CheckBox();
            this.chbSendEmail = new System.Windows.Forms.CheckBox();
            this.chbEditEmployees = new System.Windows.Forms.CheckBox();
            this.chbShowEmployees = new System.Windows.Forms.CheckBox();
            this.lblEditPayroll = new System.Windows.Forms.Label();
            this.lblShowPayroll = new System.Windows.Forms.Label();
            this.lblShowSalary = new System.Windows.Forms.Label();
            this.lblShowOrganizationalStructure = new System.Windows.Forms.Label();
            this.lblEditDepartaments = new System.Windows.Forms.Label();
            this.lblShowDepartaments = new System.Windows.Forms.Label();
            this.lblEditPositions = new System.Windows.Forms.Label();
            this.lblShowPositions = new System.Windows.Forms.Label();
            this.lblDeleteContracts = new System.Windows.Forms.Label();
            this.lblShowContracts = new System.Windows.Forms.Label();
            this.lblSendEmail = new System.Windows.Forms.Label();
            this.lblEditEmployees = new System.Windows.Forms.Label();
            this.lblShowEmployees = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnSaveAndSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.eLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eEmailAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.eAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eEmailAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblUser.Location = new System.Drawing.Point(25, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(195, 30);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Dodaj użytkownika";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(130, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 25);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(20, 115);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 19);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Nazwisko";
            // 
            // gbPermission
            // 
            this.gbPermission.Controls.Add(this.chbShowPayroll);
            this.gbPermission.Controls.Add(this.chbShowSalary);
            this.gbPermission.Controls.Add(this.chbShowOrganizationalStructure);
            this.gbPermission.Controls.Add(this.chbEditDepartaments);
            this.gbPermission.Controls.Add(this.chbEditPayroll);
            this.gbPermission.Controls.Add(this.chbShowDepartaments);
            this.gbPermission.Controls.Add(this.chbEditPositions);
            this.gbPermission.Controls.Add(this.chbShowPositions);
            this.gbPermission.Controls.Add(this.chbDeleteContracts);
            this.gbPermission.Controls.Add(this.chbShowContracts);
            this.gbPermission.Controls.Add(this.chbSendEmail);
            this.gbPermission.Controls.Add(this.chbEditEmployees);
            this.gbPermission.Controls.Add(this.chbShowEmployees);
            this.gbPermission.Controls.Add(this.lblEditPayroll);
            this.gbPermission.Controls.Add(this.lblShowPayroll);
            this.gbPermission.Controls.Add(this.lblShowSalary);
            this.gbPermission.Controls.Add(this.lblShowOrganizationalStructure);
            this.gbPermission.Controls.Add(this.lblEditDepartaments);
            this.gbPermission.Controls.Add(this.lblShowDepartaments);
            this.gbPermission.Controls.Add(this.lblEditPositions);
            this.gbPermission.Controls.Add(this.lblShowPositions);
            this.gbPermission.Controls.Add(this.lblDeleteContracts);
            this.gbPermission.Controls.Add(this.lblShowContracts);
            this.gbPermission.Controls.Add(this.lblSendEmail);
            this.gbPermission.Controls.Add(this.lblEditEmployees);
            this.gbPermission.Controls.Add(this.lblShowEmployees);
            this.gbPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbPermission.Location = new System.Drawing.Point(25, 335);
            this.gbPermission.Name = "gbPermission";
            this.gbPermission.Size = new System.Drawing.Size(433, 287);
            this.gbPermission.TabIndex = 8;
            this.gbPermission.TabStop = false;
            this.gbPermission.Text = "Uprawnienia";
            // 
            // chbShowPayroll
            // 
            this.chbShowPayroll.AutoSize = true;
            this.chbShowPayroll.Location = new System.Drawing.Point(410, 220);
            this.chbShowPayroll.Name = "chbShowPayroll";
            this.chbShowPayroll.Size = new System.Drawing.Size(15, 14);
            this.chbShowPayroll.TabIndex = 30;
            this.chbShowPayroll.UseVisualStyleBackColor = true;
            // 
            // chbShowSalary
            // 
            this.chbShowSalary.AutoSize = true;
            this.chbShowSalary.Location = new System.Drawing.Point(410, 170);
            this.chbShowSalary.Name = "chbShowSalary";
            this.chbShowSalary.Size = new System.Drawing.Size(15, 14);
            this.chbShowSalary.TabIndex = 29;
            this.chbShowSalary.UseVisualStyleBackColor = true;
            // 
            // chbShowOrganizationalStructure
            // 
            this.chbShowOrganizationalStructure.AutoSize = true;
            this.chbShowOrganizationalStructure.Location = new System.Drawing.Point(410, 110);
            this.chbShowOrganizationalStructure.Name = "chbShowOrganizationalStructure";
            this.chbShowOrganizationalStructure.Size = new System.Drawing.Size(15, 14);
            this.chbShowOrganizationalStructure.TabIndex = 28;
            this.chbShowOrganizationalStructure.UseVisualStyleBackColor = true;
            // 
            // chbEditDepartaments
            // 
            this.chbEditDepartaments.AutoSize = true;
            this.chbEditDepartaments.Location = new System.Drawing.Point(410, 50);
            this.chbEditDepartaments.Name = "chbEditDepartaments";
            this.chbEditDepartaments.Size = new System.Drawing.Size(15, 14);
            this.chbEditDepartaments.TabIndex = 27;
            this.chbEditDepartaments.UseVisualStyleBackColor = true;
            // 
            // chbEditPayroll
            // 
            this.chbEditPayroll.AutoSize = true;
            this.chbEditPayroll.Location = new System.Drawing.Point(280, 250);
            this.chbEditPayroll.Name = "chbEditPayroll";
            this.chbEditPayroll.Size = new System.Drawing.Size(15, 14);
            this.chbEditPayroll.TabIndex = 26;
            this.chbEditPayroll.UseVisualStyleBackColor = true;
            // 
            // chbShowDepartaments
            // 
            this.chbShowDepartaments.AutoSize = true;
            this.chbShowDepartaments.Location = new System.Drawing.Point(280, 200);
            this.chbShowDepartaments.Name = "chbShowDepartaments";
            this.chbShowDepartaments.Size = new System.Drawing.Size(15, 14);
            this.chbShowDepartaments.TabIndex = 25;
            this.chbShowDepartaments.UseVisualStyleBackColor = true;
            // 
            // chbEditPositions
            // 
            this.chbEditPositions.AutoSize = true;
            this.chbEditPositions.Location = new System.Drawing.Point(280, 150);
            this.chbEditPositions.Name = "chbEditPositions";
            this.chbEditPositions.Size = new System.Drawing.Size(15, 14);
            this.chbEditPositions.TabIndex = 24;
            this.chbEditPositions.UseVisualStyleBackColor = true;
            // 
            // chbShowPositions
            // 
            this.chbShowPositions.AutoSize = true;
            this.chbShowPositions.Location = new System.Drawing.Point(280, 100);
            this.chbShowPositions.Name = "chbShowPositions";
            this.chbShowPositions.Size = new System.Drawing.Size(15, 14);
            this.chbShowPositions.TabIndex = 23;
            this.chbShowPositions.UseVisualStyleBackColor = true;
            // 
            // chbDeleteContracts
            // 
            this.chbDeleteContracts.AutoSize = true;
            this.chbDeleteContracts.Location = new System.Drawing.Point(280, 50);
            this.chbDeleteContracts.Name = "chbDeleteContracts";
            this.chbDeleteContracts.Size = new System.Drawing.Size(15, 14);
            this.chbDeleteContracts.TabIndex = 22;
            this.chbDeleteContracts.UseVisualStyleBackColor = true;
            // 
            // chbShowContracts
            // 
            this.chbShowContracts.AutoSize = true;
            this.chbShowContracts.Location = new System.Drawing.Point(140, 200);
            this.chbShowContracts.Name = "chbShowContracts";
            this.chbShowContracts.Size = new System.Drawing.Size(15, 14);
            this.chbShowContracts.TabIndex = 21;
            this.chbShowContracts.UseVisualStyleBackColor = true;
            // 
            // chbSendEmail
            // 
            this.chbSendEmail.AutoSize = true;
            this.chbSendEmail.Location = new System.Drawing.Point(140, 150);
            this.chbSendEmail.Name = "chbSendEmail";
            this.chbSendEmail.Size = new System.Drawing.Size(15, 14);
            this.chbSendEmail.TabIndex = 20;
            this.chbSendEmail.UseVisualStyleBackColor = true;
            // 
            // chbEditEmployees
            // 
            this.chbEditEmployees.AutoSize = true;
            this.chbEditEmployees.Location = new System.Drawing.Point(140, 100);
            this.chbEditEmployees.Name = "chbEditEmployees";
            this.chbEditEmployees.Size = new System.Drawing.Size(15, 14);
            this.chbEditEmployees.TabIndex = 19;
            this.chbEditEmployees.UseVisualStyleBackColor = true;
            // 
            // chbShowEmployees
            // 
            this.chbShowEmployees.AutoSize = true;
            this.chbShowEmployees.Location = new System.Drawing.Point(140, 50);
            this.chbShowEmployees.Name = "chbShowEmployees";
            this.chbShowEmployees.Size = new System.Drawing.Size(15, 14);
            this.chbShowEmployees.TabIndex = 18;
            this.chbShowEmployees.UseVisualStyleBackColor = true;
            // 
            // lblEditPayroll
            // 
            this.lblEditPayroll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEditPayroll.Location = new System.Drawing.Point(170, 235);
            this.lblEditPayroll.Name = "lblEditPayroll";
            this.lblEditPayroll.Size = new System.Drawing.Size(87, 40);
            this.lblEditPayroll.TabIndex = 12;
            this.lblEditPayroll.Text = "Edycja listy płac";
            // 
            // lblShowPayroll
            // 
            this.lblShowPayroll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowPayroll.Location = new System.Drawing.Point(310, 205);
            this.lblShowPayroll.Name = "lblShowPayroll";
            this.lblShowPayroll.Size = new System.Drawing.Size(102, 38);
            this.lblShowPayroll.TabIndex = 11;
            this.lblShowPayroll.Text = "Przeglądanie listy płac";
            // 
            // lblShowSalary
            // 
            this.lblShowSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowSalary.Location = new System.Drawing.Point(310, 155);
            this.lblShowSalary.Name = "lblShowSalary";
            this.lblShowSalary.Size = new System.Drawing.Size(102, 38);
            this.lblShowSalary.TabIndex = 10;
            this.lblShowSalary.Text = "Przeglądanie wynagrodzeń";
            // 
            // lblShowOrganizationalStructure
            // 
            this.lblShowOrganizationalStructure.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowOrganizationalStructure.Location = new System.Drawing.Point(310, 85);
            this.lblShowOrganizationalStructure.Name = "lblShowOrganizationalStructure";
            this.lblShowOrganizationalStructure.Size = new System.Drawing.Size(102, 66);
            this.lblShowOrganizationalStructure.TabIndex = 9;
            this.lblShowOrganizationalStructure.Text = "Przeglądanie struktury organizacyjnej";
            // 
            // lblEditDepartaments
            // 
            this.lblEditDepartaments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEditDepartaments.Location = new System.Drawing.Point(310, 35);
            this.lblEditDepartaments.Name = "lblEditDepartaments";
            this.lblEditDepartaments.Size = new System.Drawing.Size(84, 41);
            this.lblEditDepartaments.TabIndex = 8;
            this.lblEditDepartaments.Text = "Edycja działów";
            // 
            // lblShowDepartaments
            // 
            this.lblShowDepartaments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowDepartaments.Location = new System.Drawing.Point(170, 185);
            this.lblShowDepartaments.Name = "lblShowDepartaments";
            this.lblShowDepartaments.Size = new System.Drawing.Size(87, 45);
            this.lblShowDepartaments.TabIndex = 7;
            this.lblShowDepartaments.Text = "Przeglądanie działów";
            // 
            // lblEditPositions
            // 
            this.lblEditPositions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEditPositions.Location = new System.Drawing.Point(170, 135);
            this.lblEditPositions.Name = "lblEditPositions";
            this.lblEditPositions.Size = new System.Drawing.Size(87, 41);
            this.lblEditPositions.TabIndex = 6;
            this.lblEditPositions.Text = "Edycja stanowisk";
            // 
            // lblShowPositions
            // 
            this.lblShowPositions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowPositions.Location = new System.Drawing.Point(170, 85);
            this.lblShowPositions.Name = "lblShowPositions";
            this.lblShowPositions.Size = new System.Drawing.Size(87, 47);
            this.lblShowPositions.TabIndex = 5;
            this.lblShowPositions.Text = "Przeglądanie stanowisk";
            // 
            // lblDeleteContracts
            // 
            this.lblDeleteContracts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeleteContracts.Location = new System.Drawing.Point(170, 35);
            this.lblDeleteContracts.Name = "lblDeleteContracts";
            this.lblDeleteContracts.Size = new System.Drawing.Size(87, 41);
            this.lblDeleteContracts.TabIndex = 4;
            this.lblDeleteContracts.Text = "Usuwanie umów";
            // 
            // lblShowContracts
            // 
            this.lblShowContracts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowContracts.Location = new System.Drawing.Point(10, 185);
            this.lblShowContracts.Name = "lblShowContracts";
            this.lblShowContracts.Size = new System.Drawing.Size(114, 48);
            this.lblShowContracts.TabIndex = 3;
            this.lblShowContracts.Text = "Przeglądanie umów";
            // 
            // lblSendEmail
            // 
            this.lblSendEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSendEmail.Location = new System.Drawing.Point(10, 135);
            this.lblSendEmail.Name = "lblSendEmail";
            this.lblSendEmail.Size = new System.Drawing.Size(123, 41);
            this.lblSendEmail.TabIndex = 2;
            this.lblSendEmail.Text = "Wysyłanie wiadomości e-mail";
            // 
            // lblEditEmployees
            // 
            this.lblEditEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEditEmployees.Location = new System.Drawing.Point(10, 85);
            this.lblEditEmployees.Name = "lblEditEmployees";
            this.lblEditEmployees.Size = new System.Drawing.Size(97, 47);
            this.lblEditEmployees.TabIndex = 1;
            this.lblEditEmployees.Text = "Edycja pracowników";
            // 
            // lblShowEmployees
            // 
            this.lblShowEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShowEmployees.Location = new System.Drawing.Point(10, 35);
            this.lblShowEmployees.Name = "lblShowEmployees";
            this.lblShowEmployees.Size = new System.Drawing.Size(97, 41);
            this.lblShowEmployees.TabIndex = 0;
            this.lblShowEmployees.Text = "Przeglądanie pracowników";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(20, 155);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(38, 19);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "Imię";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailAddress.Location = new System.Drawing.Point(20, 195);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(95, 19);
            this.lblEmailAddress.TabIndex = 9;
            this.lblEmailAddress.Text = "Adres e-mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 235);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Nazwa";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(20, 275);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 19);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Hasło";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.Location = new System.Drawing.Point(320, 235);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(102, 19);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Administrator";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailAddress.Location = new System.Drawing.Point(130, 190);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(165, 25);
            this.txtEmailAddress.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(130, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 25);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(130, 230);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 25);
            this.txtName.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(130, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 25);
            this.txtPassword.TabIndex = 16;
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Location = new System.Drawing.Point(430, 240);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(15, 14);
            this.chbAdmin.TabIndex = 17;
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGeneratePassword.Location = new System.Drawing.Point(90, 305);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(115, 25);
            this.btnGeneratePassword.TabIndex = 22;
            this.btnGeneratePassword.Text = "Generuj hasło";
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowPassword.Location = new System.Drawing.Point(210, 305);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(100, 25);
            this.btnShowPassword.TabIndex = 23;
            this.btnShowPassword.Text = "Pokaż hasło";
            this.btnShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnSaveAndSend
            // 
            this.btnSaveAndSend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveAndSend.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSaveAndSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAndSend.Location = new System.Drawing.Point(60, 640);
            this.btnSaveAndSend.Name = "btnSaveAndSend";
            this.btnSaveAndSend.Size = new System.Drawing.Size(130, 50);
            this.btnSaveAndSend.TabIndex = 21;
            this.btnSaveAndSend.Text = "Zapisz i wyślij";
            this.btnSaveAndSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAndSend.UseVisualStyleBackColor = false;
            this.btnSaveAndSend.Click += new System.EventHandler(this.btnSaveAndSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(340, 640);
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
            this.btnSave.Location = new System.Drawing.Point(200, 640);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(380, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 5;
            this.pbEmployee.TabStop = false;
            // 
            // eLastName
            // 
            this.eLastName.ContainerControl = this;
            // 
            // eFirstName
            // 
            this.eFirstName.ContainerControl = this;
            // 
            // eEmailAddress
            // 
            this.eEmailAddress.ContainerControl = this;
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // ePassword
            // 
            this.ePassword.ContainerControl = this;
            // 
            // eAdmin
            // 
            this.eAdmin.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 711);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnSaveAndSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.gbPermission);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj użytkownika";
            this.gbPermission.ResumeLayout(false);
            this.gbPermission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eEmailAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gbPermission;
        private System.Windows.Forms.Label lblShowEmployees;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.Label lblEditPayroll;
        private System.Windows.Forms.Label lblShowPayroll;
        private System.Windows.Forms.Label lblShowSalary;
        private System.Windows.Forms.Label lblShowOrganizationalStructure;
        private System.Windows.Forms.Label lblEditDepartaments;
        private System.Windows.Forms.Label lblShowDepartaments;
        private System.Windows.Forms.Label lblEditPositions;
        private System.Windows.Forms.Label lblShowPositions;
        private System.Windows.Forms.Label lblDeleteContracts;
        private System.Windows.Forms.Label lblShowContracts;
        private System.Windows.Forms.Label lblSendEmail;
        private System.Windows.Forms.Label lblEditEmployees;
        private System.Windows.Forms.CheckBox chbShowPayroll;
        private System.Windows.Forms.CheckBox chbShowSalary;
        private System.Windows.Forms.CheckBox chbShowOrganizationalStructure;
        private System.Windows.Forms.CheckBox chbEditDepartaments;
        private System.Windows.Forms.CheckBox chbEditPayroll;
        private System.Windows.Forms.CheckBox chbShowDepartaments;
        private System.Windows.Forms.CheckBox chbEditPositions;
        private System.Windows.Forms.CheckBox chbShowPositions;
        private System.Windows.Forms.CheckBox chbDeleteContracts;
        private System.Windows.Forms.CheckBox chbShowContracts;
        private System.Windows.Forms.CheckBox chbSendEmail;
        private System.Windows.Forms.CheckBox chbEditEmployees;
        private System.Windows.Forms.CheckBox chbShowEmployees;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAndSend;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.ErrorProvider eLastName;
        private System.Windows.Forms.ErrorProvider eFirstName;
        private System.Windows.Forms.ErrorProvider eEmailAddress;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ErrorProvider ePassword;
        private System.Windows.Forms.ErrorProvider eAdmin;
    }
}