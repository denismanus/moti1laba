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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text!=null&&textBox1.Text!="")&&comboBox1.SelectedItem!=null&&comboBox2.SelectedItem!=null&&comboBox3!=null)
            {
                DatabaseController db = new DatabaseController();
                Queries.AddCriterion(textBox1.Text, textBox2.Text, 
                    textBox3.Text, comboBox3.SelectedItem.ToString(), 
                    comboBox2.SelectedItem.ToString(), textBox4.Text, comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Вы не заполнили некоторые обязательные поля");
            }
        }


    }
}
