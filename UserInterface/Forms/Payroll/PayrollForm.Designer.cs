namespace KiPKadryIPlace.UserInterface.Forms.Payroll
{
    partial class PayrollForm
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
            this.tlpPayrolls = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPayrolls = new System.Windows.Forms.DataGridView();
            this.bsPayrolls = new System.Windows.Forms.BindingSource(this.components);
            this.pPayrolls = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pBottomPayroll = new System.Windows.Forms.Panel();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.lblToPay = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPayrolls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayrolls)).BeginInit();
            this.pPayrolls.SuspendLayout();
            this.pBottomPayroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPayrolls
            // 
            this.tlpPayrolls.ColumnCount = 1;
            this.tlpPayrolls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayrolls.Controls.Add(this.dgvPayrolls, 0, 1);
            this.tlpPayrolls.Controls.Add(this.pPayrolls, 0, 0);
            this.tlpPayrolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayrolls.Location = new System.Drawing.Point(0, 0);
            this.tlpPayrolls.Name = "tlpPayrolls";
            this.tlpPayrolls.RowCount = 3;
            this.tlpPayrolls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPayrolls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayrolls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPayrolls.Size = new System.Drawing.Size(800, 397);
            this.tlpPayrolls.TabIndex = 2;
            // 
            // dgvPayrolls
            // 
            this.dgvPayrolls.AllowUserToAddRows = false;
            this.dgvPayrolls.AllowUserToDeleteRows = false;
            this.dgvPayrolls.AutoGenerateColumns = false;
            this.dgvPayrolls.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayrolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayrolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFullName,
            this.colRateHour,
            this.hourDay,
            this.colDaysWorked,
            this.colDatePay,
            this.colMonth,
            this.colDescription});
            this.dgvPayrolls.DataSource = this.bsPayrolls;
            this.dgvPayrolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayrolls.Location = new System.Drawing.Point(3, 43);
            this.dgvPayrolls.Name = "dgvPayrolls";
            this.dgvPayrolls.ReadOnly = true;
            this.dgvPayrolls.RowHeadersVisible = false;
            this.dgvPayrolls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayrolls.Size = new System.Drawing.Size(794, 331);
            this.dgvPayrolls.TabIndex = 2;
            // 
            // bsPayrolls
            // 
            this.bsPayrolls.DataSource = typeof(KiPKadryIPlace.DataAccessLayer.ViewModels.PayrollViewModel);
            // 
            // pPayrolls
            // 
            this.pPayrolls.Controls.Add(this.btnRefresh);
            this.pPayrolls.Controls.Add(this.btnCompute);
            this.pPayrolls.Controls.Add(this.btnRemove);
            this.pPayrolls.Controls.Add(this.btnModify);
            this.pPayrolls.Controls.Add(this.btnCreate);
            this.pPayrolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPayrolls.Location = new System.Drawing.Point(3, 3);
            this.pPayrolls.Name = "pPayrolls";
            this.pPayrolls.Size = new System.Drawing.Size(794, 34);
            this.pPayrolls.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(375, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompute.Location = new System.Drawing.Point(285, 0);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(90, 34);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Wylicz";
            this.btnCompute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemove.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(195, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModify.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(90, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreate.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.add_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pBottomPayroll
            // 
            this.pBottomPayroll.Controls.Add(this.txtToPay);
            this.pBottomPayroll.Controls.Add(this.lblToPay);
            this.pBottomPayroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottomPayroll.Location = new System.Drawing.Point(0, 397);
            this.pBottomPayroll.Name = "pBottomPayroll";
            this.pBottomPayroll.Size = new System.Drawing.Size(800, 53);
            this.pBottomPayroll.TabIndex = 3;
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtToPay.Location = new System.Drawing.Point(120, 10);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.ReadOnly = true;
            this.txtToPay.Size = new System.Drawing.Size(107, 25);
            this.txtToPay.TabIndex = 4;
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToPay.Location = new System.Drawing.Point(22, 15);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(85, 19);
            this.lblToPay.TabIndex = 1;
            this.lblToPay.Text = "Do wypłaty";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Imię i Nazwisko";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 150;
            // 
            // colRateHour
            // 
            this.colRateHour.DataPropertyName = "RateHour";
            this.colRateHour.HeaderText = "Stawka godzinowa";
            this.colRateHour.Name = "colRateHour";
            this.colRateHour.ReadOnly = true;
            this.colRateHour.Width = 75;
            // 
            // hourDay
            // 
            this.hourDay.DataPropertyName = "HourDay";
            this.hourDay.HeaderText = "Liczba godzin w dniu";
            this.hourDay.Name = "hourDay";
            this.hourDay.ReadOnly = true;
            this.hourDay.Width = 75;
            // 
            // colDaysWorked
            // 
            this.colDaysWorked.DataPropertyName = "DaysWorked";
            this.colDaysWorked.HeaderText = "Liczba przepracowanych dni";
            this.colDaysWorked.Name = "colDaysWorked";
            this.colDaysWorked.ReadOnly = true;
            // 
            // colDatePay
            // 
            this.colDatePay.DataPropertyName = "DatePay";
            this.colDatePay.HeaderText = "Data wypłaty";
            this.colDatePay.Name = "colDatePay";
            this.colDatePay.ReadOnly = true;
            // 
            // colMonth
            // 
            this.colMonth.DataPropertyName = "Month";
            this.colMonth.HeaderText = "Za miesiąc";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Krótki opis";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPayrolls);
            this.Controls.Add(this.pBottomPayroll);
            this.Name = "PayrollForm";
            this.Text = "Lista płac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayrollForm_FormClosed);
            this.tlpPayrolls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayrolls)).EndInit();
            this.pPayrolls.ResumeLayout(false);
            this.pBottomPayroll.ResumeLayout(false);
            this.pBottomPayroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPayrolls;
        private System.Windows.Forms.Panel pPayrolls;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pBottomPayroll;
        private System.Windows.Forms.DataGridView dgvPayrolls;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsPayrolls;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaysWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}