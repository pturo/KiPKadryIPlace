using KiPKadryIPlace.UserInterface.Forms.Contracts;
using KiPKadryIPlace.UserInterface.Forms.Departaments;
using KiPKadryIPlace.UserInterface.Forms.Email;
using KiPKadryIPlace.UserInterface.Forms.Employees;
using KiPKadryIPlace.UserInterface.Forms.OrganizationalStructure;
using KiPKadryIPlace.UserInterface.Forms.Payroll;
using KiPKadryIPlace.UserInterface.Forms.Positions;
using KiPKadryIPlace.UserInterface.Forms.Salaries;
using KiPKadryIPlace.UserInterface.Forms.Users;
using KiPKadryIPlace.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private TabPage _tpEmployees;
        private TabPage _tpContracts;
        private TabPage _tpOrganizationalStructure;
        private TabPage _tpSalary;
        private TabPage _tpDepartaments;
        private TabPage _tpPositions;
        private TabPage _tpPayroll;
        private TabPage _tpUsers;

        #endregion
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion
        #region Private Methods

        private void ShowFormInTabPage(TabPage tpTab, Form form)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tpTab.Controls.Add(form);
            tcTabs.SelectedTab = tpTab;
        }

        #endregion
        #region Events

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.IsNull)
            {
                _tpEmployees = new TabPage();
                ShowFormInTabPage(_tpEmployees, EmployeesForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpEmployees;
            }
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            if (ContractsForm.IsNull)
            {
                _tpContracts = new TabPage();
                ShowFormInTabPage(_tpContracts, ContractsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpContracts;
            }
        }

        private void btnOrganizationalStructure_Click(object sender, EventArgs e)
        {
            if (OrganizationalStructureForm.IsNull)
            {
                _tpOrganizationalStructure = new TabPage();
                ShowFormInTabPage(_tpOrganizationalStructure, OrganizationalStructureForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpOrganizationalStructure;
            }
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            if (SalariesForm.IsNull)
            {
                _tpSalary = new TabPage();
                ShowFormInTabPage(_tpSalary, SalariesForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpSalary;
            }
        }

        private void btnDepartaments_Click(object sender, EventArgs e)
        {
            if (DepartamentsForm.IsNull)
            {
                _tpDepartaments = new TabPage();
                ShowFormInTabPage(_tpDepartaments, DepartamentsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpDepartaments;
            }
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            if (PositionsForm.IsNull)
            {
                _tpPositions = new TabPage();
                ShowFormInTabPage(_tpPositions, PositionsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpPositions;
            }
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            if (PayrollForm.IsNull)
            {
                _tpPayroll = new TabPage();
                ShowFormInTabPage(_tpPayroll, PayrollForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpPayroll;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (UsersForm.IsNull)
            {
                _tpUsers = new TabPage();
                ShowFormInTabPage(_tpUsers, UsersForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpUsers;
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            EmailForm frm = new EmailForm();
            frm.ShowDialog();
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion
    }
}
