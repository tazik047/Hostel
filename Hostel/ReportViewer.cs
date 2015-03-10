using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "HostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.StudentsTableAdapter.Fill(this.HostelDataSet.Students);

            this.reportViewer1.RefreshReport();
        }
    }
}
