using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M_7_Final_Ex
{
    abstract class Delivery
    {
        protected string Address;

       public Delivery(string Address) 
        {
            this.Address = Address;
        }

        public virtual void ShowAdress()  // виртуальный метод для вывода адреса
        {
            Console.Write(Address);

        }

        public abstract void DeliveryProcess(); //абстрактный метод для вывода информации о доставке
        
    }

    class HomeDelivery : Delivery
    {
        
        public HomeDelivery(string Address) : base(Address) {
        }

        public Courier courier { get; set; } // Связываем курьера с доставкой на дом 

        public string RecipientName { get; set; }


        public override void ShowAdress()
        {


            Console.WriteLine($"Выбрана доставка на дом по адресу: ");
            base.ShowAdress();

        }


            public override void DeliveryProcess()
            {
            courier.DeliverToHome(RecipientName);  
            }
    }


    class Courier
    {
        public string Name { get; set; }
        Order<HomeDelivery> order; // Курьер принимает только заказы на дом

        public void DeliverToHome(string recipientName)
        {
            Console.WriteLine($"Доставка для {recipientName},  имя курьера: {Name}");

        }


    }

    class PickPointDelivery : Delivery
    {

       public PickPointDelivery(string Address) : base(Address) { }


        public PickPoint PickPoint; // Связываем класс пункт выдачи с классом доставки в пункт выдачи
        public string RecipientName { get; set; }

        public override void ShowAdress()
        {

            Console.WriteLine($"Выбрана доставка в пункт выдачи, находящегося по адресу: ");
            base.ShowAdress();
        }

            public override void DeliveryProcess()
            {
            PickPoint.DisplayPickPointInfo(RecipientName);
            }

        }


    class PickPoint
    {
        public string Name { get; set; }
        
        public string StorageTime{ get; set; }

        public void DisplayPickPointInfo(string recipientName)
        {
            Console.WriteLine($"Пункт Выдачи: {Name}");
            Console.WriteLine($"Получатель: {recipientName}");
            Console.WriteLine($"Срок хранения заказа: {StorageTime}");
        }
    }


    class ShopDelivery : Delivery
    {

        public ShopDelivery(string Address) : base(Address) { }

        public Shop Shop;
        

        public override void ShowAdress()
        {

            Console.WriteLine($"Выбрана доставка в магазин, находящегося по адресу: ");
            base.ShowAdress();
        }

            public override void DeliveryProcess()
            {

            
            Shop.DisplayShopInfo();

            }
        }


    class Shop
    {
        public string Name { get; set; }
        
        public string OpeningHours { get; set; }
        
        public string PhoneNumber { get; set; }

        public void DisplayShopInfo()
        {
            Console.WriteLine($"Название магазине: {Name}");
            Console.WriteLine($"Часы работы: {OpeningHours}");
            Console.WriteLine($"Номер горячей линии: {PhoneNumber}");
        }
    }



    class Product
    {
        public string ProductName { get; set; }

        public Product(string productName)
        {
            this.ProductName = productName;
        }
    }

        class Order<TDelivery> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public  int OrderNumber;

            public Product Description;

            private static int OrderNumberCounter = 1; // счетчик для присвоения номера заказу



            public Order()
            {
                OrderNumber = Order<Delivery>.OrderNumberCounter++;  // при создании каждого нового заказа номер будет инкременироваться 

                Console.WriteLine("Введите описание товара");

                Description = new Product(Console.ReadLine());

          

            }

            public void DisplayAddress()
            {
                Delivery.ShowAdress();
            }

            public void OrderProcess() //выбор переопределенного метода DeliveryProcess в зависимости от способа доставки
        {
            Console.WriteLine($"\nВаш заказ #{OrderNumber}, товар: {Description.ProductName}");

            if(Delivery is HomeDelivery homeDelivery)
            {
                homeDelivery.DeliveryProcess();
            } else if(Delivery is ShopDelivery shopDelivery)
            {
                shopDelivery.DeliveryProcess();
            }
            else if (Delivery is PickPointDelivery pickPointDelivery)
            {
               pickPointDelivery.DeliveryProcess();
            }

        }


        }




    




    internal class Program
            {
                static void Main(string[] args)
                {


            Delivery homeDelivery = new HomeDelivery("random address")

            {

                RecipientName = "Jane",
                courier = new Courier()
                {

                    Name = "Thomas"
                }
            };

            Delivery pickPointDelivery = new PickPointDelivery("random adress")
            {

                RecipientName = "Bob",
                PickPoint = new PickPoint()
                {

                    Name = "SomePickPOint",
                    StorageTime = "3 дня"

                }

            };


            Delivery shopDelivery = new ShopDelivery("shop adress")
            {
                Shop = new Shop()
                {
                    Name = "Some Shope",
                    OpeningHours = "10.00 - 22.00",
                    PhoneNumber = "8933 933 33"
                }
            };



            Console.WriteLine("Создание заказа для доставки на дом");

            Order<HomeDelivery> order = new Order<HomeDelivery>
            {
                Delivery = (HomeDelivery)homeDelivery


            };

            Console.WriteLine("Создание заказа для доставки в пункт выдачи");

            Order<PickPointDelivery> order1 = new Order<PickPointDelivery>
            {
                Delivery = (PickPointDelivery)pickPointDelivery
            };


            Console.WriteLine("Создание заказа для доставки в магазин");
            Order<ShopDelivery> order2 = new Order<ShopDelivery>
            {
                Delivery = (ShopDelivery)shopDelivery
            };






            order.DisplayAddress(); 
            order.OrderProcess();


            Console.WriteLine();


            order1.DisplayAddress();
            order1.OrderProcess();


            Console.WriteLine();

            order2.DisplayAddress();
            order2.OrderProcess();


           






            Console.ReadKey();
                }


            }
        }

    
