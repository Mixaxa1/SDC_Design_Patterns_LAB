
using Composite;
using Composite.CompositeComponents;

VeryEfficientCompanyClient client = new VeryEfficientCompanyClient();

EfficientManager CEO = new EfficientManager();
Console.WriteLine("Hire some staff");

EfficientManager departmentManager1 =  new EfficientManager();
departmentManager1.Add(new Worker());
departmentManager1.Add(new Worker());
departmentManager1.Add(new Worker());

EfficientManager departmentManager2 = new EfficientManager();
departmentManager2.Add(new Worker());
departmentManager2.Add(new Worker());
departmentManager2.Add(new Worker());

CEO.Add(departmentManager1);
CEO.Add(departmentManager2);

client.FigureOutWhoMadeMisstake(CEO);

Console.WriteLine();
Console.WriteLine("Increace efficency");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

CEO.Remove(departmentManager1);
CEO.Remove(departmentManager2);

EfficientManager newManager1 = new EfficientManager();

EfficientManager newManager2 = new EfficientManager();
newManager2.Add(departmentManager1);
newManager1.Add(newManager2);

EfficientManager newManager3 = new EfficientManager();
newManager3.Add(departmentManager2);
newManager2.Add(newManager3);

CEO.Add(newManager1);

client.FigureOutWhoMadeMisstake(CEO);