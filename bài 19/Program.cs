using System.Text;

namespace bài_19
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
            var number = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => 
                new { 
                    so = g.Key, 
                    Count = g.Count()
                }).Take(1);
            Console.WriteLine("Số xuất hiện nhiều lần nhất: ");
            foreach (var item in number)
            {
                Console.WriteLine ("Số: {0,-2} Count: {1}   ",item.so, item.Count);
            }
            Console.ReadKey();
        }
    }
}
