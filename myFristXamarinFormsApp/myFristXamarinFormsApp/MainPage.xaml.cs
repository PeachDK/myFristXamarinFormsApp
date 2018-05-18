using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myFristXamarinFormsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


        public void OnButtonSelected(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            if (resultText.Text == "0")
            {
                resultText.Text = "";
            }

            resultText.Text += button.Text;
        }

        public void OnClearSelected(object sender, EventArgs args)
        {
            resultText.Text = "0";
        }
       
        public void OnCalculate(object sender, EventArgs args)
        {
            
                string expression = resultText.Text;

                if (expression.Contains("X"))
                {
                    expression = expression.Replace("X", "*");
                }
                DataTable dt = new DataTable();
                var v = dt.Compute(expression, "");

                resultText.Text = v.ToString();
            

        }

    }

}
