using System.Text;

namespace bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var evenNumbers = numbers.Where(n => n > 5);
            Console.WriteLine("Các số lớn hơn 5: " + string.Join(", ", evenNumbers));
            Console.ReadKey();
        }
    }
}
