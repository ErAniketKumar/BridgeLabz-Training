// using System;
// using System.Collections.Generic;


// // ABSTRACTION - The key to OCP
// public interface IShape
// {
//     double CalculateArea();
// }

// // Each shape is a separate class implementing IShape
// // Adding a new shape doesn't modify existing ones
// public class Circle : IShape
// {
//     public double Radius { get; set; }

//     public double CalculateArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }

// public class Rectangle : IShape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public double CalculateArea()
//     {
//         return Width * Height;
//     }
// }

// public class Triangle : IShape
// {
//     public double Base { get; set; }
//     public double Height { get; set; }

//     public double CalculateArea()
//     {
//         return (Base * Height) / 2;
//     }
// }

// public class Square : IShape
// {
//     public double Side { get; set; }

//     public double CalculateArea()
//     {
//         return Side * Side;
//     }
// }

// // NEW SHAPE - Just add this class, no existing code changes!
// public class Pentagon : IShape
// {
//     public double Side { get; set; }

//     public double CalculateArea()
//     {
//         // Area of regular pentagon = (1/4) * sqrt(5(5+2√5)) * s²
//         return (1.0 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Side * Side;
//     }
// }

// // Calculator class - CLOSED for modification
// public class AreaCalculator
// {
//     // This method never needs to change regardless of how many shapes we add
//     public double CalculateArea(IShape shape)
//     {
//         // Polymorphism does all the work
//         return shape.CalculateArea();
//     }

//     // Can also work with collections
//     public double CalculateTotalArea(IEnumerable<IShape> shapes)
//     {
//         double total = 0;
//         foreach (var shape in shapes)
//         {
//             total += shape.CalculateArea();
//         }
//         return total;
//     }
// }

// // ADVANCED EXAMPLE: Strategy Pattern for OCP
// // Different discount strategies for e-commerce

// public interface IDiscountStrategy
// {
//     decimal ApplyDiscount(decimal price);
//     string StrategyName { get; }
// }

// // Each discount strategy is a separate class - OCP in action
// public class NoDiscountStrategy : IDiscountStrategy
// {
//     public string StrategyName => "No Discount";

//     public decimal ApplyDiscount(decimal price) => price;
// }

// public class PercentageDiscountStrategy : IDiscountStrategy
// {
//     private readonly decimal _percentage;

//     public PercentageDiscountStrategy(decimal percentage)
//     {
//         _percentage = percentage;
//         StrategyName = $"{percentage}% Discount";
//     }

//     public string StrategyName { get; }

//     public decimal ApplyDiscount(decimal price)
//     {
//         return price * (1 - _percentage / 100);
//     }
// }

// public class BuyOneGetOneFreeStrategy : IDiscountStrategy
// {
//     public string StrategyName => "Buy One Get One Free";

//     public decimal ApplyDiscount(decimal price)
//     {
//         // BOGO means 50% off if buying 2 items
//         return price * 0.5m;
//     }
// }

// public class SeasonalDiscountStrategy : IDiscountStrategy
// {
//     public string StrategyName => "Seasonal Sale";

//     public decimal ApplyDiscount(decimal price)
//     {
//         // 30% off during season
//         return price * 0.7m;
//     }
// }

// // NEW STRATEGY - Add without modifying existing code!
// public class LoyaltyPointsDiscountStrategy : IDiscountStrategy
// {
//     private readonly int _points;

//     public LoyaltyPointsDiscountStrategy(int points)
//     {
//         _points = points;
//         StrategyName = $"Loyalty Discount ({points} points)";
//     }

//     public string StrategyName { get; }

//     public decimal ApplyDiscount(decimal price)
//     {
//         // Each 100 points gives 5% discount, max 50%
//         var discountPercent = Math.Min(50, (_points / 100) * 5);
//         return price * (1 - discountPercent / 100);
//     }
// }

// // Product class that uses discount strategy
// public class Product
// {
//     public string Name { get; set; }
//     public decimal Price { get; set; }
//     public IDiscountStrategy DiscountStrategy { get; set; }

//     public decimal GetFinalPrice()
//     {
//         if (DiscountStrategy == null)
//             return Price;

//         return DiscountStrategy.ApplyDiscount(Price);
//     }
// }

// // Advanced OCP: Specification Pattern for filtering
// public interface ISpecification<T>
// {
//     bool IsSatisfiedBy(T item);
// }

// // Product specifications - each is separate and doesn't require modification
// public class PriceSpecification : ISpecification<Product>
// {
//     private readonly decimal _minPrice;
//     private readonly decimal _maxPrice;

//     public PriceSpecification(decimal minPrice, decimal maxPrice)
//     {
//         _minPrice = minPrice;
//         _maxPrice = maxPrice;
//     }

//     public bool IsSatisfiedBy(Product product)
//     {
//         return product.Price >= _minPrice && product.Price <= _maxPrice;
//     }
// }

// public class NameContainsSpecification : ISpecification<Product>
// {
//     private readonly string _text;

//     public NameContainsSpecification(string text)
//     {
//         _text = text.ToLower();
//     }

//     public bool IsSatisfiedBy(Product product)
//     {
//         return product.Name.ToLower().Contains(_text);
//     }
// }

// public class AndSpecification<T> : ISpecification<T>
// {
//     private readonly ISpecification<T> _first;
//     private readonly ISpecification<T> _second;

//     public AndSpecification(ISpecification<T> first, ISpecification<T> second)
//     {
//         _first = first;
//         _second = second;
//     }

//     public bool IsSatisfiedBy(T item)
//     {
//         return _first.IsSatisfiedBy(item) && _second.IsSatisfiedBy(item);
//     }
// }

// // Filter class - closed for modification, open for extension
// public class ProductFilter
// {
//     public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
//     {
//         foreach (var product in products)
//         {
//             if (spec.IsSatisfiedBy(product))
//                 yield return product;
//         }
//     }
// }

