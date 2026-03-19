using System.Text;

namespace bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> numbers = new List<int> { 7, 2, 12, 4, 33, 9, 7, 0 };
            var evenNumbers = from n in numbers 
                              orderby n
                              select n;
            Console.WriteLine("Sắp xếp từ bé đến lớn: " + string.Join(", ", evenNumbers));
            Console.ReadKey();
        }
    }
}
