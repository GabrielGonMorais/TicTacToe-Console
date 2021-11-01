using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    abstract class Players
    {
        public string Name { get; protected set; }
        public int Victories { get; protected set; }        

        public abstract void ChooseTheName();
        public abstract void ChoosePosition();
        public abstract void VerifyWinner();


    }
}
