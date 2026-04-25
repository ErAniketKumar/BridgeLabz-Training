using ReviewFIRST.Basic;

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



StringReverse strev = new StringReverse();

string str = Console.ReadLine();

str = strev.ReverseString(str);

System.Console.WriteLine(str);


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



Dice dice = new Dice();

dice.DiceThrow();

RandomEven randomEven = new RandomEven();

randomEven.RandomEvenNumber();


TwoNumLargeAndSmall largeSmall = new TwoNumLargeAndSmall();

int one;
int two;

bool ch = int.TryParse(Console.ReadLine(), out one);
bool ch2 = int.TryParse(Console.ReadLine(), out two);

largeSmall.LargeSmall(one, two);



AddDate adddate = new AddDate();
adddate.DateAdd();