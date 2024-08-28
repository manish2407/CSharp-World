using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LinqToSQL
{
    
    public partial class Form2 : Form
    {
        CompanyDBDataContext db1;
        List<Employee> emps;
        int rno = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db1 = new CompanyDBDataContext();
            emps = db1.Employees.ToList();
            showData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void showData()
        {
            textBox1.Text =   emps[rno].EId.ToString();
            textBox2.Text = emps[rno].EName;
            textBox3.Text = emps[rno].Job;
            textBox4.Text = emps[rno].Salary.ToString();
            textBox5.Text = emps[rno].DName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rno > 0) {
                rno -= 1;
                showData();
            }

            else
            {
                MessageBox.Show("First record of the table");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rno < emps.Count - 1)
            {
                rno += 1;
                showData();
            }
            else
            {
                MessageBox.Show("Last record of the table");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
