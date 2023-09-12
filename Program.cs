using sdc1_knowledge_check_2;

bool properInput = false;
int result = 0;
while (properInput == false)
{
    Console.WriteLine("How many records do you want to add? ");
    string numberOfRecords = Console.ReadLine();
    if (Int32.TryParse(numberOfRecords, out result)) { properInput = true; }
    else { Console.WriteLine("Invalid input."); }
}

var recordList = new List<AleEightOne>();
AppLogic appLogic = new AppLogic();
for (int i = 0; i < result; i++)
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