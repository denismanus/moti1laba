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
        DataBaseController db = new DataBaseController();
        List<Person> persons = new List<Person>();

        private void FillPersonListBox()
        {
            DataSet ds = new DataSet();
            db.Perform(Queries.GetPersons(), ds);
            listBox1.DataSource = ds;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void лПРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Participant newForm = new Participant();
            newForm.Show();
        }

        private void альтернативаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
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
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }

    
    }
}
