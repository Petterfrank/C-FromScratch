namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob1", 31, "Ally",  null, new DateTime (1993,1,1));
            Person person2 = new Person("Bob2", 32, "Ally", null, new DateTime(1993, 1, 1));
            Person person3 = new Person("Bob3", 33, "Ally", null, new DateTime(1993, 1, 1));
            
            person1.Introduce();
            person2.Introduce();
            person3.Introduce();
        }

    }
    public class Person
    {
        //autoimplemented properties
        public string Name { get; set; } = string.Empty;

        // full property with backing field and validation
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                _age = value;
            }
        }
        //Property with default value
        public string Nickname { get; set; } = "No nickname";

        //Nullable Property
        public int? Couple { get; set; } = null;

        //Read-Only Property
        public readonly DateTime BirthDate = DateTime.Now;

        //Static Property
        public static int Population { get; private set; } = 0;
        //constructor
        public Person()
        {  if (this.Name.Length == 0)
            {
                this.Name = "Unknown";
            }
            Population++;
        }

        public Person(string name, int _age, string nickname, int? couple, DateTime birthDate)
        {
            Name = name;
            Age = _age;
            Nickname = nickname;
            Couple = couple;
            BirthDate = birthDate;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I'm {Age} years old. My nickname is {Nickname}. I was born on {BirthDate.ToShortDateString()}");
        }
    }
}

    

