using MortageCalculator;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MortgageCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Retrieve user input from UI elements
                int duration = int.Parse(DurationTextBox.Text);
                double interestRate = double.Parse(InterestRateTextBox.Text);
                decimal principalAmount = decimal.Parse(PrincipalAmountTextBox.Text);
                DateTime originationDate = OriginationDatePicker.SelectedDate.Value;

                // Create a MortgageProperties object
                MortgageProperties mortgage = new MortgageProperties(duration, interestRate, principalAmount, originationDate);

                // Calculate mortgage details
                decimal monthlyPayment = mortgage.GetMonthlyPayment();
                DateTime payoffDate = mortgage.GetPayoffDate();
                decimal remainingPrincipal = mortgage.RemainingPrincipalAtDate(DateTime.Now);
                decimal interestPaidToDate = mortgage.InterestPaidAtDate(DateTime.Now);

                // Display results in the ResultTextBlock
                ResultTextBlock.Text = $"Monthly Payment: {monthlyPayment:C}\n" +
                                       $"Payoff Date: {payoffDate:d}\n" +
                                       $"Remaining Principal: {remainingPrincipal:C}\n" +
                                       $"Interest Paid to Date: {interestPaidToDate:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
