namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        //Hàm tính chỉ số Bmi
        //BMI = cân nặng (kg) / (chiều cao (m) * chiều cao (m))
        //Nếu BMI từ 18.5 - 24.9 -> chuẩn form
        static void GetBmi()
        {
            double weight = 70;
            double height = 1.7;
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI (w: {weight}, h: {height}, {bmi}");
        }
    }
}
