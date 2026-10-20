namespace Enums
{
    //public struct IceCream
    //{
    //    public string name;
    //    public string manufacturer;
    //    public string flavour;
    //    public double cost;
    //    public int iceCreamCount;
    //}

    public struct Animal
    {
        public string animalCode;
        public string specieName;
        public string foodType;
        public double kilogramsPerMeal;
        public int howManyFeedingTimes;
    }

    public struct Student
    {
        public string firstName;
        public string lastName;
        public string interest;
        public int score;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 3 - Create a zoo program that uses an array of structs
            //A. A zookeeper requires a program for managing feeding information. It needs
            //to be kept for a maximum of 10 animals. Each animal has an identity code
            //(six characters), a species name (20 characters), needs a type of food
            //(20 characters), eats a certain kilograms per meal, and must be fed up to
            //six times a day
            //int animalCount = 0;

            //while (animalCount < 1 || animalCount > 10 )
            //{
            //    Console.Write("How many animal entries would you write: ");
            //    animalCount = int.Parse(Console.ReadLine());

            //    if(animalCount < 1 || animalCount > 10)
            //    {
            //        Console.WriteLine("Invalid input! Please write between 1 and 10!");
            //    }
            //}
            
            //Animal[] zoo = new Animal[animalCount];
            
            //for (int i = 0; i < zoo.Length; i++)
            //{
            //    Console.Write("Enter the animal code: ");
            //    zoo[i].animalCode = Console.ReadLine();
            //    Console.Write("Enter the animal name: ");
            //    zoo[i].specieName = Console.ReadLine();
            //    Console.Write("Enter food type: ");
            //    zoo[i].foodType = Console.ReadLine();
            //    Console.Write("Enter kilograms per meal: ");
            //    zoo[i].kilogramsPerMeal = int.Parse(Console.ReadLine());
            //    Console.Write("Enter how many times fed: ");
            //    zoo[i].howManyFeedingTimes = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i < zoo.Length; i++)
            //{
            //    Console.WriteLine($"Animal Code: {zoo[i].animalCode}");
            //    Console.WriteLine($"Animal Name: {zoo[i].specieName}");
            //    Console.WriteLine($"Food Type: {zoo[i].foodType}");
            //    zoo[i].kilogramsPerMeal *= zoo[i].howManyFeedingTimes;
            //    Console.WriteLine($"Total Kilograms per day: {zoo[i].kilogramsPerMeal}");
            //}

            //Console.ReadLine();

            Student[] student = new Student[3];
            //Try writing the data entry program. I am going to write to create your assignment.
            //There are the fiels
            //first name, last name, interest
            //Enter three members of our class into the array. Loop through them printing them
            //out attractively on the screen

            for(int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} information");
                Console.Write("Enter first name: ");
                student[i].firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                student[i].lastName = Console.ReadLine();
                Console.Write("Enter interest: ");
                student[i].interest = Console.ReadLine();
                Console.Write("Enter score: ");
                student[i].score = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("Student Number".PadRight(20));
            Console.Write("First Name".PadRight(20));
            Console.Write("Last Name".PadRight(20));
            Console.Write("Interest".PadRight(20));
            Console.WriteLine("Score".PadRight(20));
            for(int i = 0; i < student.Length; i++)
            {
                Console.Write($"{i + 1}".PadRight(20));
                Console.Write($"{student[i].firstName}".PadRight(20));
                Console.Write($"{student[i].lastName}".PadRight(20));
                Console.Write($"{student[i].interest}".PadRight(20));
                Console.WriteLine($"{student[i].score}".PadRight(20));
            }
            Console.ReadLine();
        }
    }
}
