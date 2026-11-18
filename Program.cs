using LAB08_1;

Department department = new Department("IT Department");

Worker w1 = new Worker("Guiseppe Leonardi", new DateTime(1990, 6, 12), new DateTime(2013, 5, 6), 23);
Worker w2 = new Worker("Worker 2", new DateTime(1980, 6, 12), new DateTime(2018, 5, 6), 15);
Programmer p1 = new Programmer("Alison Krause", new DateTime(1990, 6, 12), new DateTime(2013, 5, 6), Level.MIDDLE);
Programmer p2 = new Programmer("Alex Dunlop", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), Level.SENIOR);
Manager m1 = new Manager("Ritchy Mitchell", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), 12, true);
Manager m2 = new Manager("Angelina Eremich", new DateTime(1990, 6, 27), new DateTime(2013, 4, 23), 5, false);
Programmer p3 = new Programmer("Andrei Burba", new DateTime(1987, 3, 12), new DateTime(2010, 5, 6), Level.SENIOR);
department.AddEmployee(w1);
department.AddEmployee(w2);
department.AddEmployee(p1);
department.AddEmployee(p2);
department.AddEmployee(m1);
department.AddEmployee(m2);
department.PrintEmployees();
Console.WriteLine($"Total employees: {department.CountEmployees()}");
Console.WriteLine($"Workers: {department.CountWorkers()}");
Console.WriteLine($"Programmers: {department.CountProgrammers()}");
Console.WriteLine($"Managers: {department.CountManagers()}");
Console.WriteLine($"Total salary: {department.CalculateTotalSalary()}");
Console.WriteLine($"Average salary: {department.CalculateAverageSalary()}");
Console.WriteLine($"Highest paid: {department.FindHighestPaidEmployee()}");
Console.WriteLine($"Lowest paid: {department.FindLowestPaidEmployee()}");
department.RemoveEmployee(p1.ID);
department.RemoveEmployee(4);
Console.WriteLine("After removal:");
department.PrintEmployees();
Console.WriteLine($"Total employees: {department.CountEmployees()}");
Console.WriteLine($"Total salary: {department.CalculateTotalSalary()}");
Console.WriteLine($"Average salary: {department.CalculateAverageSalary()}");
Console.WriteLine($"Workers: {department.CalculateAverageSalaryByType("Worker")}");
Console.WriteLine($"Programmers: {department.CalculateAverageSalaryByType("Programmer")}");
Console.WriteLine($"Managers: {department.CalculateAverageSalaryByType("Manager")}");


Department department2 = new Department("HR department");
department2.AddEmployee(w1);
department2.PrintEmployees();
Worker w3 = new Worker("Guiseppe Leonardi", new DateTime(1980, 6, 12), new DateTime(2013, 5, 6), 23);
department2.AddEmployee(w3);
department2.AddEmployee(p3);
department2.PrintEmployees();