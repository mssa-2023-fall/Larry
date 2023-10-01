using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Mortage_Calculator_Console;
using MortgageCalculator;
using System.Text.Json;
using System.Net.Http.Json;


namespace MortageCalculator
{
    public class Payments
    {

        public DateTime date { get; set; }
        public decimal principal { get; set; }
        public decimal interest { get; set; }
        public decimal total => principal * interest;
    }
    public class MortgageProperties : Payments
    {
        public int DurationInYears { get; set; }
        public double InterestRate { get; set; }
        public decimal PrincipalAmount { get; set; }
        public DateTime OriginationDate { get; set; }
        public List<Payments> Payments { get; private set; }

        public MortgageProperties(int durationInYears, double interestRate, decimal principalAmount, DateTime originationDate)
        {
            DurationInYears = durationInYears;
            InterestRate = interestRate;
            PrincipalAmount = principalAmount;
            OriginationDate = originationDate;
            Payments = new List<Payments>();
            CalculateAmortizationSchedule();
        }

        private void CalculateAmortizationSchedule()
        {
            decimal monthlyInterestRate = (decimal)(InterestRate / 12 / 100);
            int totalPayments = DurationInYears * 12;
            decimal remainingPrincipal = PrincipalAmount;

            for (int month = 0; month < totalPayments; month++)
            {
                decimal interestPayment = remainingPrincipal * monthlyInterestRate;
                decimal principalPayment = GetMonthlyPayment() - interestPayment;
                remainingPrincipal -= principalPayment;

                Payments payment = new Payments
                {
                    date = OriginationDate.AddMonths(month + 1),
                    principal = principalPayment,
                    interest = interestPayment
                };

                Payments.Add(payment);
            }
        }

        public decimal GetMonthlyPayment()
        {
            decimal monthlyInterestRate = (decimal)(InterestRate * 12 / 100);
            int totalPayments = DurationInYears * 12;
            decimal numerator = PrincipalAmount * monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, totalPayments);
            decimal denominator = (decimal)Math.Pow(1 + (double)monthlyInterestRate, totalPayments) - 1;
            return numerator / denominator;
        }
        public DateTime GetPayoffDate()
        {
            return OriginationDate.AddYears(DurationInYears);
        }
        public decimal RemainingPrincipalAtDate(DateTime date)
        {
            decimal remainingPrincipal = PrincipalAmount;
            foreach (var payment in Payments)
            {
                if (payment.date > date)
                {
                    break;
                }
                remainingPrincipal -= payment.principal;
            }
            return remainingPrincipal;
        }
        public decimal InterestPaidAtDate(DateTime date)
        {
            decimal interestPaid = 0;
            foreach (var payment in Payments)
            {
                if (payment.date > date)
                {
                    break;
                }
                interestPaid += payment.interest;
            }
            return interestPaid;
        }
        //public void SaveToJson(string fileName)
        //{
        //    string json = JsonConverter(this, Formatting.Indented);
        //    File.WriteAllText(fileName, json);
        //}

        public enum Rate
        {
            TenYears = 10,
            FifteenYears = 15,
            ThirtyYears = 30,
        }

    }
}