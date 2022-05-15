using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program10.BusinessEntities;

namespace Program10
{
    public partial class FormMain : Form
    {
        private Account[] Arr_Acc;
        private int currentacntindx = 0;
        private float Free_Minutes;
       
        
        public FormMain()
        {
            InitializeComponent();
        }

      
        

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Arr_Acc = new Account[Int32.Parse(AccountsTextBox.Text)];
            AccountDetailsSplitBox.Visible = true;
            SubmitButton.Visible = true;
            InputButton.Visible = false;
            label2.Visible = false;
            AccountsTextBox.Visible = false;
            CurrentAccountLabel.Visible = true;
            CurrentAccountLabel.Text = $"Now Entering Data for Account {currentacntindx + 1}";
       







        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
           

            Arr_Acc[currentacntindx] = new Account();
            Arr_Acc[currentacntindx].ph.PhoneNo = PhoneNoTextBox.Text;
            Arr_Acc[currentacntindx].ph.Manufacturer = ManufacturerTextBox.Text;
            Arr_Acc[currentacntindx].ph.Model = ModelTextBox.Text;
            Arr_Acc[currentacntindx].ph.Operating_System = OSTextBox.Text;
            Arr_Acc[currentacntindx].ph.Diagonal_Screen_Size = ScreenSizeTextBox.Text;
            Arr_Acc[currentacntindx].Customer_Name = CXNameTextBox.Text;
            Arr_Acc[currentacntindx].Address = CXAddressTextBox.Text;
            Arr_Acc[currentacntindx].Credit_CN = CXCCNTextBox.Text;
            Arr_Acc[currentacntindx].Balance_Owed = float.Parse(BalanceOwedTextBox.Text);
            Arr_Acc[currentacntindx].Minutes_Used = float.Parse(MinutesUsedTextBox.Text);
            Arr_Acc[currentacntindx].Cost_Per_Minute = float.Parse(CPMTextBox.Text);

            



            currentacntindx++;
            CurrentAccountLabel.Text = $"Now Entering Data for Account {currentacntindx + 1}";

            if (currentacntindx >= Arr_Acc.Length)
            { 
                CalculateCharges.Visible = true;
                YesButton.Visible = true;
                NoButton.Visible = true;
              } 
                foreach (var control in AccountDetailsSplitBox.Controls[1].Controls)
            {
                if (control.GetType() == typeof(RichTextBox))
                {
                    ((RichTextBox)control).Clear();
                }
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            AccountIncrementer.Visible = true;
            WhichAccount.Visible = true;
            Enter.Visible = true;
            

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Visible = true;
            OutputLabel.Text = Stringify();
            WithoutAdjustments.Visible = true;
            btn.Visible = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string Stringify()
        {
            
            string retString = "";

            retString += $"Phone Number: {Arr_Acc[0].ph.PhoneNo} \n";
            retString += $"Phone Manufacturer: {Arr_Acc[0].ph.Manufacturer} \n";
            retString += $"Phone Model: {Arr_Acc[0].ph.Model} \n";
            retString += $"Phone OS: {Arr_Acc[0].ph.Operating_System} \n";
            retString += $"Diagonal Screen Size: {Arr_Acc[0].ph.Diagonal_Screen_Size} \n";
            retString += $"Customer Name: {Arr_Acc[0].Customer_Name} \n";
            retString += $"Address: {Arr_Acc[0].Customer_Name} \n";
            retString += $"Credit Card Number: {Arr_Acc[0].Credit_CN} \n";
            retString += $"Balance Owed: {Arr_Acc[0].Balance_Owed} \n";
            retString += $"Minutes Used: {Arr_Acc[0].Minutes_Used} \n";
            retString += $"Cost Per Minute: {Arr_Acc[0].Cost_Per_Minute} \n";

            // Repeat for all required variables to be printed
            // If you need to print it different for Yes / No, you can pass in a boolean as a parameter and use it to adjust the print output.

            return retString;
        }
        public string Stringify1()
        {

            float Free_Minutes = float.Parse(MinutesAdjuster.Text);
            int userVal = int.Parse(AccountIncrementer.Text);
            string retString = "";

            retString += $"Phone Number: {Arr_Acc[userVal].ph.PhoneNo} \n";
            retString += $"Phone Manufacturer: {Arr_Acc[userVal].ph.Manufacturer} \n";
            retString += $"Phone Model: {Arr_Acc[userVal].ph.Model} \n";
            retString += $"Phone OS: {Arr_Acc[userVal].ph.Operating_System} \n";
            retString += $"Diagonal Screen Size: {Arr_Acc[userVal].ph.Diagonal_Screen_Size} \n";
            retString += $"Customer Name: {Arr_Acc[userVal].Customer_Name} \n";
            retString += $"Address: {Arr_Acc[userVal].Customer_Name} \n";
            retString += $"Credit Card Number: {Arr_Acc[userVal].Credit_CN} \n";
            retString += $"Balance Owed: {Arr_Acc[userVal].Balance_Owed} \n";
            retString += $"Minutes Used: {Arr_Acc[userVal].AdjustMinutes(Free_Minutes)} \n";
            retString += $"Cost Per Minute: {Arr_Acc[userVal].CalculateCharge()} \n";

            // Repeat for all required variables to be printed
            // If you need to print it different for Yes / No, you can pass in a boolean as a parameter and use it to adjust the print output.

            return retString;
        }
        private void AccountIncrementer_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinutesAdjuster.Visible = true;

            
            label13.Visible = true;
            CalculateBalance.Visible = true;
        }

        private void Calculations_Click(object sender, EventArgs e)
        {
            
        }

        private void WhichAccount_Click(object sender, EventArgs e)
        {

        }

        private void MinutesAdjuster_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBalance_Click(object sender, EventArgs e)
        {
            CalculateBalance.Visible = true;
            float Free_Minutes = float.Parse(MinutesAdjuster.Text);
            Calculations.Text = Stringify1();
            Calculations.Visible = true;
            WithAdjustments.Visible = true;
            
            btn.Visible = true;
        }

        private void End_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for running Program10");
            MessageBox.Show("I thought my creativity would be enough to get me through this project. I was neyond wrong. " +
                "The amount of time I spent re-organizing and re-evaluating the way my code was, was mindblowing. Still," +
                "it was a lot of fun");
            this.Close();
        }
      
        }
    }

        
        

        
    
    
    

    
    

