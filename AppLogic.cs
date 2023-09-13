using System.Reflection;

namespace sdc1_knowledge_check_2
{
    public class AppLogic
    {
        private string AssignProperyValue(string answer, PropertyInfo propertyInfo, AleEightOne ale)
        {
            if (answer == "y") { propertyInfo.SetValue(ale, true); }
            else if (answer == "n") { propertyInfo.SetValue(ale, false); }
            else { Console.WriteLine("Invalid input."); }
            return answer;
        }
        private string GetPropertyValues(List<AleEightOne> recordList, AleEightOne ale, string propertyName)
        {
            PropertyInfo propertyInfo = typeof(AleEightOne).GetProperty(propertyName);
            Console.Write($"Record #{recordList.Count() + 1}: {propertyName}? Enter y/n: ");
            string answer = Console.ReadLine().ToLower();

            return AssignProperyValue(answer, propertyInfo, ale);
        }
        public void GetUserInput(string input, AppLogic app, List<AleEightOne> recordList, AleEightOne myClass, string propertyName)
        {
            while (input != "y" && input != "n") { input = app.GetPropertyValues(recordList, myClass, propertyName); }
        }
    }
}
