using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace Controls_XRTable {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, PrintEventArgs e) {
            this.Detail.Controls.Add(CreateXRTable());
        }

        public XRTable CreateXRTable() {
            // Create an empty table and set its size.
            XRTable table = new XRTable();
            table.Size = new Size(300, 100);

            // Start table initialization.
            table.BeginInit();

            // Enable table borders to see its boundaries.
            table.BorderWidth = 2;
            table.Borders = DevExpress.XtraPrinting.BorderSide.All;

            // Create a table row.
            XRTableRow row = new XRTableRow();

            // Create two table cells.
            XRTableCell cell0 = new XRTableCell();
            XRTableCell cell1 = new XRTableCell();

            // Construct the table.
            row.Cells.Add(cell0);
            row.Cells.Add(cell1);
            table.Rows.Add(row);

            // Finish table initialization.
            table.EndInit();

            return table;
        }


    }
}
