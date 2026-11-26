//The concepts of OOP in C#
namespace StudentCase
{
    public class Computer
    {
        public string _BIOSname;
        public string _ipadress;
        public string _OS;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
        }
    }

    public class Student
    {
        public int _id;
        public string _name;
        public string _faculty;
        public int _ageStudy;

        public Student(string name, int ageStudy, string faculty, int id)
        {
            _name = name;
            _ageStudy = ageStudy;
            _faculty = faculty;
            _id = id;
        }
        public Student() { }

    }
    ///one comment
    //new comment
    class Program
    {

        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }


        public static void Main(string[] args)
        {

            Computer[] net = new Computer[4];

            for (int i = 0; i < net.Length; i++)
            {
                net[i] =
                  new Computer("comp" + i.ToString(),
                        "10.0." + getNum() + "." + getNum(), "Win10");
            }

            net[0] = new Computer("server", "10.0.0.10", "Linux");
            net[1] = new Computer("graphics station", "10.0.0.10", "Linux");


            for (int i = 0; i < net.Length; i++)
            {
                Console.WriteLine("{0} {1}", net[i]._BIOSname, net[i]._ipadress);
            }
            Console.WriteLine("-------------------------------------------------");

            //---------------------------------------//

            Student[] students = new Student[7];

            students[0] = new Student("Kerem", 2, "Computer Programming", 100);
            students[1] = new Student("Muhammet", 2, "Computer Programming", 101);
            students[2] = new Student("Defne", 4, "Engineering", 104);
            students[3] = new Student("Efe", 2, "Computer Programming", 102);
            students[4] = new Student("Dilara", 2, "Turizm", 103);
            students[5] = new Student("Mert", 2, "Computer Science", 105);
            students[6] = new Student();
            students[6]._id = 400;
            students[6]._name = "Ahmet";




            /*
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Student" + i.ToString(), 20 + i, "Computer Science", 1000 + i);
            }
            */


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Students:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0, -15} {1, 5} {2, -25} {3, 5}", students[i]._name, students[i]._ageStudy, students[i]._faculty, students[i]._id);
            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students in Computer Programming:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._faculty == "Computer Programming")
                {
                    Console.WriteLine("{0, -15} {1, 5} {2, -25} {3, 5}", students[i]._name, students[i]._ageStudy, students[i]._faculty, students[i]._id);
                }
            }


        }
    }
}