using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MIS316_Prep2Bjds4751 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProcess_Click(object sender, EventArgs e)
    {
        try
        {
            int intValueFromUser = 0;
            int isPrime = 0;
            intValueFromUser = Convert.ToInt32(txtNumber.Text);
            lblResults.Text = "";
            for (int i = 2; i <= 1000000; i++)
            {
                if (IsMultipleOf(intValueFromUser, i) == true)
                {
                    lblResults.Text += txtNumber.Text + " is a multiple of " + i.ToString() + "<br>";
                    isPrime++;
                }
            }

            if (isPrime == 0)
            {
                lblResults.Text = PrimeNumber(0) + ".";
            }
            if (isPrime == 1)
            {
                lblResults.Text = PrimeNumber(1);
            }
        }
        catch(Exception)
        {
            lblResults.Text = "Could not factor this number. Remove non-numerical characters or try a lower number.";
        }
    }

    protected bool IsMultipleOf(int intNumberToTest, int intRoot)
    {
        bool blnIsMultipleOf = false;
        if (intNumberToTest % intRoot == 0)
        {
            blnIsMultipleOf = true;
        }

        return blnIsMultipleOf;
    }

    protected string PrimeNumber(int i)
    {
        string strOutput = txtNumber.Text + " is not a multiple of any numbers from 2 to 1 million";
        if (i == 1)
        {
            strOutput += " except itself.";
        }
        return strOutput;
    }
}