using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kadrovska_sluzba
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            SetujRadnika();
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetujRadnika();
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetujRadnika();
            navBarControl.ActiveGroup= navBarControl.Groups[0];
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetujRadnika();
            navBarControl.ActiveGroup = navBarControl.Groups[1];
        }

        //private void ucRadnici1_OnPromjenaRadnika(object myObject, ucRadnici.RadnikArgs myArgs)
        //{
        //    ucRadnik1.Radnik = ucRadnici1.TrenutniRadnik;
        //    //navBarControl.ActiveGroup = navBarControl.Groups[1];
        //}
        private void ucRadnici1_IzmjenaRadnika(object myObject, ucRadnici.RadnikArgs myArgs)
        {
            SetujRadnika();
            navBarControl.ActiveGroup = navBarControl.Groups[1];
        }
        private void OtvoriJednogRadnika()
        {
            ucRadnik1.Radnik = ucRadnici1.TrenutniRadnik;
        }
    }
}