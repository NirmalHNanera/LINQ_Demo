using ConsoleApp1;
using System;
using System.Collections.Generic;

//public class Vehicle
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public string Type { get; set; }
//    public string VehicleNo { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Vehicle> vehicles = new List<Vehicle>
//        {
//            new Vehicle() { ID = 1, Name = "Venue", Type = "SUV", VehicleNo = "GJ03XY1234" },
//            new Vehicle() { ID = 2, Name = "Explorer", Type = "SUV", VehicleNo = "MH02AB5678" },
//            new Vehicle() { ID = 3, Name = "Civic", Type = "Sedan", VehicleNo = "KA05CD9876" },
//            new Vehicle() { ID = 4, Name = "Accord", Type = "Sedan", VehicleNo = "TN09EF5432" },
//            new Vehicle() { ID = 5, Name = "F-150", Type = "Truck", VehicleNo = "DL03GH8765" },
//            new Vehicle() { ID = 6, Name = "Mustang", Type = "Sports Car", VehicleNo = "GJ18IJ2345" },
//            new Vehicle() { ID = 7, Name = "Rogue", Type = "SUV", VehicleNo = "MH20KL6789" },
//            new Vehicle() { ID = 8, Name = "Sentra", Type = "Sedan", VehicleNo = "KA07MN4321" },
//            new Vehicle() { ID = 9, Name = "Silverado", Type = "Truck", VehicleNo = "TN05OP8765" },
//            new Vehicle() { ID = 10, Name = "Camry", Type = "Sedan", VehicleNo = "DL10QR1234" },
//            new Vehicle() { ID = 11, Name = "Tundra", Type = "Truck", VehicleNo = "GJ15ST5678" },
//            new Vehicle() { ID = 12, Name = "Wrangler", Type = "SUV", VehicleNo = "MH22UV9876" },
//            new Vehicle() { ID = 13, Name = "Corvette", Type = "Sports Car", VehicleNo = "KA33WX5432" },
//            new Vehicle() { ID = 14, Name = "Pilot", Type = "SUV", VehicleNo = "TN44YZ2345" },
//            new Vehicle() { ID = 15, Name = "Cherokee", Type = "SUV", VehicleNo = "DL55AB6789" }
//        };

//        foreach (var vehicle in vehicles)
//        {
//            Console.WriteLine($"ID: {vehicle.ID}, Name: {vehicle.Name}, Type: {vehicle.Type}, VehicleNo: {vehicle.VehicleNo}");
//        }



//        var vehicleNames = vehicles.Select(v => v.Name);

//        foreach (var name in vehicleNames)
//        {
//            Console.WriteLine($"Vehicle Name: {name}");
//        }

//        var vehiclesStartingWithGJ = vehicles.Where(v => v.VehicleNo.StartsWith("GJ"));

//        Console.WriteLine("Vehicles starting with 'GJ':");
//        foreach (var vehicle in vehiclesStartingWithGJ)
//        {
//            Console.WriteLine($"ID: {vehicle.ID}, Name: {vehicle.Name}, Type: {vehicle.Type}, VehicleNo: {vehicle.VehicleNo}");
//        }

//        var vehiclesStartingContainsMH = vehicles.Where(v => v.VehicleNo.Contains("MH"));

//        Console.WriteLine("Vehicles Contains with 'MH':");
//        foreach (var vehicle in vehiclesStartingContainsMH)
//        {
//            Console.WriteLine($"ID: {vehicle.ID}, Name: {vehicle.Name}, Type: {vehicle.Type}, VehicleNo: {vehicle.VehicleNo}");
//        }

//        int totalVehicleCount = vehicles.Count();

//        Console.WriteLine($"Total number of vehicles: {totalVehicleCount}");
//    }
//}
//-------------------------------------LINQ-QUERIES--DEMO-------------------------------------------
var context = new ApplicationDBContext();
//For example, Display FirstName of all employees.
//var q1 = context.Employee.Select(x => x.FirstName);
//foreach (var employee in q1)
//{
//    Console.WriteLine("\n {0}", employee);
//}

//var query1 = context.Employee;
//Console.WriteLine("1. Data of all employees:");
//foreach (var employee in query1)
//{
//    Console.WriteLine($"AccountNo: {employee.AccountNo}, FirstName: {employee.FirstName}, LastName: {employee.LastName}, Email: {employee.Email}, Salary: {employee.Salary}, JoiningDate: {employee.JoiningDate}, Department: {employee.Department}");
//}
//Console.WriteLine();

//var query2 = context.Employee.Select(e => new { e.AccountNo, e.FirstName, e.Salary });
//Console.WriteLine("2. ActNo, FirstName, and Salary of all employees:");
//foreach (var result in query2)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, Salary: {result.Salary}");
//}
//Console.WriteLine();

//var query3 = context.Employee.Select(e => $"{e.FirstName} works in {e.Department} Department.");
//Console.WriteLine("3. Employee data in specified format:");
//foreach (var result in query3)
//{
//    Console.WriteLine(result);
//}
//Console.WriteLine();

//var query4 = context.Employee.Select(e => new { FullName = $"{e.FirstName} {e.LastName}", e.Email, e.Department });
//Console.WriteLine("4. Employee Full Name, Email, and Department as anonymous:");
//foreach (var result in query4)
//{
//    Console.WriteLine($"FullName: {result.FullName}, Email: {result.Email}, Department: {result.Department}");
//}
//Console.WriteLine();

//var query5 = context.Employee.Select(e => new { e.FirstName, e.LastName, e.JoiningDate });
//Console.WriteLine("5. Employees with their joining date:");
//foreach (var result in query5)
//{
//    Console.WriteLine($"FirstName: {result.FirstName}, LastName: {result.LastName}, JoiningDate: {result.JoiningDate}");
//}
//Console.WriteLine();


//var query6 = context.Employee.Where(e => e.Age >= 20 && e.Age <= 30);
//Console.WriteLine("6. Employees between age 20 to 30:");
//foreach (var result in query6)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Age: {result.Age}");
//}
//Console.WriteLine();

//var query7 = context.Employee.Where(e => e.Gender == "Female");
//Console.WriteLine("7. Female employees:");
//foreach (var result in query7)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Gender: {result.Gender}");
//}
//Console.WriteLine();

//var query8 = context.Employee.Where(e => e.Salary > 35000);
//Console.WriteLine("8. Employees with salary more than 35000:");
//foreach (var result in query8)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Salary: {result.Salary}");
//}
//Console.WriteLine();

//var query9 = context.Employee.Where(e => e.AccountNo < 110);
//Console.WriteLine("9. Employees whose account no is less than 110:");
//foreach (var result in query9)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}");
//}
//Console.WriteLine();



//var query10 = context.Employee.Where(e => e.City =="Rajkot" || e.City == "Morbi");
//Console.WriteLine("10. . Display employees who belongs to either Rajkot or Morbi city:");
//foreach (var result in query10)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email} , Email: {result.City}");
//}
//Console.WriteLine();

//// 11. Display employees whose salary is less than 20000.
//var query11 = context.Employee.Where(e => e.Salary < 20000);
//Console.WriteLine("11. Employees whose salary is less than 20000:");
//foreach (var result in query11)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Salary: {result.Salary}");
//}
//Console.WriteLine();

//// 12. Display employees whose salary is more than equal to 30000 and less than equal to 60000.
//var query12 = context.Employee.Where(e => e.Salary >= 30000 && e.Salary <= 60000);
//Console.WriteLine("12. Employees whose salary is between 30000 and 60000:");
//foreach (var result in query12)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Salary: {result.Salary}");
//}
//Console.WriteLine();

//// 13. Display ActNo, FirstName and Amount of employees who belong to Morbi or Ahmedabad or Surat city and Account No greater than 120.
//var query13 = context.Employee
//    .Where(e => (e.City == "Morbi" || e.City == "Ahmedabad" || e.City == "Surat") && e.AccountNo > 120)
//    .Select(e => new { e.AccountNo, e.FirstName, Amount = e.Salary * 12 });
//Console.WriteLine("13. ActNo, FirstName, and Amount of employees in Morbi, Ahmedabad, or Surat with Account No greater than 120:");
//foreach (var result in query13)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, Amount: {result.Amount}");
//}
//Console.WriteLine();

//// 14. Display male employees of age between 30 to 35 and belong to Rajkot city.
//var query14 = context.Employee
//    .Where(e => e.Gender == "Male" && e.Age >= 30 && e.Age <= 35 && e.City == "Rajkot");
//Console.WriteLine("14. Male employees of age between 30 to 35 and belong to Rajkot city:");
//foreach (var result in query14)
//{
//    Console.WriteLine($"AccountNo: {result.AccountNo}, FirstName: {result.FirstName}, LastName: {result.LastName}, Email: {result.Email}, Age: {result.Age}");
//}
//Console.WriteLine();

//// 15. Display Unique Cities. (use Distinct())
//var query15 = context.Employee.Select(e => e.City).Distinct();
//Console.WriteLine("15. Unique Cities:");
//foreach (var city in query15)
//{
//    Console.WriteLine(city);
//}
//Console.WriteLine();

//// 16. Display employees whose joining is between 15/07/2018 to 16/09/2019.
//var startDate = new DateTime(2018, 7, 15);
//var endDate = new DateTime(2019, 9, 16);
//var query16 = context.Employee.Where(e => e.JoiningDate >= startDate && e.JoiningDate <= endDate);
//Console.WriteLine("16. Employees whose joining is between 15/07/2018 to 16/09/2019:");
//foreach (var result in query16)
//{
//    Console.WriteLine(result);
//}
//Console.WriteLine();

//// 17. Display female employees who work in Sales department.
//var query17 = context.Employee.Where(e => e.Gender == "Female" && e.Department == "Sales");
//Console.WriteLine("17. Female employees who work in Sales department:");
//foreach (var result in query17)
//{
//    Console.WriteLine(result);
//}
//Console.WriteLine();

//// 18. Display employees with their Age who belong to Rajkot city and are more than 35 years old.
//var query18 = context.Employee.Where(e => e.City == "Rajkot" && e.Age > 35)
//    .Select(e => new { e.FirstName, e.LastName, e.Age });
//Console.WriteLine("18. Employees with their Age who belong to Rajkot city and are more than 35 years old:");
//foreach (var result in query18)
//{
//    Console.WriteLine($"FirstName: {result.FirstName}, LastName: {result.LastName}, Age: {result.Age}");
//}
//Console.WriteLine();

//// LINQ Queries on Aggregate

//// 19. Find total salary and display it.
//var query19 = context.Employee.Sum(e => e.Salary);
//Console.WriteLine($"19. Total salary: {query19}");
//Console.WriteLine();

//// 20. Find total number of employees of Admin department who belong to Rajkot city.
//var query20 = context.Employee.Count(e => e.Department == "Admin" && e.City == "Rajkot");
//Console.WriteLine($"20. Total number of employees of Admin department who belong to Rajkot city: {query20}");
//Console.WriteLine();

//// 21. Find total salary of Distribution department.
//var query21 = context.Employee.Where(e => e.Department == "Distribution").Sum(e => e.Salary);
//Console.WriteLine($"21. Total salary of Distribution department: {query21}");
//Console.WriteLine();

//// 22. Find average salary of IT department.
//var query22 = context.Employee.Where(e => e.Department == "IT").Average(e => e.Salary);
//Console.WriteLine($"22. Average salary of IT department: {query22}");
//Console.WriteLine();

//// 23. Find minimum salary of Customer Relationship department.
//var query23 = context.Employee
//.Where(e => e.Department == "Customer Relationship")
//.Min(e => e.Salary);
//Console.WriteLine($"23. Minimum salary of Customer Relationship department: {query23}");
//Console.WriteLine();

//// 24. Find maximum salary of Distribution department who belongs to Baroda city.
//var query24 = context.Employee
//    .Where(e => e.Department == "Distribution" && e.City == "Baroda")
//    .Max(e => e.Salary);
//Console.WriteLine($"24. Maximum salary of Distribution department who belongs to Baroda city: {query24}");
//Console.WriteLine();

//// 25. Find number of employees whose Age is more than 40.
//var query25 = context.Employee.Count(e => e.Age > 40);
//Console.WriteLine($"25. Number of employees whose Age is more than 40: {query25}");
//Console.WriteLine();

//// 26. Find total female employees working in Ahmedabad city.
//var query26 = context.Employee.Count(e => e.Gender == "Female" && e.City == "Ahmedabad");
//Console.WriteLine($"26. Total female employees working in Ahmedabad city: {query26}");
//Console.WriteLine();

//// 27. Find total salary of male employees who belong to Gandhinagar city and work in IT department.
//var query27 = context.Employee
//    .Where(e => e.Gender == "Male" && e.City == "Gandhinagar" && e.Department == "IT")
//    .Sum(e => e.Salary);
//Console.WriteLine($"27. Total salary of male employees who belong to Gandhinagar city and work in IT department: {query27}");
//Console.WriteLine();

// 28. Find average salary of male employees whose age is between 21 to 35.
//var query28 = context.Employee
//    .Where(e => e.Gender == "Male" && e.Age >= 21 && e.Age <= 35)
//    .Average(e => e.Salary);
//Console.WriteLine($"28. Average salary of male employees whose age is between 21 to 35: {query28}");
//Console.WriteLine();

// 29. Display employees by their first name in ascending order.
//var query30 = from employee in context.Employee
//    orderby employee.Department descending
//    select employee;

//Console.WriteLine("30. Employees by department name in descending order:");
//foreach (var result in query30)
//{
//    Console.WriteLine($"Name: {result.FirstName}, Department: {result.Department}");
//}
//Console.WriteLine();


// 30. Display employees by department name in descending order.
//var query31 = from employee in context.Employee
//    orderby employee.Department descending, employee.FirstName ascending
//    select employee;

//Console.WriteLine("31. Employees by department name descending and first name in ascending order:");
//foreach (var result in query31)
//{
//    Console.WriteLine($"Name: {result.FirstName}, Department: {result.Department}");
//}
//Console.WriteLine();


//// 31. Display employees by department name descending and first name in ascending order.
//var query31 = from employee in context.Employee
//    orderby employee.Department descending, employee.FirstName ascending
//    select employee;

//Console.WriteLine("31. Employees by department name descending and first name in ascending order:");
//foreach (var result in query31)
//{
//    Console.WriteLine($"Name: {result.FirstName}, Department: {result.Department}");
//}
//Console.WriteLine();


//// 32. Display employees by their first name in ascending order and last name in descending order.
var query32 = from employee in context.Employee
    orderby employee.FirstName ascending, employee.LastName descending
    select employee;

Console.WriteLine("32. Employees by their first name in ascending order and last name in descending order:");
foreach (var result in query32)
{
    Console.WriteLine($"Name: {result.FirstName}, First Name: {result.FirstName}, Last Name: {result.LastName}");
}
Console.WriteLine();


// 33. Display employees by their Joining Date using Reverse() operator.
//var query33 = (from employee in context.Employee
//    orderby employee.JoiningDate descending
//    select employee).Reverse();

//Console.WriteLine("33. Employees by their Joining Date in descending order:");
//foreach (var result in query33)
//{
//    Console.WriteLine($"Name: {result.FirstName}, Joining Date: {result.JoiningDate}");
//}
//Console.WriteLine();








