namespace KiPKadryIPlace.UserInterface.Forms.Contracts
{
    partial class ContractsForm
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
            this.tlpContracts = new System.Windows.Forms.TableLayoutPanel();
            this.pContracts = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerminationWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContracts = new System.Windows.Forms.BindingSource(this.components);
            this.tlpContracts.SuspendLayout();
            this.pContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContracts
            // 
            this.tlpContracts.ColumnCount = 1;
            this.tlpContracts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContracts.Controls.Add(this.pContracts, 0, 0);
            this.tlpContracts.Controls.Add(this.dgvContracts, 0, 1);
            this.tlpContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContracts.Location = new System.Drawing.Point(0, 0);
            this.tlpContracts.Name = "tlpContracts";
            this.tlpContracts.RowCount = 2;
            this.tlpContracts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContracts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContracts.Size = new System.Drawing.Size(800, 450);
            this.tlpContracts.TabIndex = 1;
            // 
            // pContracts
            // 
            this.pContracts.Controls.Add(this.btnRefresh);
            this.pContracts.Controls.Add(this.btnRemove);
            this.pContracts.Controls.Add(this.btnShow);
            this.pContracts.Controls.Add(this.btnCreate);
            this.pContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContracts.Location = new System.Drawing.Point(3, 3);
            this.pContracts.Name = "pContracts";
            this.pContracts.Size = new System.Drawing.Size(794, 34);
            this.pContracts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(285, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShow.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.edit_24;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(90, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Podgląd";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
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
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AutoGenerateColumns = false;
            this.dgvContracts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colCode,
            this.colTypeContract,
            this.colDateFrom,
            this.colDateTo,
            this.colConclusionDate,
            this.colTerminationWay});
            this.dgvContracts.DataSource = this.bsContracts;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.Location = new System.Drawing.Point(3, 43);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.RowHeadersVisible = false;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(794, 404);
            this.dgvContracts.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Nazwisko";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Imię";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Kod";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 50;
            // 
            // colTypeContract
            // 
            this.colTypeContract.DataPropertyName = "TypeContract";
            this.colTypeContract.HeaderText = "Rodzaj umowy";
            this.colTypeContract.Name = "colTypeContract";
            this.colTypeContract.ReadOnly = true;
            this.colTypeContract.Width = 125;
            // 
            // colDateFrom
            // 
            this.colDateFrom.DataPropertyName = "DateFrom";
            this.colDateFrom.HeaderText = "Data od";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ReadOnly = true;
            this.colDateFrom.Width = 75;
            // 
            // colDateTo
            // 
            this.colDateTo.DataPropertyName = "DateTo";
            this.colDateTo.HeaderText = "Data do";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ReadOnly = true;
            this.colDateTo.Width = 75;
            // 
            // colConclusionDate
            // 
            this.colConclusionDate.DataPropertyName = "ConclusionDate";
            this.colConclusionDate.HeaderText = "Data zawarcia";
            this.colConclusionDate.Name = "colConclusionDate";
            this.colConclusionDate.ReadOnly = true;
            // 
            // colTerminationWay
            // 
            this.colTerminationWay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTerminationWay.DataPropertyName = "TerminationWay";
            this.colTerminationWay.HeaderText = "Sposób rozwiązania";
            this.colTerminationWay.Name = "colTerminationWay";
            this.colTerminationWay.ReadOnly = true;
            // 
            // bsContracts
            // 
            this.bsContracts.DataSource = typeof(KiPKadryIPlace.DataAccessLayer.ViewModels.ContractViewModel);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpContracts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContractsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Umowy";
            this.tlpContracts.ResumeLayout(false);
            this.pContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpContracts;
        private System.Windows.Forms.Panel pContracts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.BindingSource bsContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerminationWay;
    }
}