using System;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine +"MEEOW";
        }
    } //Polymorphism is the ability of an object to take on many forms
}
