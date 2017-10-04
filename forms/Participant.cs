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
        public Participant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox1.Text!=null)
            {
                DatabaseController db = new DatabaseController();
                string rang = "";
                if(comboBox1.SelectedItem!=null)
                {
                    rang = comboBox1.SelectedItem.ToString();
                }
                db.Perform(Queries.AddPerson(textBox1.Text, rang));
            }
        }

    }
}
