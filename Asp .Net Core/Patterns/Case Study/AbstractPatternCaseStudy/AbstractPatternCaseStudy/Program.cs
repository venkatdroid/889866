using System;

namespace AbstractPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFactory orderFactory = new ConcreteOrderFactory();
            OrderClient orderClient = new OrderClient(orderFactory);
            orderClient.OrderItem(Product.ElectronicProducts,Channel.ECommerceWebsite).processOrder();
            orderClient.OrderItem(Product.Furniture, Channel.TeleCallerAgents).processOrder();
            orderClient.OrderItem(Product.Toys, Channel.ECommerceWebsite).processOrder();
            orderClient.OrderItem(Product.ElectronicProducts, Channel.TeleCallerAgents).processOrder();
            orderClient.OrderItem(Product.Toys, Channel.TeleCallerAgents).processOrder();
            Console.ReadKey();
        }

        
    }
    public enum Product { 
        ElectronicProducts,Toys,Furniture
    }
    public enum Channel {
        ECommerceWebsite,TeleCallerAgents
    }


}
