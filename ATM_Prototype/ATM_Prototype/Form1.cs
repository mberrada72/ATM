using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bluelaser.Utilities;

namespace ATM_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Validate_Click(object sender, EventArgs e)
        {
            string cardNum = textBox1.Text;
            if (CreditCardUtility.IsValidNumber(cardNum))
            {
                CreditCardTypeType? cardType = CreditCardUtility.GetCardTypeFromNumber(cardNum);
                string strCardType = (cardType == null) ? "Unknown" : cardType.ToString();

                MessageBox.Show("You have entered a valid card number. The card type is {0}." + strCardType);
            }
            else
                MessageBox.Show("Card failed Luhn test. Please enter a valid card number.");
        }
    }
}
