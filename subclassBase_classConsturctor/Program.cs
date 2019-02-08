using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;   
using System.Threading.Tasks;

namespace subclassBase_classConsturctor
{
    public class Bod
    {
        private short x;
        private short y;

        public Bod()
        {
            x = y = 0;
        }
        public Bod(short nx, short ny)
        {
            x = nx;
            y = ny;
        }
        public short DejX()
        {
            return x;
        }
        public void NastavX(short nx) { x = nx; }
        public short DejY() { return y; }
        public void NastavY(short ny) { y = ny; }
        public virtual double Plocha()
        {
            return 0;
        }
    }
    public class Kruh : Bod
    {
            private short r;
            public Kruh() { r = 0; }
            public Kruh(short nx, short ny, short r) : base(nx, ny)
            {
                this.r = r;
            }
            public Kruh (Bod b, short nr) : this(b.DejX(), b.DejY(), nr )
            {

            }           

            public override double Plocha()
            {
                return (Math.PI * r * r);
            }
    }
    
    

    

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList entity = new ArrayList();
            entity.Add(new Bod(1, 2));
            entity.Add(new Kruh(3, 4, 5));
            entity.Add(new Bod(6, 7));
            entity.Add(new Kruh());

            foreach(Bod b in entity)
            {
                Type typ = b.GetType();
                Console.WriteLine("{0} : {1}", typ.Name, b.Plocha());
            }

        }
    }
}
