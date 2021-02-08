using System;
using System.Collections.Generic;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Mammal", "Mochi", "Calico", new DateTime(2019, 1, 1), new decimal(10.00), new DateTime(2020, 1, 1), true, true);
            Cat cat2 = new Cat("Mammal", "Snowball", "Persian", new DateTime(2017, 1, 1), new decimal(24.95), new DateTime(2020, 1, 1), false, false);
            Cat cat3 = new Cat("Mammal", "Jetson", "Siamese", new DateTime(2016, 9, 1), new decimal(12.95), new DateTime(2018, 1, 1), false, false);
            Cat cat4 = new Cat("Mammal", "Miss Kitty", "Calico", new DateTime(2018, 1, 1), new decimal(24.95), new DateTime(2019, 1, 1), true, false);
            Cat cat5 = new Cat("Mammal", "Leo", "Tabby", new DateTime(2019, 6, 1), new decimal(24.95), new DateTime(2021, 1, 1), true, false);

            Dog dog1 = new Dog("Mammal", "Bob", "Bichon", new DateTime(2019, 1, 1), new decimal(900.95), new DateTime(2021, 1, 1), true, true);
            Dog dog2 = new Dog("Mammal", "Barky", "Terrier", new DateTime(2017, 1, 1), new decimal(2000.95), new DateTime(2020, 1, 1), false, false);
            Dog dog3 = new Dog("Mammal", "Fluffy", "Husky", new DateTime(2016, 9, 1), new decimal(500.95), new DateTime(2020, 1, 1), false, false);
            Dog dog4 = new Dog("Mammal", "Mr. Bo Jangles", "Golden Retriever", new DateTime(2018, 1, 1), new decimal(650.00), new DateTime(2020, 1, 1), true, false);
            Dog dog5 = new Dog("Mammal", "Roxy", "German Shepherd", new DateTime(2019, 6, 1), new decimal(725.00), new DateTime(2021, 1, 1), true, false);

            Lizard lizard1 = new Lizard("Reptile", "Lizzie", "African", new DateTime(2019, 1, 1), new decimal(900.95), new DateTime(2021, 1, 1), true, true);
            Lizard lizard2 = new Lizard("Reptile", "Linus", "Green", new DateTime(2017, 1, 1), new decimal(2000.95), new DateTime(2020, 1, 1), false, false);

            string catintro1 = cat1.GiveIntro();
            Console.WriteLine(catintro1);
            string dogintro1 = dog1.GiveIntro();
            Console.WriteLine(dogintro1);

            var inventory = new Inventory();
            inventory.AddAnimal(dog1);
            inventory.AddAnimal(dog2);
            inventory.AddAnimal(dog3);
            inventory.AddAnimal(dog4);
            inventory.AddAnimal(dog5);
            inventory.AddAnimal(cat1);
            inventory.AddAnimal(cat2);
            inventory.AddAnimal(cat3);
            inventory.AddAnimal(cat4);
            inventory.AddAnimal(cat5);
            inventory.AddAnimal(lizard1);
            inventory.AddAnimal(lizard2);

            bool groomed = cat1.IsGroomed();
            Console.WriteLine(cat1.Name + "'s groom status: " + groomed);

            var stock = inventory.GetInventory();
            foreach(Animal animal in stock)
            {
                Console.WriteLine(animal.Type + " " + animal.Breed + " " + animal.Name + " " + animal.Price);
            }
            Console.WriteLine("Here are the dogs and cats with vaccine status.");
            foreach(Animal a in stock)
            {
                //if(a is Dog)
                if (a.GetType() == typeof(Dog))
                {
                    //var dog = (a as Dog);
                    var dog = ((Dog)a);
                    Console.WriteLine(dog.Name + " status: Rabies - " + dog.HasRabiesVax + " DAP - " + dog.HasDapVax);
                }
                if (a.GetType() == typeof(Cat))
                {
                    //var cat = (a as Cat);
                    var cat = ((Cat)a);
                    Console.WriteLine(cat.Name + " status: FVRCP - " + cat.Has_fvrcp_vax + " FELV - " + cat.Has_felv_vax);
                }

            }
            
            var stockArray = stock.ToArray();
            for (int i = 0; i < stockArray.Length; i++)
            {
                for (int j = i+1; j < stockArray.Length; j++)
                {
                    if(stockArray[i].Price > stockArray[j].Price)
                    {
                        var temp = stockArray[i];
                        stockArray[i] = stockArray[j];
                        stockArray[j] = temp;
                    }
                }
            }
            foreach(Animal ani in stockArray)
            {
                Console.WriteLine(ani.Name + " is $" + ani.Price);
            }

            foreach(Animal anim in stockArray)
            {
                if(anim.Price > 500)
                {
                    var discount20Percent = anim.Price * (new decimal(.2));
                    var discountedPrice = anim.Price - discount20Percent;
                    Console.WriteLine(anim.Name + " is normally " + anim.Price + " and is on sale for " + discountedPrice);
                }
                else
                {
                    Console.WriteLine(anim.Name + " is " + anim.Price);
                }
            }

            foreach(IGroomed ig in inventory.IsGroomed())
            {
                string g = " hasn't been groomed";
                if (ig.IsGroomed())
                {
                    g = " has been groomed";
                }
                Console.WriteLine((ig as Animal)?.Name + g);
            }
        }
    }
}
