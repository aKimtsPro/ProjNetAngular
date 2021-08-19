using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO.Encapsulation
{
    public class DemoAccess
    {
        public int v1;
        protected int v2;
        internal int v3;
        protected internal int v4;
        private protected int v5;
        private int v6;
    }

    public class Enfant : DemoAccess
    {
        public void Method()
        {
            int a = this.v1;
            a = this.v2;
            a = this.v3;
            a = this.v4;
            a = this.v5;
            //a = this.v6;
        }
    }
}
