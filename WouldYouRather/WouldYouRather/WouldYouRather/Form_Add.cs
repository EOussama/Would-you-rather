using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WouldYouRather
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_C1_TextChanged(object sender, EventArgs e)
        {
            button_Confirm.Enabled = textBox_C1.Text.Trim().Length >= 3 && textBox_C2.Text.Trim().Length > 3 ? true : false;
        }

        private void textBox_C2_TextChanged(object sender, EventArgs e)
        {
            button_Confirm.Enabled = textBox_C1.Text.Trim().Length >= 3 && textBox_C2.Text.Trim().Length > 3 ? true : false;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox_C1.Text.Trim().Length > 100 || textBox_C2.Text.Trim().Length > 100)
                MessageBox.Show("You can't input more than 100 characters!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Connection.sendQuery("INSERT INTO Questions(qC_1, qC_2) VALUES('" + textBox_C1.Text.Trim() + "', '" + textBox_C2.Text.Trim() + "')");
                Form_Base.qList.Clear();
                SqlDataReader dReader = Connection.getReader("SELECT * FROM Questions;");

                while (dReader.Read())
                    Form_Base.qList.Add(new Question((int)dReader.GetValue(0), dReader.GetString(1), dReader.GetString(2), (int)dReader.GetValue(3), (int)dReader.GetValue(4)));

                dReader.Close();
                Connection.conClose();

                textBox_C1.Clear();
                textBox_C2.Clear();

                MessageBox.Show("Entity added to the database successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
