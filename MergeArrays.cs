using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class MergeArrays
{
    public string[] names1 = new string[] { "Ava", "Peppa", "Charlie", "Ava", "Peppa", "Charlie", "Ava", "Peppa", "Charlie" };
    public string[] names2 = new string[] { "Ava", "Ann" };

    public void UniqueNames()
    {
        MerageAndRemoveDuplicates(names1, names2);
    }
    public void MerageAndRemoveDuplicates(string[] array1, string[] array2)
    {
        var combinedArray = new string[names1.Length + names2.Length + 5];
        names1.CopyTo(combinedArray, 0);
        names2.CopyTo(combinedArray, names1.Length);

        Console.Write("Merged array: ");
        for (int i = 0; i < combinedArray.Length; i++)
        {
            Console.WriteLine(combinedArray[i]);
        }

        var uniqueArray = combinedArray.Distinct();

        Console.Write("uniqueArray: ");
        foreach (string name in uniqueArray)
        {
            Console.WriteLine(name);
        }

    }

    public IEnumerable<string> MerageAndRemoveDuplicatesUsingCollections(string[] array1, string[] array2)
    {
        HashSet<string> distinctNames = new HashSet<string>(names1);

        return distinctNames.Concat(names2);
    }

    public void TestMerageAndRemoveDuplicatesUsingCollections()
    {
        IEnumerable<string> hashNames = MerageAndRemoveDuplicatesUsingCollections(names1, names2);

        Console.WriteLine("Using Collections: " + String.Join(",", hashNames));

    }
}


