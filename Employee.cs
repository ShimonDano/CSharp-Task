using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    abstract class Employee : Person
    {
        protected string jobTitle;

        public abstract double calculatePayment();

        public abstract string pay(); 
    }
}
