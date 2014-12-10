using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06_WebCalculator
{
    public partial class WebCalculator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnCommand(object sender, CommandEventArgs e)
        {
            string result;

            if (this.TextBoxOutput.Text.Contains('=') || 
                this.TextBoxOutput.Text.Contains('0') ||
                this.TextBoxOutput.Text.Contains('\u221A'))
            {
                this.TextBoxOutput.Text = string.Empty;
            }
            switch (e.CommandName)
            {
                case "=":
                    result = this.CalcualteResult(this.TextBoxOutput.Text);
                    this.TextBoxOutput.Text += "=" + result;
                    return;
                case "Clear":
                    this.TextBoxOutput.Text = "0";
                    return;
                case "Sqrt":
                    result = this.CalculateSqrt(this.TextBoxOutput.Text);
                    this.TextBoxOutput.Text += '\u221A' + "=" + result;
                    return;
                default:
                    break;
            }

            this.TextBoxOutput.Text += e.CommandName;
        }

        private string CalcualteResult(string input)
        {
            string[] numbers = input.Split('+', '-', '*', '/');
            int firstNum = int.Parse(numbers[0]);
            int secondNum = int.Parse(numbers[1]);

            if (input.Contains("+"))
            {
                return (firstNum + secondNum).ToString();
            }
            else if (input.Contains("-"))
            {
                return (firstNum - secondNum).ToString();
            }
            else if (input.Contains("*"))
            {
                return (firstNum * secondNum).ToString();
            }
            else if (input.Contains("/"))
            {
                return (firstNum / secondNum).ToString();
            }
            else
            {
                return "invalid";
            }
        }

        private string CalculateSqrt(string input)
        {
            double number = double.Parse(input);
            double result = Math.Sqrt(number);
            return result.ToString();
        }
    }
}