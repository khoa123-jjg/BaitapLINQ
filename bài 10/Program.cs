using System.Text;

namespace bài_10
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
            var student = from s in students
                          orderby s.score descending
                          select s;
            Console.WriteLine("Sắp xếp theo điểm giảm dần: ");
            foreach (var s in student)
            {
                s.In();
            }
            Console.ReadKey();
        }
    }
}
