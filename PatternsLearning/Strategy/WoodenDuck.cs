using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            _flyBehaviour = new NoFlyBehaviour();
            _quackBehaviour = new MuteQuackBehaviour();
        }

        public override string Draw()
        {
            return "drawn wooden duck";
        }

        public override void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }
    }
}
