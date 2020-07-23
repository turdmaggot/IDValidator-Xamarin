using System.ComponentModel;
using Xamarin.Forms;
using IDValidator.Logic;
using System;

namespace IDValidator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnValidate_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                string idNumber = txtIDNumber.Text.Trim();
                if (txtIDNumber.Text != "")
                {
                    bool isValid = Computations.validateDlsuIdNumber(int.Parse(idNumber));
                    if (isValid)
                    {
                        DisplayAlert("ID Validator", "ID Number " + idNumber + " is VALID.", "Ok");
                    }
                    else
                    {
                        DisplayAlert("ID Validator", "ID Number " + idNumber + " is INVALID.", "Ok");
                    }
                }
                else
                {
                    DisplayAlert("ID Validator", "Please enter an ID number to validate.", "Ok");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ID Validator", "Please check if your input format is correct.", "Ok");
            }
            
        }
    }
}
