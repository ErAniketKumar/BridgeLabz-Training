decimal x = int.MaxValue;

int y = 10;
int z = 20;

int res = checked(y + z);

int d = int.MaxValue;

int p = d+1;

int q = checked(d+1);

System.Console.WriteLine(q);;