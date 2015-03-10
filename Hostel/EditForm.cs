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
    public partial class EditForm : Form
    {
        private readonly int id;

        private readonly bool edit;

        public EditForm()
        {
            InitializeComponent();
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            edit = false;
        }

        public EditForm(int id, String name, string gender, string address, string group, string passport, int benefitCode, int roomNumber, DateTime colonizeDate)
            : this()
        {
            edit = true;
            this.id = id;
            textBox_Name.Text = name;
            dateTimePicker_ColonizeDate.Value = colonizeDate;
            switch (gender)
            {
                case "мужской":
                    comboBox_Gender.SelectedIndex = 1;
                    break;
                case "женский":
                    comboBox_Gender.SelectedIndex = 0;
                    break;
                default:
                    comboBox_Gender.SelectedIndex = 0;
                    break;
            }
            textBox_Address.Text = address;
            textBox_Group.Text = group;
            comboBox_Benefit.SelectedValue = benefitCode;
            textBox_Passport.Text = passport;
            comboBox_Room.SelectedValue = roomNumber;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox_Gender.SelectedIndex == 1)
            {
                gender = "мужской";
            }
            else if (comboBox_Gender.SelectedIndex == 0)
            {
                gender = "женский";
            }
            if (edit)
            {
                studentsTableAdapter.UpdateQuery(textBox_Name.Text, gender, textBox_Address.Text,
                    textBox_Group.Text, textBox_Passport.Text, Convert.ToInt32(comboBox_Benefit.SelectedValue),
                    Convert.ToInt32(comboBox_Room.SelectedValue), dateTimePicker_ColonizeDate.Value.ToString(), id);
            }
            else
            {
                studentsTableAdapter.InsertQuery(textBox_Name.Text, gender, textBox_Address.Text,
                    textBox_Group.Text, textBox_Passport.Text, Convert.ToInt32(comboBox_Benefit.SelectedValue),
                    Convert.ToInt32(comboBox_Room.SelectedValue), dateTimePicker_ColonizeDate.Value);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
