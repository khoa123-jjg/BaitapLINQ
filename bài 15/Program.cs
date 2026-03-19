using System.Text;

namespace bài_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> list = new List<int>() { 1,2,2,3,4,4,5};
            var distinctList = list.Distinct();
            Console.WriteLine("List sau khi bỏ phần tử trùng: "+string.Join(", ",distinctList));
            Console.ReadKey();
        }
    }
}
