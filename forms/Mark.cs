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
    public partial class Mark : Form
    {
        DatabaseController db = new DatabaseController();

        public Mark()
        {
            InitializeComponent();
        }

        private void Mark_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            db.Perform(Queries.GetCriteriaNameAndNum(), ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "CNum";
            comboBox1.DisplayMember = "CName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && comboBox1.SelectedItem!=null && textBox1.Text != "")
            {
                string criteria = comboBox1.SelectedValue.ToString();
                Queries.AddMark(textBox1.Text, Int32.Parse(criteria));
            }
        }
    }
}
