using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class ExtraPay
    {
        protected double amount; // the bonus amount
        protected bool description; // employye get the bonus?

        public double GetaAmount() => this.amount;
        public bool GetDescription() => this.description;

        public void SetDescription(bool value) => this.description = value;
        


    }
}
