

Calculator calculator = new Calculator();

System.Console.WriteLine(calculator.Add(10, 20));
System.Console.WriteLine(calculator.Add(10.4, 20.5));
System.Console.WriteLine(calculator.Add(100.55d, 20.59d));



MaximumValueArray maximumValueArray = new MaximumValueArray();
System.Console.WriteLine(maximumValueArray.FindMaxValue([10, 20, 30, 15]));
System.Console.WriteLine(maximumValueArray.FindMaxValue([10.4, 20.9, 30.8]));


EmployeeOpr employee = new EmployeeOpr();

employee.Add(1, "Aniket");
employee.Add(2, "Kumar");
employee.Search(2);
employee.Remove(1);
employee.PrintEmpDetails();





SortListDecending sortListDecending = new SortListDecending();

List<int> list = new List<int>();
list.Add(20);
list.Add(10);
list.Add(30);
list.Add(40);
list.Add(20);
list.Add(15);

sortListDecending.sortListDesc(list);





BankingCustomeExcp bankingCustomeExcp = new BankingCustomeExcp();

bankingCustomeExcp.Deposite(200);
bankingCustomeExcp.Withdraw(1000);




NthIteration nthIteration = new NthIteration();
nthIteration.NthIterationPrint(6);



List<List<int>> list2 = new List<List<int>>();
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int start = Convert.ToInt32(Console.ReadLine());
    int end = Convert.ToInt32(Console.ReadLine());

    list2.Add([start, end]);
}
TimeSlotCalculator timeSlotCalculator = new TimeSlotCalculator();
timeSlotCalculator.Appointments(list2);






LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
int nn = Convert.ToInt32(Console.ReadLine());
List<string> list3 = new List<string>();

for (int i = 0; i < nn; i++)
{
    string s = Convert.ToString(Console.ReadLine());
    list3.Add(s);
}

longestCommonPrefix.LCP(list3);




SortListByNameAndAge sortListByNameAndAge = new SortListByNameAndAge();
sortListByNameAndAge.AddStudent("Aniket", 20);
sortListByNameAndAge.AddStudent("Kumar", 19);
sortListByNameAndAge.AddStudent("Abhishek", 29);

sortListByNameAndAge.SortList();




EmailValidator emailValidator = new EmailValidator();
emailValidator.IsValidEamilFormat("aniket@gmai.com");



PasswordSraingthChecker passwordSraingthChecker = new PasswordSraingthChecker();
passwordSraingthChecker.PasswordCheck("Aniket@123");
