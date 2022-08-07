using csharp_oop;

Building gymBuilding = new Building("Blue", "White", "Gym Main Building", 2500000);

Console.WriteLine(gymBuilding.Name);

Customer customer1 = new Customer("Male", "Yearly", true, new DateTime(22, 8, 6, 12, 03, 2), "Sushant", "Sharma");

Console.WriteLine(customer1.FirstName);

Employee manager = new Employee("Manager", true, "Sushant", "Sharma");
Employee assistantManager = new Employee("Assistant Manager", true, "Zack", "trench");
Employee receptionsit1 = new Employee("Receptionist1", true, "Jim", "Prash");
Employee receptionsit2 = new Employee("Receptionist2", true, "kath", "britch");
Employee instructor1 = new Employee("General Instructor", true, "James", "Bond");
Employee instructor2 = new Employee("Yoga Instructor", true, "John", "Wick");
Employee instructor3 = new Employee("Martial Arts Instructor", true, "Nashle", "steep");

gymBuilding.Employees.Add(manager);
gymBuilding.Employees.Add(assistantManager);
gymBuilding.Employees.Add(receptionsit1);
gymBuilding.Employees.Add(receptionsit2);
gymBuilding.Employees.Add(instructor1);
gymBuilding.Employees.Add(instructor2);
gymBuilding.Employees.Add(instructor3);

Console.WriteLine(manager.FirstName);

gymBuilding.Light = new Lights(5, "White", "Lights", 500);


Console.WriteLine(manager.Position);


// manager.StartGym();

instructor1.StartGym();

Building.EmegencyFireAlert(true);
