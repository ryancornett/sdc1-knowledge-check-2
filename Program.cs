using sdc1_knowledge_check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<AleEightOne>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new AleEightOne();

    string userInputOne = "";
    while (userInputOne != "y" && userInputOne != "n")
    {
        Console.Write($"Record #{recordList.Count() + 1}: Delicious? Enter y/n: ");
        userInputOne = Console.ReadLine().ToLower();
        if (userInputOne == "y") { myClass.Delicious = true; }
        else if (userInputOne == "n") { myClass.Delicious = false; }
        else { Console.WriteLine("Invalid input."); }
    }
    
    string userInputTwo = "";
    while (userInputTwo != "y" && userInputTwo != "n")
    {
        Console.Write($"Record #{recordList.Count() + 1}: Citrusy? Enter y/n: ");
        userInputTwo = Console.ReadLine().ToLower();
        if (userInputTwo == "y") { myClass.Citrusy = true; }
        else if (userInputTwo == "n") { myClass.Citrusy = false; }
        else { Console.WriteLine("Invalid input."); }
    }
    
    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine();
foreach (var record in recordList)
{
    Console.WriteLine($"Record #{recordList.IndexOf(record) + 1} - {nameof(record.Delicious)}: {record.Delicious}, {nameof(record.Citrusy)}: {record.Citrusy}");
}
