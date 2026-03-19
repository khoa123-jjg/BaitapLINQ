using System.Text;

namespace bài_14
{
    namespace bài_12
    {
        class Student
        {
            public int Id { get; set; }
            public string name;
            public Double score;
            public Student(int Id, string name, Double score)
            {
                this.Id = Id;
                this.name = name;
                this.score = score;
            }
            public void In()
            {
                Console.WriteLine("Id: " + Id + " Name: " + name + " Score: " + score);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Phạm Nhật Khoa");
                Console.WriteLine("2415053122221");
                List<Student> students = new List<Student>()
            {   new Student (1,"An",8),
                new Student (2,"Binh",6 ),
                new Student (3,"Chi",9 ),
                new Student (4,"Dung",7 )
            };
                var student = students.Any(s => s.score <5);
                Console.WriteLine("Có sinh viên rớt không (<5)? "+student);
                Console.ReadKey();
            }
        }
    }
}
