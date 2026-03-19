using System.Text;

namespace bài_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            var evenNumbers = numbers.Any(x => x > 10);
            Console.WriteLine("Có số lớn hơn 10 không?: " +evenNumbers);
            Console.ReadKey();
        }
    }
}
