using System;
class PhotoPictures
{
    static void Main()
    {
        int numberOfPictures = int.Parse(Console.ReadLine());
        string typePictures = Console.ReadLine();
        string typeOrder = Console.ReadLine();

        double price = 0;

        double discount = 1;
        bool hasDiscount = false;
        switch (typePictures)
        {
            case "9X13":
                price = 0.16;

                if (numberOfPictures >= 50)
                {
                    discount = 0.05;
                    hasDiscount = true;
                }
                break; 
            case "10X15":
                price = 0.16;

                if (numberOfPictures >= 80)
                {
                    discount = 0.03;
                    hasDiscount = true;
                }
                break;
            case "13X18":
                price = 0.38;

                if (numberOfPictures >= 50 && numberOfPictures <= 100)
                {
                    discount = 0.03;
                    hasDiscount = true;
                }
                else
                {
                    discount = 0.05;
                    hasDiscount = true;
                }
                break;
            case "20X30":
                price = 2.90;

                if (numberOfPictures >= 10 && numberOfPictures <= 50)
                {
                    discount = 0.07;
                    hasDiscount = true;
                }
                else
                {
                    discount = 0.09;
                    hasDiscount = true;
                }
                break;
        }

        double totalPrice = numberOfPictures * price;
        double result = totalPrice;

        if (hasDiscount)
        {
            result = totalPrice - (totalPrice * discount);
        }

        if (typeOrder == "online")
        {
            result -= result * 0.02;
        }
        Console.WriteLine($"{Math.Abs(result):f2}BGN");
    }
}

