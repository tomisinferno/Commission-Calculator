
/*
 * Author: Oluwatomi
 * Since: 2021/12/03
 * Description: Creating a commission calculating app (Practical 3)
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommissionCalculator.BusinessObjects;

namespace CommissionCalculator
{
    public partial class frmAgents : Form
    {
        public frmAgents()
        {
            InitializeComponent();
        }


        //After Calculate Button has been clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //If form is completely and correctly filled
            if (ValidateForm())
            {
                //if Agent is checked
                if (rbAgent.Checked)
                {
                    Agent agent = new Agent();

                    //Getting Values from form
                    agent.FName = txtFirstName.Text;
                    agent.LName = txtLastName.Text;
                    agent.Email = txtLastName.Text;
                    agent.SalesAmount = double.Parse(txtSalesAmount.Text);

                    //Putting output to the form
                    txtCommEarned.Text = "$" + agent.Calculate().ToString("0.00");
                    txtCommRate.Text = agent.CommRate.ToString();
                    txtBonusOrReduction.Text = agent.BonusOrReduction.ToString();
                }
                //If Junior Agent is checked
                if (rbJAgent.Checked)
                {
                    JuniorAgent jAgent = new JuniorAgent();

                    //Getting Values from form
                    jAgent.FName = txtFirstName.Text;
                    jAgent.LName = txtLastName.Text;
                    jAgent.Email = txtLastName.Text;
                    jAgent.SalesAmount = double.Parse(txtSalesAmount.Text);

                    //Putting output to the form
                    txtCommEarned.Text = "$" + jAgent.Calculate().ToString("0.00");
                    txtCommRate.Text = jAgent.CommRate.ToString();
                    txtBonusOrReduction.Text = jAgent.BonusOrReduction.ToString();
                }
                //If Senior Agent is Checked
                if (rbSAgent.Checked)
                {
                    SeniorAgent sAgent = new SeniorAgent();
                    //Getting Values from form
                    sAgent.FName = txtFirstName.Text;
                    sAgent.LName = txtLastName.Text;
                    sAgent.Email = txtLastName.Text;
                    sAgent.SalesAmount = double.Parse(txtSalesAmount.Text);

                    //Putting output to the form
                    txtCommEarned.Text = "$" + sAgent.Calculate().ToString("0.00");
                    txtCommRate.Text = sAgent.CommRate.ToString();
                    txtBonusOrReduction.Text = sAgent.BonusOrReduction.ToString();
                }
            }
        }

        //Validating input
        public bool ValidateForm()
        {
            string message = "";
            int originalErrorMessageLength = message.Length;
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                message += "First Name is Missing. ";
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                message += "Last Name is Missing. ";
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                message += "Email is Missing. ";
            }
            if (double.TryParse(txtSalesAmount.Text, out double result) == false || result < 0)
            {
                message += "Sales Amount is Missing or not a number. ";
            }
            if ((rbAgent.Checked == false && rbJAgent.Checked == false && rbSAgent.Checked == false))
            {
                message += "Check an Agent. ";
            }

            if (message.Length > originalErrorMessageLength)
            {
                MessageBox.Show(message, "Input Issues");
                return false;
            }
            else
            {
                return true;
            }
        }

        //After Cleared Button has been clicked
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //Clearing Controls
            txtSalesAmount.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtEmail.Clear();
            txtBonusOrReduction.Clear();
            txtCommEarned.Clear();
            txtCommRate.Clear();
            rbAgent.Checked = false;
            rbJAgent.Checked = false;
            rbSAgent.Checked = false;
        }
    }
}
