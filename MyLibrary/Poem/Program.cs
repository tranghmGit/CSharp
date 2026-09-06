
using Poem.SongCode;

namespace Poem
{
    internal class Program
    {
        int yob = 2004; //Khai báo biến C# dùng cú pháp con Lạc Đà - camel Case Notation
                        //Ex: salary, basicSalary,...
        static void Main(string[] args)
        {
            PrintPoem();
            Verbatim();        
            XuanQuynh.PrintSongCode();
        }
        static void PrintPoem()
        {
            int year = 2026;
            int month = 5;
            Console.WriteLine(" Year: " + year);  //Ghép chuỗi theo kiểu truyền thống
            Console.WriteLine(" Month: {0}| Year: {1}", month, year);  //Ghép chuỗi theo kiểu định dạng của C - Placeholder
            Console.WriteLine($" Month: {month}| Year: {year}"); // Ghép chuỗi theo kiểu Interpolation của C# 6.0 trở lên -> nội suy giá trị biến trong chuỗi -> viết code tự nhiên hơn 

            //Console.WriteLine("This is a simple poem:");
            //Console.WriteLine("Roses are red,");
            //Console.WriteLine("Violets are blue,");
            //Console.WriteLine("Sugar is sweet,");
            //Console.WriteLine("And so are you.");

            //Ctrl + K + C -> Comment code
            //Ctrl + K + U -> UnComment code


            //@: có gì in đó
            Console.WriteLine(@"    
            This is a simple poem:

                Roses are red
                Violets are blue
                Sugar is sweet
                And so are you");
        }
        static void Verbatim()  //Verbatim String Literal - Chuỗi ký tự nguyên văn
        {
            string path = @"E:\CSharp\";
            Console.WriteLine();
            Console.WriteLine($"Get verbatim path: {path}");
        }

    }
}
