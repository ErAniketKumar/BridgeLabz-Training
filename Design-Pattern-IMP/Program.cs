
using Design_Pattern_IMP.Creational;

Logger lg1 = Logger.GetInstance();
Logger lg2 = Logger.GetInstance();

Console.WriteLine(lg1==lg2);