using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
namespace Inheritance
{
    class Program
    {
        public class Animal
        {
            private string name;
            private string color;
            private string type;
            private string ecosystem;
            public string food;
            public Animal() { }
            public Animal(string name, string color, string food, string ecosystem)
            {
                this.name = name;
                this.color = color;
                this.food = food;
                this.ecosystem = ecosystem;
            }


        }

        public class Bird : Animal { 
        private string featherColor;
            private bool flies;
    
            
            private string typeOfNest;
            public Bird(string name, string color, string food, string ecosystem) : base( name,  color,  food,  ecosystem) {
                Console.WriteLine($"{name} {color} {this.food} {ecosystem}");
                


            }
            public void line() {

                Console.WriteLine($"Bird: {food} {this.food}");
            }
            //public void PrintProperties()
            //{
            //    Type type = typeof(Bird);
            //    PropertyInfo[] properties = type.GetProperties();
            //    foreach (PropertyInfo property in properties)
            //    {
            //        Console.WriteLine("\t" + property);
            //    }

            //}


        }

        public class Reptile : Animal {
            private bool isVelociraptor;
            private bool laysEgg;
            private string landSpeed;
            private string g;
            public Reptile(string d, string e, string g, string f) : base(d,e,g,f) { 
            }
            public void line()
            {
   
            }



        }
        public static IEnumerable<object> GetAllProperties(object obj)
        {
            Console.WriteLine("HEllo");
            return obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(field => field.GetValue(obj));
            // .Select(prop => prop.GetValue(obj)));
        }

        static void print(IEnumerable<object> e) {
            foreach (var i in e) {
                Console.WriteLine($"{i}");
            
            }
        }
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird b = new Bird("Blue Bird", "Blue","Earthworm", "Forest, Cities") ;

            Reptile r = new Reptile("Alligator", "Green", "Fish", "Swamps");
            Type p = typeof(Bird);
            Type f = typeof(Reptile);
            print(GetAllProperties(p));
            GetAllProperties(b);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
