using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP = DemoNamespace;
using P = DemoNamespace.Enfant;

namespace DemoNamespace.Enfant.Enfant
{
    struct EncoreAutreStruct
    {
        P.MaStruct maStruct;
        GP.MaStruct monAutreStruct;
        
        public void Test()
        {
            System.Console.WriteLine("salut");
        }

    }
}
