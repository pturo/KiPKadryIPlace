namespace KiPKadryIPlace.UserInterface.Forms.OrganizationalStructure
{
    partial class OrganizationalStructureForm
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
            this.dgvOrganizationalStructure = new System.Windows.Forms.DataGridView();
            this.tvOrganizationalStructure = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizationalStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizationalStructure
            // 
            this.dgvOrganizationalStructure.AllowUserToAddRows = false;
            this.dgvOrganizationalStructure.AllowUserToDeleteRows = false;
            this.dgvOrganizationalStructure.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrganizationalStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrganizationalStructure.Location = new System.Drawing.Point(0, 0);
            this.dgvOrganizationalStructure.Name = "dgvOrganizationalStructure";
            this.dgvOrganizationalStructure.ReadOnly = true;
            this.dgvOrganizationalStructure.Size = new System.Drawing.Size(800, 450);
            this.dgvOrganizationalStructure.TabIndex = 0;
            // 
            // tvOrganizationalStructure
            // 
            this.tvOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOrganizationalStructure.Location = new System.Drawing.Point(0, 0);
            this.tvOrganizationalStructure.Name = "tvOrganizationalStructure";
            this.tvOrganizationalStructure.Size = new System.Drawing.Size(800, 450);
            this.tvOrganizationalStructure.TabIndex = 1;
            // 
            // OrganizationalStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvOrganizationalStructure);
            this.Controls.Add(this.dgvOrganizationalStructure);
            this.Name = "OrganizationalStructureForm";
            this.Text = "Struktura organizacyjna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrganizationalStructureForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizationalStructure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizationalStructure;
        private System.Windows.Forms.TreeView tvOrganizationalStructure;
    }
}