using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Konsol ekranına 10 kere aynı mesajı yazdırma
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            count++;
        }

        // 2. 1 ile 20 arasındaki sayıları yazdırma
        Console.WriteLine("\n1 ile 20 arasındaki sayılar:");
        int num = 1;
        while (num <= 20)
        {
            Console.WriteLine(num);
            num++;
        }

        // 3. 1 ile 20 arasındaki çift sayıları yazdırma
        Console.WriteLine("\n1 ile 20 arasındaki çift sayılar:");
        int evenNum = 2;
        while (evenNum <= 20)
        {
            Console.WriteLine(evenNum);
            evenNum += 2;
        }

        // 4. 50 ile 150 arasındaki sayıların toplamı
        Console.WriteLine("\n50 ile 150 arasındaki sayıların toplamı:");
        int sum = 0;
        int sumNum = 50;
        while (sumNum <= 150)
        {
            sum += sumNum;
            sumNum++;
        }
        Console.WriteLine(sum);

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamları
        int oddSum = 0;
        int evenSum = 0;
        int i = 1;

        while (i <= 120)
        {
            if (i % 2 == 0)
            {
                evenSum += i;
            }
            else
            {
                oddSum += i;
            }
            i++;
        }

        Console.WriteLine($"\n1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");
    }
}
