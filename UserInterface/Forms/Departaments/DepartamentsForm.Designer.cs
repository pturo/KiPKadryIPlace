namespace KiPKadryIPlace.UserInterface.Forms.Departaments
{
    partial class DepartamentsForm
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
            this.tlpDepartaments = new System.Windows.Forms.TableLayoutPanel();
            this.pDepartaments = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvDepartaments = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDepartaments = new System.Windows.Forms.BindingSource(this.components);
            this.tlpDepartaments.SuspendLayout();
            this.pDepartaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartaments)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDepartaments
            // 
            this.tlpDepartaments.ColumnCount = 1;
            this.tlpDepartaments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDepartaments.Controls.Add(this.pDepartaments, 0, 0);
            this.tlpDepartaments.Controls.Add(this.dgvDepartaments, 0, 1);
            this.tlpDepartaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDepartaments.Location = new System.Drawing.Point(0, 0);
            this.tlpDepartaments.Name = "tlpDepartaments";
            this.tlpDepartaments.RowCount = 2;
            this.tlpDepartaments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDepartaments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDepartaments.Size = new System.Drawing.Size(800, 450);
            this.tlpDepartaments.TabIndex = 2;
            // 
            // pDepartaments
            // 
            this.pDepartaments.Controls.Add(this.btnRefresh);
            this.pDepartaments.Controls.Add(this.btnRemove);
            this.pDepartaments.Controls.Add(this.btnModify);
            this.pDepartaments.Controls.Add(this.btnCreate);
            this.pDepartaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDepartaments.Location = new System.Drawing.Point(3, 3);
            this.pDepartaments.Name = "pDepartaments";
            this.pDepartaments.Size = new System.Drawing.Size(794, 34);
            this.pDepartaments.TabIndex = 0;
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
            // dgvDepartaments
            // 
            this.dgvDepartaments.AllowUserToAddRows = false;
            this.dgvDepartaments.AllowUserToDeleteRows = false;
            this.dgvDepartaments.AutoGenerateColumns = false;
            this.dgvDepartaments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colManager,
            this.colLocation,
            this.colParentDepartament});
            this.dgvDepartaments.DataSource = this.bsDepartaments;
            this.dgvDepartaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartaments.Location = new System.Drawing.Point(3, 43);
            this.dgvDepartaments.Name = "dgvDepartaments";
            this.dgvDepartaments.ReadOnly = true;
            this.dgvDepartaments.RowHeadersVisible = false;
            this.dgvDepartaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartaments.Size = new System.Drawing.Size(794, 404);
            this.dgvDepartaments.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colManager
            // 
            this.colManager.DataPropertyName = "Manager";
            this.colManager.HeaderText = "Kierownik działu";
            this.colManager.Name = "colManager";
            this.colManager.ReadOnly = true;
            this.colManager.Width = 200;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "Lokalizacja";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 200;
            // 
            // colParentDepartament
            // 
            this.colParentDepartament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParentDepartament.DataPropertyName = "ParentDepartament";
            this.colParentDepartament.HeaderText = "Dział nadrzędny";
            this.colParentDepartament.Name = "colParentDepartament";
            this.colParentDepartament.ReadOnly = true;
            // 
            // bsDepartaments
            // 
            this.bsDepartaments.DataSource = typeof(KiPKadryIPlace.DataAccessLayer.ViewModels.DepartamentViewModel);
            // 
            // DepartamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpDepartaments);
            this.Name = "DepartamentsForm";
            this.Text = "Działy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartamentsForm_FormClosed);
            this.tlpDepartaments.ResumeLayout(false);
            this.pDepartaments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartaments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDepartaments;
        private System.Windows.Forms.Panel pDepartaments;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvDepartaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentDepartament;
        private System.Windows.Forms.BindingSource bsDepartaments;
    }
}