using System;
namespace ArithmeticExerciseOne {
    public class Product {
        public double newPayments(double cost, double deliveryFee) {
           double cents = (cost + deliveryFee) * 100;
            return cents;
        }
    }
    class Program{
        static void Main(string [] args ){
            Product Total = new Product(); 

            Console.WriteLine("Total in Cents: "+ Total.newPayments(19.995, 5.4925));
        }
    }
}