using System;
class Vacation
{
    static void Main()
    {
        int countOldPeople = int.Parse(Console.ReadLine());
        int countStudents = int.Parse(Console.ReadLine());
        int countNights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();
    
        if (transport == "train")
        {
            double costsOldPeople = countOldPeople * 24.99;
            double costStudents = countStudents * 14.99;

            double sum = (costsOldPeople + costStudents) * 2;

            double hotel = countNights * 82.99;

            double commision = (sum + hotel) * 0.10;
            double totalSum = sum + hotel + commision;

            if (countOldPeople >= 50)
            {
                costsOldPeople -= 0.50;
            }
            if (countStudents >=50)
            {
                costStudents -= 0.50;
            }

            Console.WriteLine("{0:f2}", totalSum);

        }
        else if(transport == "bus")
        {
            double costsOldPeople = countOldPeople * 32.50;
            double costStudents = countStudents * 28.50;
            double sum = (costsOldPeople + costStudents) * 2;

            double hotel = countNights * 82.99;

            double commision = (sum + hotel) * 0.10;
            double totalSum = sum + hotel + commision;
            Console.WriteLine("{0:f2}", totalSum);

        }
        else if(transport == "boat")
        {
            double costsOldPeople = countOldPeople * 42.99;
            double costStudents = countStudents * 39.99;

            double sum = (costsOldPeople + costStudents) * 2;
            double hotel = countNights * 82.99;

            double commision = (sum + hotel) * 0.10;
            double totalSum = sum + hotel + commision;
            Console.WriteLine("{0:f2}" , totalSum);
        }
        else
        {
            double costsOldPeople = countOldPeople * 70.00;
            double costStudents = countStudents * 50.00;

            double sum = (costsOldPeople + costStudents) * 2;
            double hotel = countNights * 82.99;

            double commision = (sum + hotel) * 0.10;
            double totalSum = sum + hotel + commision;
            Console.WriteLine("{0:f2}" , totalSum);
        }
    }
}

