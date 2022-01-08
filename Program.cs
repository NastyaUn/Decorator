using Decorator;
DynamicSystem ds1 = new LogisticMapping();
ds1 = new TransitionProcess(ds1);
Console.WriteLine(ds1.NameSystem);
DynamicSystem ds2 = new ResslerSystem();
ds2 = new SignAxes(ds2);
Console.WriteLine(ds2.NameSystem);