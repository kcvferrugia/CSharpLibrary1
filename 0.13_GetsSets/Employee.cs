using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GetsSets
{
    class Employee
    {
        //"Backing" FIELDS (shortcut 'prop' + 'full'
        private int _id;
        private string _name;
        private string _WorkQuote;

        //Properties


        public int ID

        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The Employee is invalid");//if user inputs value that is negative
                _id = value;
            }

        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    _name = value.Trim();
                //same as: set {if (string.IsNullOrWhiteSpace(value)) _name = value.Trim();}

            }

        }
        public WorkQuote { get; set; }

        //Method
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote;
        }
        public string GetQuote();
        {
            return this._workQuote;
        }
    }          
}
    
    
