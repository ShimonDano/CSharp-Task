using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class DataStore
    {
        private int x;
        private List<IObserver<int>> lst = new List<IObserver<int>>();

        public DataStore(int x, IObserver<int> o)
        {
            this.x = x;
            lst.Add(o);
        }

        public int GetX() => this.x;

        public void SetX(int x)
        {
            this.x = x;
            this.Notify(this.x);
        }

        public void Notify(int x)
        {
            foreach (IObserver<int> i in lst)
                if(i is Product)
                    i.OnNext(x);
        }
    }
}
