using System;
using System.IO;  // include the System.IO namespace
//Create an Object
namespace OOppractise
{

    //class1 def
    class Car
    {
        public string color = "red";


    }

    //class2 def
    class Carcolor
    {
        public string color1 = "red";
    }
    //class3 def
    class MyClass
    {
        // Class members-declaring new fields
        public string color = "red";        // field
        public int maxSpeed = 200;          // field
        //declaring a method
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    //class4 def
    class Car1
    {
        public string model;
        public string color;
        public int year;


    }

    //class5 def

    // Create a Car class
    class Carmodel
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Carmodel()
        {
            model = "Mustang"; // Set the initial value for model
        }


    }
    //private
    class Carprivate
    {
        private string model;

        //calling within same class-output as expected
        /*static void Main(string[] args)
        {
            Carprivate Ford2 = new Carprivate();
            Ford2.model = "Mustang";
            Console.WriteLine(Ford2.model);
        }*/
    }
    //using Public access modifier
    class Carpublic
    {
        public string modifier = "public";
    }
    //get n set

    class Person
    {
        private string name; // declaring field
        public string Name   //declare property
        {
            get { return name; } //use filed within property
            set { name = value; }
        }
    }
    //automatic prop-this doesnt have a seperate method as above
    class Person1
    {
        public string Name  // property
        { get; set; }
        
     }

    //inheritance
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Cars : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    //sealed
    //the below will throw error as vahicle(parent) is sealed
    /*sealed class Vehicle1
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Carss : Vehicle1  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }*/
    //polymorphism-case1:output is similar inspite of different inputs
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    //polymorphism-case2:output is different for different inputs

    class Animal7  // Base class (parent) 
    {
        public virtual void animalSound7()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig7 : Animal7  // Derived class (child) 
    {
        public override void animalSound7()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog7 : Animal7  // Derived class (child) 
    {
        public override void animalSound7()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    //abstract class
    abstract class Animalabstract
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    //
    //if we want a create object for abstract class-first create derive class and then create object
    class inherit : Animalabstract
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    // interface -usually doesnt has body only method(should use interfacekeyword only)
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
        //void run(); // interface method (does not have a body)
    }
    // Piginterface "implements" the IAnimal interface
    //Piginterface should define body for the methods in interface class above
   //if I create below class without run method(if uncommented in interface),I get error
    class Piginterface : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    //creating 1 more interface for multiple inetrface concept
    interface Imessage
    {
        void message(); // interface method (does not have a body)
        //void run(); // interface method (does not have a body)
    }
    //Multiple inetrfaces-creating devired class for multiple interfaces

    class DemoClass : IAnimal, Imessage
    {
        public void animalSound()
        {
            Console.WriteLine("its pig");
        }
        public void message()
        {
            Console.WriteLine("its inheritance");
        }
    }
    //
    // Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
    enum Months
    {
        January,    // 0
        February,   // 1
        March = 16,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }
    class Program
     {
         static void Main(string[] args)
         {
            //belo fails due to private access modifier for carprivate
             /*Carprivate Ford2 = new Carprivate();
             Ford2.model = "Mustang";
             Console.WriteLine(Ford2.model);*/

            /*Car myObj = new Car();
             //sigle object creation
             Console.WriteLine(myObj.color);
             //multiple object creation
             Car myObj1 = new Car();
             Car myObj2 = new Car();
             Console.WriteLine(myObj1.color);
             Console.WriteLine(myObj2.color);

             //using new field and method
             MyClass myObj3 = new MyClass();
             Console.WriteLine(myObj3.color);
             Console.WriteLine(myObj3.maxSpeed);
             myObj3.fullThrottle();

             //Creating multiple objects
             Car1 Ford = new Car1();
             Ford.model = "Mustang";
             Ford.color = "red";
             Ford.year = 1969;

             Car1 Opel = new Car1();
             Opel.model = "Astra";
             Opel.color = "whit";
             Opel.year = 2005;

             Console.WriteLine(Ford.model);
             Console.WriteLine(Opel.model);
             //
             Carmodel Ford1 = new Carmodel();  // Create an object of the Car Class (this will call the constructor)
             Console.WriteLine(Ford1.model);  // Print the value of model

            //calling public
            Carpublic type = new Carpublic();
            type.modifier = "Public";
            Console.WriteLine(type.modifier);

            //get n set

            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            //automatic 
            Person1 Obj7 = new Person1();
            Obj7.Name = "Liam";
            Console.WriteLine(Obj7.Name);

            //inheritance

            // Create a myCar object
            Cars myCar = new Cars();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);*/

            //polymorphism-case1:output is similar inspite of different inputs
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            //polymorphism-case2:output is different for different inputs
            Animal7 myAnimal7 = new Animal7();  // Create a Animal object
            Animal7 myPig7 = new Pig7();  // Create a Pig object
            Animal7 myDog7 = new Dog7();  // Create a Dog object

            myAnimal7.animalSound7();
            myPig7.animalSound7();
            myDog7.animalSound7();

            //create object for abstract-fails
            // Animalabstract a = new Animalabstract();

            //if we want a create object for abstract class-first create derive class and then create object
           
                inherit a = new inherit(); // Create a Pig object
                a.animalSound();  // Call the abstract method
                a.sleep();  // Call the regular method

            //object craetion for Piginterface

            Piginterface b = new Piginterface();  // Create a Pig object
            b.animalSound();

            //object creation for mutiple interfaces
            DemoClass c = new DemoClass();
            c.animalSound();
            c.message();

          //call enum values
            //below gives default value with first element as 0
            int myNum1 = (int)Months.January;
            Console.WriteLine(myNum1);

            //You can also assign your own enum values, and the next items will update the number accordingly:
            //the output will be displayed based on value passed for march
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            //enum can als be used in switch
            //creating an instance and assigning the switch value
            Months myNum2 = Months.March;
            //based on above switch value,the respective case executes
            switch (myNum2)
            {
                case Months.April:
                    Console.WriteLine("its april");
                    break;
                case Months.March:
                    Console.WriteLine("Its march");
                    break;

                   }
            //Working With Files
            //we need to use "using System.IO";  // include the System.IO namespace

            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            //use of conts keyword allows u to not to overwritr the value
            const int myNm = 15;
            //below throws error
            //myNm = 20;

            //default is impllicit casting-passing a smaller size type to a larger size type
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //below z explicit casting-passing a large size type to a smaller size type
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9


            //use of index of and substring ex
            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}
//



