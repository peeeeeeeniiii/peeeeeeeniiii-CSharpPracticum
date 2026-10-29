using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public interface IDiscountStrategy { decimal Apply(decimal price); }
    public class NoDiscount : IDiscountStrategy { public decimal Apply(decimal price) { return price; } }
    public class VipDiscount : IDiscountStrategy { public decimal Apply(decimal price) { return price * 0.90m; } }
    public class PromoDiscount : IDiscountStrategy { public decimal Apply(decimal price) { return price * 0.80m; } }
    public class PriceCalculator
    {
        private readonly IDiscountStrategy _strategy;
        public PriceCalculator(IDiscountStrategy strategy) { _strategy = strategy; }
        public decimal Calculate(decimal price) { return _strategy.Apply(price); }
    }
    public class Task26_Discounts : TaskBase
    {
        public override string Title { get { return "26. Паттерн Strategy: скидки"; } }
        public override void Run()
        {
            decimal price = 1000m;
            Console.WriteLine("Без скидки: " + new PriceCalculator(new NoDiscount()).Calculate(price));
            Console.WriteLine("VIP 10%: " + new PriceCalculator(new VipDiscount()).Calculate(price));
            Console.WriteLine("Промо 20%: " + new PriceCalculator(new PromoDiscount()).Calculate(price));
        }
    }
}
