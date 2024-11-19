public class dt{
    public static void run(){
        double rate = 23000; 
        Console.Write("Nhập số tiền (USD): ");
        double usd = Convert.ToDouble(Console.ReadLine());
        double vnd = usd * rate;
        Console.WriteLine($"{usd} USD = {vnd} VND");
    }
}