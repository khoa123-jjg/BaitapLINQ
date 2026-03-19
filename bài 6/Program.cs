using System.Text;

namespace bài_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> numbers = new List<int> { 7, 2, 12, 4, 33, 9, 7, 6 };
            var evenNumbers = numbers.Where(n=> n%2==0).Count();
            Console.WriteLine("Số phần tử chẵn: " + evenNumbers);
            Console.ReadKey();
        }
    }
}
