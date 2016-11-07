using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public abstract string Draw();

        public string Swim()
        {
            return "swimming"; 
        }

        public string Fly()
        {
            return _flyBehaviour.Fly();
        }

        public string Quack()
        {
            return _quackBehaviour.Quack();
        }

        public abstract void SetFlyBehaviour(IFlyBehaviour flyBehaviour);
    }
}
