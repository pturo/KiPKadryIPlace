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

namespace KiPKadryIPlace.UserInterface.Forms.OrganizationalStructure
{
    public partial class OrganizationalStructureForm : BaseForm
    {
        #region Fields

        private static OrganizationalStructureForm _instance = null;
        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Properties

        public static OrganizationalStructureForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrganizationalStructureForm();
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

        public OrganizationalStructureForm()
        {
            InitializeComponent();
            GetOrganizationalStructureFromDB();
        }

        #endregion
        #region Private Methods

        private void GetOrganizationalStructureFromDB()
        {
            tvOrganizationalStructure.Nodes.Clear();

            dbUtilitiesCon = new DBUtilities();
            DataTable dt = dbUtilitiesCon.GetData("select Name, d.Value from dbo.Departaments inner join dbo.ParentDepartaments d on DepartamentId = d.ID;");

            if(dt?.Rows?.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode(row["Name"].ToString());
                    node.Nodes.Add(row["Value"].ToString());

                    tvOrganizationalStructure.Nodes.Add(node);
                }
            }
        }

        #endregion
        #region Events

        private void OrganizationalStructureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion
    }
}
