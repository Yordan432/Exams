using System;
class Program
{
    static void Main()
    {
        string formOfEducationForBeforehand = Console.ReadLine();
        int numberOfRecorderBeforehand = int.Parse(Console.ReadLine());

        string formOfEducationForNormal = Console.ReadLine();
        int numberOfRecorderNormal = int.Parse(Console.ReadLine());

        string formOfEducationForLater = Console.ReadLine();
        int numberOfRecorderLater = int.Parse(Console.ReadLine());

        int maxCapacityInHall = 600;

        int totalOnlineStudents = 0;
        int totalOnsiteStudents = 0;
        int totalStudents = 0;
        int currentRecordOnsiteStudents = 0;

        if (formOfEducationForBeforehand == "onsite")
        {
            if (numberOfRecorderBeforehand <= maxCapacityInHall)
            {
                totalOnsiteStudents += numberOfRecorderBeforehand;
                currentRecordOnsiteStudents += numberOfRecorderBeforehand;
            }
            else
            {
                int remainderOnsite = maxCapacityInHall % numberOfRecorderBeforehand;
                int remanderOnline = numberOfRecorderBeforehand - remainderOnsite;

                totalOnsiteStudents += remainderOnsite;
                currentRecordOnsiteStudents += remainderOnsite;
                totalOnlineStudents += remanderOnline;
            }
        }
        else
        {
            totalOnlineStudents += numberOfRecorderBeforehand;
        }
        if (formOfEducationForNormal == "onsite")
        {
            if (currentRecordOnsiteStudents + numberOfRecorderNormal <= maxCapacityInHall)
            {
                totalOnsiteStudents += numberOfRecorderNormal;
                currentRecordOnsiteStudents += numberOfRecorderNormal;
            }
            else
            {
                int remainderOnline = numberOfRecorderNormal % 10;
                int remanderOnsite = numberOfRecorderNormal - remainderOnline;
                totalOnlineStudents += remainderOnline;
                totalOnsiteStudents += remanderOnsite;
                currentRecordOnsiteStudents += remanderOnsite;
            }
        }
        else
        {
            totalOnlineStudents += numberOfRecorderNormal;
        }
        if (formOfEducationForLater == "onsite")
        {
            if (currentRecordOnsiteStudents + numberOfRecorderLater <= maxCapacityInHall)
            {
                totalOnsiteStudents += numberOfRecorderLater;
                currentRecordOnsiteStudents += numberOfRecorderLater;
            }
            else
            {
                int remainderOnsite = numberOfRecorderLater % 10;
                int remainderOnline = numberOfRecorderLater - remainderOnsite;
                totalOnsiteStudents += remainderOnsite;
                totalOnlineStudents += remainderOnline;
            }
        }
        else
        {
            totalOnlineStudents += numberOfRecorderLater;
        }

        
        totalStudents = totalOnlineStudents + totalOnsiteStudents;
        Console.WriteLine($"Online students: {totalOnlineStudents}");
        Console.WriteLine($"Onsite students: {totalOnsiteStudents}");
        Console.WriteLine($"Total students: {totalStudents}");
    }
}

