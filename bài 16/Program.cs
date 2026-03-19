using System.Text;

namespace bài_16
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
            var number = numbers.Sum();
            Console.WriteLine("Tổng các phần tử: "+ number);
            Console.ReadKey();
        }
    }
}
