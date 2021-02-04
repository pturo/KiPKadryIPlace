namespace KiPKadryIPlace.UserInterface.Forms.Salaries
{
    partial class SalariesForm
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
            this.tlpSalaries = new System.Windows.Forms.TableLayoutPanel();
            this.pSalaries = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pSalariesButtons = new System.Windows.Forms.Panel();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSalaries = new System.Windows.Forms.BindingSource(this.components);
            this.tlpSalaries.SuspendLayout();
            this.pSalaries.SuspendLayout();
            this.pSalariesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSalaries
            // 
            this.tlpSalaries.ColumnCount = 1;
            this.tlpSalaries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaries.Controls.Add(this.pSalaries, 0, 0);
            this.tlpSalaries.Controls.Add(this.pSalariesButtons, 0, 1);
            this.tlpSalaries.Controls.Add(this.dgvSalaries, 0, 2);
            this.tlpSalaries.Location = new System.Drawing.Point(0, 0);
            this.tlpSalaries.Name = "tlpSalaries";
            this.tlpSalaries.RowCount = 3;
            this.tlpSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tlpSalaries.Size = new System.Drawing.Size(800, 450);
            this.tlpSalaries.TabIndex = 3;
            // 
            // pSalaries
            // 
            this.pSalaries.Controls.Add(this.btnModify);
            this.pSalaries.Controls.Add(this.btnCreate);
            this.pSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSalaries.Location = new System.Drawing.Point(3, 3);
            this.pSalaries.Name = "pSalaries";
            this.pSalaries.Size = new System.Drawing.Size(794, 34);
            this.pSalaries.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModify.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(105, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Następny";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreate.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.add_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Poprzedni";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // pSalariesButtons
            // 
            this.pSalariesButtons.Controls.Add(this.txtPesel);
            this.pSalariesButtons.Controls.Add(this.txtBirthDate);
            this.pSalariesButtons.Controls.Add(this.txtFirstName);
            this.pSalariesButtons.Controls.Add(this.txtGender);
            this.pSalariesButtons.Controls.Add(this.txtPosition);
            this.pSalariesButtons.Controls.Add(this.txtStatus);
            this.pSalariesButtons.Controls.Add(this.lblStatus);
            this.pSalariesButtons.Controls.Add(this.lblPosition);
            this.pSalariesButtons.Controls.Add(this.lblPesel);
            this.pSalariesButtons.Controls.Add(this.lblDateBirth);
            this.pSalariesButtons.Controls.Add(this.lblGender);
            this.pSalariesButtons.Controls.Add(this.lblFirstName);
            this.pSalariesButtons.Controls.Add(this.txtLastName);
            this.pSalariesButtons.Controls.Add(this.lblLastName);
            this.pSalariesButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSalariesButtons.Location = new System.Drawing.Point(3, 43);
            this.pSalariesButtons.Name = "pSalariesButtons";
            this.pSalariesButtons.Size = new System.Drawing.Size(794, 99);
            this.pSalariesButtons.TabIndex = 1;
            // 
            // txtPesel
            // 
            this.txtPesel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesel.Location = new System.Drawing.Point(480, 55);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.ReadOnly = true;
            this.txtPesel.Size = new System.Drawing.Size(100, 25);
            this.txtPesel.TabIndex = 14;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBirthDate.Location = new System.Drawing.Point(320, 55);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(100, 25);
            this.txtBirthDate.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(320, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 25);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGender.Location = new System.Drawing.Point(90, 55);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(100, 25);
            this.txtGender.TabIndex = 10;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Location = new System.Drawing.Point(680, 56);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(100, 25);
            this.txtPosition.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatus.Location = new System.Drawing.Point(680, 15);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 25);
            this.txtStatus.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(590, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(590, 60);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(85, 19);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Stanowisko";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPesel.Location = new System.Drawing.Point(430, 60);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(47, 19);
            this.lblPesel.TabIndex = 5;
            this.lblPesel.Text = "PESEL";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateBirth.Location = new System.Drawing.Point(200, 60);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(111, 19);
            this.lblDateBirth.TabIndex = 4;
            this.lblDateBirth.Text = "Data urodzenia";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(10, 60);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 19);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Płeć";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(200, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(38, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Imię";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(90, 15);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 25);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(10, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 19);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nazwisko";
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.AllowUserToAddRows = false;
            this.dgvSalaries.AllowUserToDeleteRows = false;
            this.dgvSalaries.AutoGenerateColumns = false;
            this.dgvSalaries.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSalary,
            this.colCurrency,
            this.colTypeRate,
            this.colDateFrom,
            this.colDateTo});
            this.dgvSalaries.DataSource = this.bsSalaries;
            this.dgvSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaries.Location = new System.Drawing.Point(3, 148);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.ReadOnly = true;
            this.dgvSalaries.RowHeadersVisible = false;
            this.dgvSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaries.Size = new System.Drawing.Size(794, 299);
            this.dgvSalaries.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colSalary
            // 
            this.colSalary.DataPropertyName = "Salary";
            this.colSalary.HeaderText = "Kwota";
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            this.colSalary.Width = 150;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.HeaderText = "Waluta";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Width = 150;
            // 
            // colTypeRate
            // 
            this.colTypeRate.DataPropertyName = "TypeRate";
            this.colTypeRate.HeaderText = "Rodzaj stawki";
            this.colTypeRate.Name = "colTypeRate";
            this.colTypeRate.ReadOnly = true;
            this.colTypeRate.Width = 150;
            // 
            // colDateFrom
            // 
            this.colDateFrom.DataPropertyName = "DateFrom";
            this.colDateFrom.HeaderText = "Data od";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ReadOnly = true;
            this.colDateFrom.Width = 150;
            // 
            // colDateTo
            // 
            this.colDateTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDateTo.DataPropertyName = "DateTo";
            this.colDateTo.HeaderText = "Data do";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ReadOnly = true;
            // 
            // bsSalaries
            // 
            this.bsSalaries.DataSource = typeof(KiPKadryIPlace.DataAccessLayer.ViewModels.SalaryViewModel);
            // 
            // SalariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpSalaries);
            this.Name = "SalariesForm";
            this.Text = "Wynagrodzenia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalariesForm_FormClosed);
            this.tlpSalaries.ResumeLayout(false);
            this.pSalaries.ResumeLayout(false);
            this.pSalariesButtons.ResumeLayout(false);
            this.pSalariesButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSalaries;
        private System.Windows.Forms.Panel pSalaries;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pSalariesButtons;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.BindingSource bsSalaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
    }
}