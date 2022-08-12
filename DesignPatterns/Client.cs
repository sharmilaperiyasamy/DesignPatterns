using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Client
    {

        //AbstractProducts Spinning and weaving
        private Spinning _Spin;
        private Weaving _Weave;
        //AbstractFactory CottonFactory
        public Client(CottonFactory Cot)
        {
            _Spin = Cot.CreateSpinning();
            _Weave = Cot.CreateWeaving();
        }
        public Spinning clientSpinning
        {
            get { return _Spin; }
        }
        public Weaving clientWeaving
        {
            get { return _Weave; }
        }
    }

    //creating abstract class
    public abstract class CottonFactory
    {
        public abstract Spinning CreateSpinning();
        public abstract Weaving CreateWeaving();
    }

    //Concrete Classes inheriting the Abstract Classes
    public abstract class Spinning { }
    public class ConcreteSpin1 : Spinning { }
    public class ConcreteSpin2 : Spinning { }
    public abstract class Weaving { }
    public class ConcreteWeave1 : Weaving { }
    public class ConcreteWeave2 : Weaving { }


    //ConcreteFactory and ConcreteProducts inheriting the Abstract class
    public class ConcreteSpinning : CottonFactory
    {
        public override Spinning CreateSpinning()
        {
            return new ConcreteSpin1();
        }
        public override Weaving CreateWeaving()
        {
            return new ConcreteWeave1();
        }
    }
    public class ConcreteWeaving : CottonFactory
    {
        public override Spinning CreateSpinning()
        {
            return new ConcreteSpin2();
        }
        public override Weaving CreateWeaving()
        {
            return new ConcreteWeave2();
        }
    }
}
