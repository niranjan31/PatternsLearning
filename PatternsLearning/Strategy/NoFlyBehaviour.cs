using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public string Fly()
        {
            return "cannot fly";
        }
    }
}
