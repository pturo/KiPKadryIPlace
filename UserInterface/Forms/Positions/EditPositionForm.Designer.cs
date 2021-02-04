namespace KiPKadryIPlace.UserInterface.Forms.Positions
{
    partial class EditPositionForm
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
            this.nudMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.lblMaxSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudMinSalary = new System.Windows.Forms.NumericUpDown();
            this.lblMinSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eMinSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.eMaxSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMaxSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMaxSalary
            // 
            this.nudMaxSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMaxSalary.Location = new System.Drawing.Point(190, 210);
            this.nudMaxSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxSalary.Name = "nudMaxSalary";
            this.nudMaxSalary.Size = new System.Drawing.Size(165, 25);
            this.nudMaxSalary.TabIndex = 32;
            // 
            // lblMaxSalary
            // 
            this.lblMaxSalary.AutoSize = true;
            this.lblMaxSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaxSalary.Location = new System.Drawing.Point(30, 215);
            this.lblMaxSalary.Name = "lblMaxSalary";
            this.lblMaxSalary.Size = new System.Drawing.Size(149, 19);
            this.lblMaxSalary.TabIndex = 31;
            this.lblMaxSalary.Text = "Max. wynagrodzenie";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(190, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 25);
            this.txtName.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nazwa";
            // 
            // nudMinSalary
            // 
            this.nudMinSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMinSalary.Location = new System.Drawing.Point(190, 170);
            this.nudMinSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinSalary.Name = "nudMinSalary";
            this.nudMinSalary.Size = new System.Drawing.Size(165, 25);
            this.nudMinSalary.TabIndex = 30;
            // 
            // lblMinSalary
            // 
            this.lblMinSalary.AutoSize = true;
            this.lblMinSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMinSalary.Location = new System.Drawing.Point(30, 175);
            this.lblMinSalary.Name = "lblMinSalary";
            this.lblMinSalary.Size = new System.Drawing.Size(145, 19);
            this.lblMinSalary.TabIndex = 29;
            this.lblMinSalary.Text = "Min. wynagrodzenie";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPosition.Location = new System.Drawing.Point(25, 40);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(121, 30);
            this.lblPosition.TabIndex = 25;
            this.lblPosition.Text = "Stanowisko";
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // eMinSalary
            // 
            this.eMinSalary.ContainerControl = this;
            // 
            // eMaxSalary
            // 
            this.eMaxSalary.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(230, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(90, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::KiPKadryIPlace.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(290, 15);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 26;
            this.pbEmployee.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(30, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 19);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "ID stanowiska";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(190, 90);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(30, 25);
            this.txtID.TabIndex = 36;
            // 
            // EditPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudMaxSalary);
            this.Controls.Add(this.lblMaxSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.nudMinSalary);
            this.Controls.Add(this.lblMinSalary);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblPosition);
            this.Name = "EditPositionForm";
            this.Text = "Modyfikuj stanowisko";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMaxSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudMaxSalary;
        private System.Windows.Forms.Label lblMaxSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudMinSalary;
        private System.Windows.Forms.Label lblMinSalary;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ErrorProvider eMinSalary;
        private System.Windows.Forms.ErrorProvider eMaxSalary;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}