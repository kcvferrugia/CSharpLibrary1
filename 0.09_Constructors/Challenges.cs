using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Challenges
    {
        //Construct
        public Challenges(string phoneType, int phoneModel)
        {
            this.PhoneType = phoneType;
            this.PhoneModel = PhoneModel;
        }

        //Properties
        public string PhoneType { get; set; }
        public int PhoneModel { get; set; }


    }
}
