using sdc1_knowledge_check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<AleEightOne>();
AppLogic appLogic = new AppLogic();
for (int i = 0; i < numberOfRecords; i++)
{
    var myClass = new AleEightOne();
    string userInput = "";
    appLogic.GetUserInput(userInput, appLogic, recordList, myClass, "Delicious");

    userInput = "";
    appLogic.GetUserInput(userInput, appLogic, recordList, myClass, "Citrusy");

    recordList.Add(myClass);
    Console.WriteLine($"Record #{recordList.Count()} added successfully.");
    Console.WriteLine();
}

foreach (var record in recordList)
{
    Console.WriteLine($"Record #{recordList.IndexOf(record) + 1} - {nameof(record.Delicious)}: {record.Delicious}, {nameof(record.Citrusy)}: {record.Citrusy}");
}