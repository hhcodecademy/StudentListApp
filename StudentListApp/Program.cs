using System.Text;

namespace StudentListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer = 'N';
            StringBuilder studentList = new StringBuilder();
            do
            {
                Console.WriteLine("Telebin adini daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Telebin qiymetini daxil edin");
                float point = float.Parse(Console.ReadLine());
                Console.WriteLine("Yeni telebe varmi (y/n)");
                answer = char.Parse(Console.ReadLine());

                string studenInfo = $"{name} - {point}";
                studentList.AppendLine(studenInfo);
            } while (answer=='y');

            Console.WriteLine("Telebelerin siyahisi:");
            Console.WriteLine(studentList);
        }
    }
}