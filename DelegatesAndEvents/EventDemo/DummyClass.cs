using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventDemo
{
    internal partial class DummyClass
    {
        public event EventHandler OnPropertyChange;

        private string dummyName;

        public string DummyName
        {
            get { return dummyName; }
            set
            {
                dummyName = value;
                OnPropertyChange(this,new EventArgs());
               // OnPropertyChange?.Invoke(this,new EventArgs());
            }
        }


    }
}
