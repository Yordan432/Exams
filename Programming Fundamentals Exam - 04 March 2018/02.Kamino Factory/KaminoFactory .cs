using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class SequenceOnes
{
    public string Sequence { get; set; }
    public int StartIndex { get; set; }
    public int Length { get; set; }
    public int Sum { get; set; }
}
class KaminoFactory
{
    static void Main()
    {
        // Find sequence ones
        // in Class SequenceOnes store sequence,startIndex,Length and sum,but
        // not work correctyly now

        int lengthSequences = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        List<SequenceOnes> ones = new List<SequenceOnes>();
        while (line != "Clone them!")
        {
            string[] items = line.Split('!');
            SequenceOnes sequenceOne = new SequenceOnes();
            bool isFindSequenceEqual = FindSequenceEqual(items, sequenceOne);
            if (isFindSequenceEqual)
            {
                sequenceOne.Sequence = string.Join("", items);
                ones.Add(sequenceOne);
            }
            line = Console.ReadLine();
        }
    }

    private static bool FindSequenceEqual(string[] items,
        SequenceOnes storeDataSeqence)
    {
        bool isFindEqual = false;
        int index = 0;
        while (index < items.Length - 1)
        {
            var firstSymbol = items[index];
            var secondSymbol = items[index + 1];

            if (firstSymbol == "1" && secondSymbol == "1")
            {
                storeDataSeqence.StartIndex = index;
                isFindEqual = true;
                int length = FindLengthOnes(items);
                int sum = FindSum(items);
                storeDataSeqence.Length = length;
                storeDataSeqence.Sum = sum;
                break;
            }
            index++;
        }
        return isFindEqual;
    }

    private static int FindSum(string[] items)
    {
        int sum = 0;
        foreach (var item in items)
        {
            if (item == "1")
            {
                sum += int.Parse(item);
            }
        }
        return sum;
    }

    private static int FindLengthOnes(string[] items)
    {
        int length = 1;
        int currentLength = 1;
        for (int i = 0; i < items.Length - 1; i++)
        {
            if (items[i] == "1" && items[i + 1] == "1")
            {
                currentLength++;
            }
        }
        if (currentLength > length)
        {
            length = currentLength;
        }

        return length;
    }
}

