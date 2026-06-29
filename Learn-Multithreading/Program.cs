//void MultithreadingMethod1()
//{
//    for(int i =1;i<=100;i++)
//    {
//       Console.WriteLine("method 1st, id: "+ Thread.CurrentThread.ManagedThreadId);
//    }
//}


//void MultithreadingMethod2()
//{
//    for (int i = 1; i <= 100; i++)
//    {
//        Console.WriteLine("method 2nd, id: " + Thread.CurrentThread.ManagedThreadId);
//    }
//}

//Thread thread1 = new Thread(MultithreadingMethod1);
//thread1.Start();

//Thread thread2 = new Thread(MultithreadingMethod2);
//thread2.Start();


// creatin thread 3 ways

//1 first

//void m1()
//{
//    Console.WriteLine(Thread.CurrentThread.Name);
//}

//Thread t1 = new Thread(m1);
//t1.Name = "Method 1";

//t1.Start();

//// 2nd ways anomous method

//Thread t2 = new Thread(() =>
//{
//    Console.WriteLine(Thread.CurrentThread.Name);
//});

//t2.Name = "method 2";

//t2.Start();

//// 3rd ways lamdba

//new Thread(() =>
//{
//    Console.WriteLine("Method 3");
//}).Start();





//int start = int.Parse(Console.ReadLine());
//int end =  int.Parse(Console.ReadLine());

//void printSum(int start, int end)
//{
//    int sum = 0;
//    for(int i= start;i<=end;i++)
//    {
//        sum += i;
//    }

//    Console.WriteLine(sum);
//}

//void printSumAvd(int start,int end)
//{
//    int sum = 0;
//    int count = 0;
//    for (int i = start; i <= end; i++)
//    {
//        sum += i;
//        count++;
//    }

//    Console.WriteLine(sum / count);
//}

//Thread t1 = new Thread(()=> printSum(start, end));
//t1.Start();

//Thread t2 = new Thread(()=> printSumAvd(start, end));

//t2.Start();

//t1.Join();
//t2.Join();


using Learn_Multithreading.M1;

Example1 ex1 = new Example1();

Thread t1 = new Thread(ex1.Increment);

Thread t2 = new Thread(ex1.Increment);

t1.Name = "thread 1";
t2.Name = "thread 2";

t1.Start();
t2.Start();

t1.Join();
t2.Join();


