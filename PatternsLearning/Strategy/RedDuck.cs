using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy
{
    public class RedDuck : Duck
    {
        public RedDuck()
        {
            _flyBehaviour = new CanFlyBehaviour();
            _quackBehaviour = new QuackBehaviour();
        }

        public override string Draw()
        {
            return "drawn red duck";
        }

        public override void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }
    }
}
