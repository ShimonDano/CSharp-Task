using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class SalaryEmployeeWithCommitions : SalaryEmployee
    { 
        public override double calculatePayment()
        {
            double totalSalary = this.baseSalary;
            foreach (ExtraPay e in this.extraPayment)
            {
                if (e is CommitionBonus && !(e.GetDescription()))
                {
                    totalSalary += e.GetaAmount();
                    e.SetDescription(true);
                }
            }
            return totalSalary;
        }

        public override string pay()
        {
            return $"Name: {this.Fname} {this.Lname} title: {this.jobTitle} bonus: {calculatePayment() - this.baseSalary} Slary: {this.calculatePayment()}";
        }
    }
}
