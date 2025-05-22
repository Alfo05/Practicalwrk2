using Microsoft.Maui.Controls;
using System;
namespace Maui
{
    public partial class Calculator : ContentPage
    {
        private Converter converter;

        public Calculator()
        {
            InitializeComponent();
            converter = new Converter();

            foreach (var operation in converter.operations)
            {
                conversionPicker.Items.Add(operation.GetDefintion);
            }

        }
        public void OnCalcClick(object sender, EventArgs e)
        {
            string input = InputEntry.Text;
            if (conversionPicker.SelectedIndex == -1 || string.IsNullOrEmpty(input))
            {
                resultLabel.Text = "Select a Value and how you want to convert it";
                return;
            }
            try
            {
                int index = conversionPicker.SelectedIndex;
                string result = converter.PerformConversion(index, input);
                resultLabel.Text = result;
            }
            catch (Exception ex)
            {
                resultLabel.Text = $"Error: {ex.Message}";
            }
            
        }
    }
   
}