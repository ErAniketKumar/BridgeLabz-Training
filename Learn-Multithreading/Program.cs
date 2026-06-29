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

void m1()
{
    Console.WriteLine(Thread.CurrentThread.Name);
}

Thread t1 = new Thread(m1);
t1.Name = "Method 1";

t1.Start();

// 2nd ways anomous method

Thread t2 = new Thread(() =>
{
    Console.WriteLine(Thread.CurrentThread.Name);
});

t2.Name = "method 2";

t2.Start();

// 3rd ways lamdba

new Thread(() =>
{
    Console.WriteLine("Method 3");
}).Start();


 