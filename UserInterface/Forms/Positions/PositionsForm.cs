using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.DataAccessLayer.ViewModels;
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
    public partial class PositionsForm : BaseForm
    {
        #region Fields

        private static PositionsForm _instance = null;
        private int positionId;
        private DBUtilities dBUtilitiesCon;
        private BindingList<PositionViewModel> sqlPos = new BindingList<PositionViewModel>();

        #endregion
        #region Properties

        public static PositionsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PositionsForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion
        #region Constructor

        public PositionsForm()
        {
            InitializeComponent();
            GetPositionsFromDB();
        }

        #endregion
        #region Private Methods

        private void GetPositionsFromDB()
        {
            dBUtilitiesCon = new DBUtilities();
            DataTable dt = dBUtilitiesCon.GetData("select dbo.Positions.ID, Name, MinSalary, MaxSalary from dbo.Positions order by dbo.Positions.ID;");

            if(dt?.Rows?.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    sqlPos.Add(new PositionViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        MinSalary = row["MinSalary"].ToString(),
                        MaxSalary = row["MaxSalary"].ToString()
                    });

                    var source = new BindingSource(sqlPos, null);
                    dgvPositions.DataSource = source;
                }
            }
        }

        private void DeletePositionFromDB(int positionId)
        {
            try
            {
                string query = "delete from dbo.Positions where dbo.Positions.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(positionId));
                int result = dBUtilitiesCon.ExecuteQuery(query, param);
                if (result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto stanowisko z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania stanowiska z bazy!");
            }
        }

        private void RefreshData()
        {
            dgvPositions.Rows.Clear();
            GetPositionsFromDB();
        }

        #endregion
        #region Events

        private void PositionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddPositionForm frm = new AddPositionForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            positionId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["colId"].Value);

            EditPositionForm frm = new EditPositionForm(positionId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            positionId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć stanowisko?", "Usuwanie stanowiska",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                DeletePositionFromDB(positionId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion
    }
}
