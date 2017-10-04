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
    public partial class Vector : Form
    {
        DatabaseController db = new DatabaseController();
        public Vector()
        {
            InitializeComponent();
        }

        private void Vector_Load(object sender, EventArgs e)
        {
            DataSet mark = new DataSet();
            db.Perform(Queries.GetMark(), mark);
            comboBox1.DataSource = mark.Tables[0];
            comboBox1.ValueMember = "MNum";
            comboBox1.DisplayMember = "MName";
            DataSet altern = new DataSet();
            db.Perform(Queries.GetAlternative(), altern);
            comboBox2.DataSource = altern.Tables[0];
            comboBox2.ValueMember = "ANUM";
            comboBox2.DisplayMember = "AName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                string criteria = comboBox2.SelectedValue.ToString();
                Queries.AddVector(Int32.Parse(comboBox1.SelectedValue.ToString()), Int32.Parse(criteria));
            }
        }
    }
}
