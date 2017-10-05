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
    public partial class Form1 : Form
    {
        DatabaseController db = new DatabaseController();
        List<Person> persons = new List<Person>();
        BindingSource personData = new BindingSource();

        private void FillPersonListBox()
        {
            DataSet ds = new DataSet();
            Queries.GetPersons(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Person person = new Person(Int32.Parse(row["LNum"].ToString()), Int32.Parse(row["LRange"].ToString()), row["LName"].ToString());
                persons.Add(person);
            }
            listBox1.DataSource = personData;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Info";
        }
        
        private void FillAlternativeListBox()
        {
            DataSet ds = new DataSet();
            Queries.GetAlternative(ds);
            listBox2.DataSource = ds.Tables[0];
            listBox2.ValueMember = "ANum";
            listBox2.DisplayMember = "AName";
        }

        public Form1()
        {
            InitializeComponent();
            personData.DataSource = persons;
        }

        private void лПРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Participant newForm = new Participant();
            newForm.Show();
        }

        private void альтернативаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alternative newForm = new Alternative();
            newForm.Show();
        }

        private void критерииКачестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillPersonListBox();
            FillAlternativeListBox();
        }

        private void оценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mark newMark = new Mark();
            newMark.Show();
        }

        private void векторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector newVector = new Vector();
            newVector.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Participant newParticipant = new Participant();
            newParticipant.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Queries.DeletePersons(Int32.Parse(listBox1.SelectedValue.ToString()));
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Alternative form = new Alternative();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                Queries.DeleteAlternative(Int32.Parse(listBox2.SelectedValue.ToString()));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //Queries.GetPersons(ds);
            //listBox1.DataSource = ds.Tables[0];
            //listBox1.ValueMember = "LNum";
            //listBox1.DisplayMember = "LName";
            FillPersonListBox();
        }
    }
}
