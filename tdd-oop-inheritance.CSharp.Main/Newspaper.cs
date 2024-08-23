using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryLoan
    {

        public Newspaper(string title) : base(title) {

        }

        public override string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            OnLoan = false;

            return "newspaper has been checked in";
        }

        public override string checkOut()
        {
            if (this.isOnLoan())
            {
                return "newspaper is currently on loan";
            }

            OnLoan = true;

            return "newspapers are not available for loan";
        }
    
    }
}
