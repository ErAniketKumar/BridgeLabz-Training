void MultithreadingMethod1()
{
    for(int i =1;i<=100;i++)
    {
       Console.WriteLine("method 1st, id: "+ Thread.CurrentThread.ManagedThreadId);
    }
}



void MultithreadingMethod2()
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine("method 2nd, id: " + Thread.CurrentThread.ManagedThreadId);
    }
}

Thread thread1 = new Thread(MultithreadingMethod1);
thread1.Start();

Thread thread2 = new Thread(MultithreadingMethod2);
thread2.Start();