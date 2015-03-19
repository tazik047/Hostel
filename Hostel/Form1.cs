using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class MainForm : Form
    {
        private bool can_edit;

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDB();

            dataGridView1.AutoGenerateColumns = true;

        }

        private void updateDB()
        {
            roomsTableAdapter.Update(hostelDataSet);
            benefitsTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
        }

        private void loadDB()
        {
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            studentsTableAdapter.Fill(hostelDataSet.Students);
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateDB();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Rooms";
            bindingNavigator1.BindingSource = roomsBindingSource;
            dataGridView1.DataSource = roomsBindingSource;
            can_edit = false;
        }

        private void benefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Benefits";
            bindingNavigator1.BindingSource = benefitsBindingSource;
            dataGridView1.DataSource = benefitsBindingSource;
            can_edit = false;
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Students";
            bindingNavigator1.BindingSource = studentsBindingSource;
            dataGridView1.DataSource = studentsBindingSource;
            can_edit = true;
        }

        private void resettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDB();
            var rs = new RSForm();
            rs.ShowDialog();
            loadDB();

        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDB();
            var qe = new QueryEdit();
            qe.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!can_edit) return;
            updateDB();
            var edt = new EditForm();
            edt.ShowDialog();
            hostelDataSet.AcceptChanges();
            studentsTableAdapter.Fill(hostelDataSet.Students);

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!can_edit) return;
            updateDB();
            var st = new HostelDataSet.StudentsDataTable();
            studentsTableAdapter.FillBy(st,
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            var rows = st.Rows[0].ItemArray;
            var edt = new EditForm(Convert.ToInt32(rows[0]),
                rows[1].ToString(),
                rows[2].ToString(),
                rows[3].ToString(),
                rows[4].ToString(),
                rows[5].ToString(),
                Convert.ToInt32(rows[6]),
                Convert.ToInt32(rows[7]),
                Convert.ToDateTime(rows[8]));
            edt.ShowDialog();
            hostelDataSet.AcceptChanges();
            studentsTableAdapter.Fill(hostelDataSet.Students);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!can_edit) return;
            studentsTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            hostelDataSet.AcceptChanges();
            studentsTableAdapter.Fill(hostelDataSet.Students);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDB();
            (new ReportViewer()).ShowDialog();
        }


    }
}
