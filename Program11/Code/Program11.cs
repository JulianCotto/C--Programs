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
        public Form1()
        {
            InitializeComponent();
        }

        bool employeeFlag = false;
        bool categoryFlag = true;
        bool orderdetFlag = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            // TODO: This line of code loads data into the 'dataGridViewOrderDetails.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.dataGridViewOrderDetails.Order_Details);
            // TODO: This line of code loads data into the 'detailsViewCategories.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.detailsViewCategories.Categories);
            // TODO: This line of code loads data into the 'dataGridViewEmployees.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataGridViewEmployees.Employees);

        }

        public void changeColor(DataGridView dataGridView)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            dataGridView.ForeColor = colorDialog.Color;
        }

        private void dgv1_Click(object sender, EventArgs e)
        {
            if (employeeFlag)
            {
                hider1.Visible = false;
                dgv1.Text = "Hide DGV Employee";
                employeeFlag = false;

            }
            else
            {
                hider1.Visible = true;
                dgv1.Text = "Show DGV Employee";
                employeeFlag = true;
            }
        }

        private void dv1_Click(object sender, EventArgs e)
        {
            if (categoryFlag)
            {
                hider2.Visible = false;
                dv1.Text = "Hide DV Categories";
                categoryFlag = false;

            }
            else
            {
                hider2.Visible = true;
                dv1.Text = "Show DV Categories";
                categoryFlag = true;
            }
        }

        private void dgv2_Click(object sender, EventArgs e)
        {
            
            if (orderdetFlag)
            {
                hider3.Visible = false;
                dgv2.Text = "Hide DGV Order Details";
                orderdetFlag = false;

            }
            else
            {
                hider3.Visible = true;
                dgv2.Text = "Show DGV Order Details";
                orderdetFlag = true;
            }
        }

        private void chcolor1_Click(object sender, EventArgs e)
        {
            {
                changeColor(dataGridView1);
            }

        }

        private void chcolor2_Click(object sender, EventArgs e)
        {
            changeColor(dataGridView3);
        }

        private void chcolor3_Click(object sender, EventArgs e)
        {
            changeColor(dataGridView2);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for running Program11");
            MessageBox.Show("This project was a lot of fun."
                            + "Unfortunately I saved my .cs to the wrong place and completely destroyed my program."
                            + "I therefore had to do the program twice in a row. This is not so much a complaint."
                            + "Doing the pogram twice really helped me solidy my knowledge");
        }
    }
}
