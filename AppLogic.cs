using System.Reflection;

namespace sdc1_knowledge_check_2
{
    public class AppLogic
    {
        public string AddValues(List<AleEightOne> recordList, string answer, AleEightOne obj, string propertyName)
        {
            PropertyInfo propertyInfo = typeof(AleEightOne).GetProperty(propertyName);
            Console.Write($"Record #{recordList.Count() + 1}: {propertyName}? Enter y/n: ");
            answer = Console.ReadLine().ToLower();

            if (answer == "y") { propertyInfo.SetValue(obj, true); }
            else if (answer == "n") { propertyInfo.SetValue(obj, false); }
            else { Console.WriteLine("Invalid input."); }
            return answer;
        }
        public void GetUserInput(string input, AppLogic app, List<AleEightOne> recordList, AleEightOne myClass, string propertyName)
        {
            while (input != "y" && input != "n") { input = app.AddValues(recordList, input, myClass, propertyName); }
        }
    }
}
