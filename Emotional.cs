using Family.Common;
using System;

namespace ConsoleFamily
{
    class Emotional : ChainElement, IEmotional
    {
        private readonly string owner;
        private readonly string laughingSound;

        public Emotional(string owner, string laughingSound, IChainElement next)
            : base(next)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public Emotional(string owner, string laughingSound)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this.owner, this.laughingSound);
        }
    }
}