namespace KiPKadryIPlace.UserInterface.Forms.Positions
{
    partial class PositionsForm
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
            this.tlpPositions = new System.Windows.Forms.TableLayoutPanel();
            this.pPositions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPositions = new System.Windows.Forms.BindingSource(this.components);
            this.tlpPositions.SuspendLayout();
            this.pPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPositions
            // 
            this.tlpPositions.ColumnCount = 1;
            this.tlpPositions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPositions.Controls.Add(this.pPositions, 0, 0);
            this.tlpPositions.Controls.Add(this.dgvPositions, 0, 1);
            this.tlpPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPositions.Location = new System.Drawing.Point(0, 0);
            this.tlpPositions.Name = "tlpPositions";
            this.tlpPositions.RowCount = 2;
            this.tlpPositions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPositions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPositions.Size = new System.Drawing.Size(800, 450);
            this.tlpPositions.TabIndex = 1;
            // 
            // pPositions
            // 
            this.pPositions.Controls.Add(this.btnRefresh);
            this.pPositions.Controls.Add(this.btnRemove);
            this.pPositions.Controls.Add(this.btnModify);
            this.pPositions.Controls.Add(this.btnCreate);
            this.pPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPositions.Location = new System.Drawing.Point(3, 3);
            this.pPositions.Name = "pPositions";
            this.pPositions.Size = new System.Drawing.Size(794, 34);
            this.pPositions.TabIndex = 0;
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
            // dgvPositions
            // 
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.AllowUserToDeleteRows = false;
            this.dgvPositions.AutoGenerateColumns = false;
            this.dgvPositions.BackgroundColor = System.Drawing.Color.White;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMinSalary,
            this.colMaxSalary});
            this.dgvPositions.DataSource = this.bsPositions;
            this.dgvPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPositions.Location = new System.Drawing.Point(3, 43);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositions.Size = new System.Drawing.Size(794, 404);
            this.dgvPositions.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colMinSalary
            // 
            this.colMinSalary.DataPropertyName = "MinSalary";
            this.colMinSalary.HeaderText = "Minimalne wynagrodzenie";
            this.colMinSalary.Name = "colMinSalary";
            this.colMinSalary.ReadOnly = true;
            this.colMinSalary.Width = 300;
            // 
            // colMaxSalary
            // 
            this.colMaxSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaxSalary.DataPropertyName = "MaxSalary";
            this.colMaxSalary.HeaderText = "Maksymalne wynagrodzenie";
            this.colMaxSalary.Name = "colMaxSalary";
            this.colMaxSalary.ReadOnly = true;
            // 
            // bsPositions
            // 
            this.bsPositions.DataSource = typeof(KiPKadryIPlace.DataAccessLayer.ViewModels.PositionViewModel);
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPositions);
            this.Name = "PositionsForm";
            this.Text = "Stanowiska";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PositionsForm_FormClosed);
            this.tlpPositions.ResumeLayout(false);
            this.pPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPositions;
        private System.Windows.Forms.Panel pPositions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxSalary;
        private System.Windows.Forms.BindingSource bsPositions;
    }
}