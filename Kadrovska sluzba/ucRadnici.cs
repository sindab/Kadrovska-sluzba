using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using Kadrovska_sluzba.DB.Models;
using Kadrovska_sluzba.DB.Service;

namespace Kadrovska_sluzba
{
    public partial class ucRadnici : DevExpress.XtraEditors.XtraUserControl
    {
        IEnumerable<Radnik> dataSource;
        Radnik trenutni;
        public delegate void RadnikChangedHandler(object myObject, RadnikArgs myArgs);
        //public event RadnikChangedHandler OnPromjenaRadnika;
        public event RadnikChangedHandler IzmjenaRadnika;

        public ucRadnici()
        {
            InitializeComponent();
        }

        private void ucRadnici_Load(object sender, EventArgs e)
        {
            //dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
        }

        public Radnik TrenutniRadnik
        {
            get
            {
                trenutni = dataSource.First(x => x.ID == (int)gridView.GetFocusedRowCellValue("ID"));
                if (trenutni is null)
                {
                    trenutni = new Radnik();
                }
                return trenutni;
            }
        }

        public class RadnikArgs : EventArgs
        {
            private Radnik radnik;
            public RadnikArgs(Radnik radnik)
            {
                this.radnik = radnik;
            }
            // This is a straightforward implementation for declaring a public field
            public Radnik Radnik
            {
                get
                {
                    return radnik;
                }
            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<Radnik> GetDataSource()
        {
            RadnikService rs = new RadnikService();
            IEnumerable<Radnik> result = rs.GetAll();
            //BindingList<Customer> result = new BindingList<Customer>();
            //result.Add(new Customer()
            //{
            //    ID = 1,
            //    Name = "ACME",
            //    Address = "2525 E El Segundo Blvd",
            //    City = "El Segundo",
            //    State = "CA",
            //    ZipCode = "90245",
            //    Phone = "(310) 536-0611"
            //});
            //result.Add(new Customer()
            //{
            //    ID = 2,
            //    Name = "Electronics Depot",
            //    Address = "2455 Paces Ferry Road NW",
            //    City = "Atlanta",
            //    State = "GA",
            //    ZipCode = "30339",
            //    Phone = "(800) 595-3232"
            //});
            return result;
        }
        //public class Customer
        //{
        //    [Key, Display(AutoGenerateField = false)]
        //    public int ID { get; set; }
        //    [Required]
        //    public string Name { get; set; }
        //    public string Address { get; set; }
        //    public string City { get; set; }
        //    public string State { get; set; }
        //    [Display(Name = "Zip Code")]
        //    public string ZipCode { get; set; }
        //    public string Phone { get; set; }
        //}

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Customer c = dataSource.First(x => x.ID == (int)gridView.GetFocusedRowCellValue("ID"));
            RadnikArgs myArgs = new RadnikArgs(TrenutniRadnik);
            IzmjenaRadnika(this, myArgs);
            //raise event RadnikPromjenjen(radnik)
            //frmRadnikEdit fRE = new frmRadnikEdit();
            //fRE.ShowDialog();
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //RadnikArgs myArgs = new RadnikArgs(TrenutniRadnik);
            //OnPromjenaRadnika(this, myArgs);
        }

    }
}
