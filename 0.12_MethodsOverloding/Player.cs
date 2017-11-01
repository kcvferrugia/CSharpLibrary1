using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloding
{
    class Player
    {
    
        static void Player(string[] args)
           
        //Example

        public string Name { get; set; }
        public string W1 { get; set; }
        public string W2 { get; set; }
        public int Damage { get; set; }
    }

        //Properties
        string Name = "KatKat";
        string W1 = "poison";
        string W2 = "lightening";

    }
    
        //Method
        public double Attack();
  

        //Methods
        public double Attack()
    {
        Random rnd = new Random();
        int spread = rnd.Next(-3, 3);
        double damage = this.AttackPower + spread;
        bool isCrit = IsCritical();
        return isCrit ? (damage * 2) : damage;
    }

    public bool IsCritical()
    {
        Random rnd = new Random();
        bool isCrit = rnd.Next(0, 100) < (this.CritChance * 100) ? true : false;
        return isCrit;
    }

