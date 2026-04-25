using System.Drawing;
using ReviewFIRST.AbstractClass;
using ReviewFIRST.Basic;
using ReviewFIRST.InterfaceProgram;


// question one 
SwapNumber swapNumber = new SwapNumber();

int x;
int y;

bool num1 = int.TryParse(Console.ReadLine(), out x);
bool num2 = int.TryParse(Console.ReadLine(), out y);

List<int> list = swapNumber.SwapTwoNum(x, y);

for (int i = 0; i < list.Count; i++)
{
    System.Console.WriteLine(list[i]);
}



// question two
StringReverse strev = new StringReverse();

string str = Console.ReadLine();

str = strev.ReverseString(str);

System.Console.WriteLine(str);




// question three
ArmStrongNum armnum = new ArmStrongNum();

int num;
bool armint = int.TryParse(Console.ReadLine(), out num);

if (armnum.CheckArmStrongNum(num))
{
    System.Console.WriteLine("true");
}
else
{
    System.Console.WriteLine("false");
}


// question 8
Dice dice = new Dice();

dice.DiceThrow();




// question nine
RandomEven randomEven = new RandomEven();

randomEven.RandomEvenNumber();



// question 10

TwoNumLargeAndSmall largeSmall = new TwoNumLargeAndSmall();

int one;
int two;

bool ch = int.TryParse(Console.ReadLine(), out one);
bool ch2 = int.TryParse(Console.ReadLine(), out two);

largeSmall.LargeSmall(one, two);

// question 6
AddDate adddate = new AddDate();
adddate.DateAdd();



// question 7
DiffrenceDate diffrenceDate = new DiffrenceDate();
TimeSpan ts = diffrenceDate.DateTimeDiff(DateTime.Now, (DateTime.Now.AddMonths(-6)));

System.Console.WriteLine(ts);





// question five

ReviewFIRST.AbstractClass.Rectangle rc = new ReviewFIRST.AbstractClass.Rectangle(10, 20);

Circle circle = new Circle(10);


ContractEmployee ctemp = new ContractEmployee();

FullTimeEmployee ftemp = new FullTimeEmployee();