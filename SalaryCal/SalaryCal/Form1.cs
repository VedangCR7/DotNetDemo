using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int  empId =int.Parse(txtEmpId.Text);
            string empName = txtEmpName.Text;   
            decimal basicSalary=decimal.Parse(txtBasicSalary.Text);

            decimal hra = basicSalary * 0.10m; 
            decimal da = basicSalary * 0.08m;  
            decimal ta = basicSalary * 0.05m;  
            decimal pf = basicSalary * 0.12m;  
            decimal pt = 200;                 
            decimal grossSalary = basicSalary + hra + da + ta - pf - pt;

            txtHRA.Text = hra.ToString("F1");
            txtDA.Text = da.ToString("F1");
            txtTA.Text = ta.ToString("F1");
            txtPF.Text = pf.ToString("F1");
            txtPT.Text = pt.ToString("F1");
            txtGrossSalary.Text = grossSalary.ToString("F1");

        }
    }
}
