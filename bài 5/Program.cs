using System.Text;

namespace bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> numbers = new List<int> { 1,2,3,4};
            var evenNumbers = from n in numbers
                              select n*n;
            Console.WriteLine("Sắp xếp từ lớn đến bé: " + string.Join(", ", evenNumbers));
            Console.ReadKey();
        }
    }
}
