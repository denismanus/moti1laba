using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Participant : Form
    {
        private readonly Form1 form1;

        public Participant(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }
        public Participant(Form1 form1, int num)
        {
            DataSet ds = new DataSet();
            this.form1 = form1;
            Queries.GetPerson(ds, num);
            Person editPerson = new Person(
                Int32.Parse(ds.Tables[0].Rows[0]["LNum"].ToString()), 
                Int32.Parse(ds.Tables[0].Rows[0]["LRange"].ToString(),  System.Globalization.NumberStylesds.Tables[0].Rows[0]["LName"].ToString()));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox1.Text!=null)
            {
                string rang = "";
                if(comboBox1.SelectedItem!=null)
                {
                    rang = comboBox1.SelectedItem.ToString();
                }
                Queries.AddPerson(textBox1.Text, rang);
                form1.FillPersonListBox();
    }
        }

        private void Participant_Load(object sender, EventArgs e)
        {

        }
    }
}
