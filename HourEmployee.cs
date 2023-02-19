using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class HourEmployee : Employee
    {
        private double AccumulatedHours;
        private double PaymentPerHour;

        public override double calculatePayment() => this.AccumulatedHours * this.PaymentPerHour;
 
        public override string pay() => $"Name: {this.Fname} {this.Lname} title: {this.jobTitle} Slary: {this.calculatePayment()}";
        
    }
}
