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
    public partial class Form_Base : Form
    {
        public static List<Question> qList = new List<Question>();
        int randID = 0;
        double cur1 = 0.0, cur2 = 0.0;


        public Form_Base()
        {
            InitializeComponent();

            if(!Connection.Connect("Data source = .\\sqlexpress; initial catalog = db_wyr; integrated security = true;"))
            {
                MessageBox.Show("Couldn't connect to the database!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
            else
                loadList();

            toolTip.SetToolTip(this.button_Next, "Move to a random question");
            toolTip.SetToolTip(this.button_Add, "Add a new question");
            toolTip.SetToolTip(this.button_Minimize, "Minimize this window");
            toolTip.SetToolTip(this.button_Close, "Close this application");
        }

        private void button_C1_Click(object sender, EventArgs e)
        {
            Confirm(button_C1);
        }

        private void button_C2_Click(object sender, EventArgs e)
        {
            Confirm(button_C2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close this application?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uiRefresh();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Add Form = new Form_Add();
            Form.ShowDialog();
        }

        public void loadList()
        {
            SqlDataReader dReader = Connection.getReader("SELECT * FROM Questions;");

            while (dReader.Read())
                qList.Add(new Question((int)dReader.GetValue(0), dReader.GetString(1), dReader.GetString(2), (int)dReader.GetValue(3), (int)dReader.GetValue(4)));

            dReader.Close();
            Connection.conClose();

            uiRefresh();
        }

        public void uiRefresh()
        {
            if (qList.Count > 0)
            {
                Random rand = new Random();
                randID = rand.Next(0, qList.Count);

                button_C1.Text = qList[randID].qC_1;
                button_C2.Text = qList[randID].qC_2;

                if (button_C1.Enabled == false)
                    button_C1.Enabled = true;
                if (button_C2.Enabled == false)
                    button_C2.Enabled = true;

                label_qA1.Visible = false;
                label_qA2.Visible = false;
                label_times1.Visible = false;
                label_times2.Visible = false;
            }
        }

        public void Confirm(Button btn)
        {
            string ad1 = "", ad2 = "";

            if (btn == button_C1)
            {
                qList[randID].qA_1++;
                ad1 = "Agree";
                ad2 = "Disagree";
                Connection.sendQuery("UPDATE Questions SET qA_1 = qA_1 + 1 WHERE qID = " + qList[randID].qID);
            }

            else
            {
                qList[randID].qA_2++;
                ad2 = "Agree";
                ad1 = "Disagree";
                Connection.sendQuery("UPDATE Questions SET qA_2 = qA_2 + 1 WHERE qID = " + qList[randID].qID);
            }

            button_C1.Text = "";
            button_C2.Text = "";
            button_C1.Enabled = false;
            button_C2.Enabled = false;

            label_qA1.Visible = true;
            label_qA2.Visible = true;
            label_times1.Visible = true;
            label_times2.Visible = true;

            cur1 = 0.0;
            cur2 = 0.0;
            label_qA1.Text = "0.0%";
            label_qA2.Text = "0.0%";
            timer_Animation.Start();
            label_times1.Text = qList[randID].qA_1.ToString() + " " + ad1;
            label_times2.Text = qList[randID].qA_2.ToString() + " " + ad2;
        }

        private void timer_Animation_Tick(object sender, EventArgs e)
        {
            double total;
            double per1 = 0.0, per2 = 0.0;

            total = qList[randID].qA_2 + qList[randID].qA_1;
            per1 = qList[randID].qA_1 / total;
            per2 = qList[randID].qA_2 / total;

            if (cur1 >= per1 && cur2 >= per2)
            {
                timer_Animation.Stop();
                label_qA1.Text = per1.ToString("0.0%");
                label_qA2.Text = per2.ToString("0.0%");
            }

            else
            {
                cur1 += 0.101;
                cur2 += 0.101;

                if (cur1 < per1)
                    label_qA1.Text = cur1.ToString("0.0%");

                if (cur2 < per2)
                    label_qA2.Text = cur2.ToString("0.0%");
            }
        }
    }
}
