using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Positions
{
    public partial class EditPositionForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public EditPositionForm(int positionId)
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            GetPositionFromDB(positionId);
        }

        #endregion
        #region Private Methods

        private void GetPositionFromDB(int positionId)
        {
            try
            {
                string query = "select dbo.Positions.ID, Name, MinSalary, MaxSalary from dbo.Positions where dbo.Positions.ID = @ID";
                DataTable userData = dbUtilitiesCon.GetData(query, new Dictionary<string, string> { { "@ID", Convert.ToString(positionId) } });

                if (userData?.Rows?.Count > 0)
                {
                    foreach (DataRow row in userData.Rows)
                    {
                        txtID.Text = row["ID"].ToString();
                        txtName.Text = row["Name"].ToString();
                        nudMinSalary.Value = Convert.ToInt32(row["MinSalary"]);
                        nudMaxSalary.Value = Convert.ToInt32(row["MaxSalary"]);
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string nameErrorMessage = eName.GetError(txtName);
            if (!string.IsNullOrEmpty(nameErrorMessage))
            {
                sbErrorMessage.Append(nameErrorMessage);
            }

            string minSalaryErrorMessage = eMinSalary.GetError(nudMinSalary);
            if (!string.IsNullOrEmpty(minSalaryErrorMessage))
            {
                sbErrorMessage.Append(minSalaryErrorMessage);
            }

            string maxSalaryErrorMessage = eMinSalary.GetError(nudMaxSalary);
            if (!string.IsNullOrEmpty(maxSalaryErrorMessage))
            {
                sbErrorMessage.Append(maxSalaryErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Modyfikowanie stanowiska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                // SQL

                var param = new Dictionary<string, string>();
                param.Add("@ID", txtID.Text);
                param.Add("@Name", txtName.Text);
                param.Add("@MinSalary", nudMinSalary.Value.ToString());
                param.Add("@MaxSalary", nudMaxSalary.Value.ToString());

                string query = "update dbo.Positions set Name = @Name, MinSalary = @MinSalary, MaxSalary = @MaxSalary where dbo.Positions.ID = @ID;";

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie zmodyfikowano dane stanowiska!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania zmodyfikowanych danych do bazy!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
