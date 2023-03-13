namespace WorkingWithDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            Dictionary<string, Int16> DepartmentList = new Dictionary<string, Int16>();
            Dictionary<string, float> SalaryList = new Dictionary<string, float>(5);

            //Adding Employees
            EmployeeList.Add("Jo Schmoo", "Programmer");
            EmployeeList.Add("Ro Schmoo", "Project Manager");
            EmployeeList.Add("Flo Schmoo", "Architect");
            EmployeeList.Add("Mo Schmoo", "Asst. Project Manager");
            EmployeeList.Add("Bo Schmoo", "Manager");

            Console.WriteLine("EmployeeList Keys");
            Dictionary<string, string>.KeyCollection keys = EmployeeList.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("EmployeeList Values");
            Dictionary<string, string>.ValueCollection values = EmployeeList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("EmployeeList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in EmployeeList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            // Changing values
            EmployeeList["Jo Schmoo"] = "Sr. Programmer";
            EmployeeList["Ro Schmoo"] = "Programmer";
            EmployeeList.Remove("Flo Schmoo");

            Console.WriteLine("Revised EmployeeList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in EmployeeList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();

            //Adding Departments
            DepartmentList.Add("IT", 2);
            DepartmentList.Add("Management", 1);
            DepartmentList.Add("Construction", 3);
            DepartmentList.Add("Sales", 4);
            bool addDept = true;
            while (addDept)
            {
                Console.WriteLine("Enter the name of the department you wish to add");
                string deptName = Console.ReadLine();
                if (DepartmentList.ContainsKey(deptName))
                {
                    DepartmentList.Remove(deptName);
                }
                Console.WriteLine("Enter the department number you wish to add");
                Int16 deptNum = Int16.Parse(Console.ReadLine());
                DepartmentList.Add(deptName, deptNum);
                Console.WriteLine("The department has been added");
                Console.WriteLine("Add another? (y for yes, any key for no)");
                string answer = Console.ReadLine();
                if (answer == "y")
                    continue;
                else
                    addDept = false;

            }
            Console.WriteLine($"There are {DepartmentList.Count} departments in your list");
            foreach (KeyValuePair<string, Int16> kvp in DepartmentList)
            {
                Console.WriteLine($"Department Name: {kvp.Key}   Number: {kvp.Value}");
            }
            Console.WriteLine();

            //Adding Salaries
            SalaryList.Add("Programmer", 80000f);
            SalaryList.Add("Architect", 75000f);
            SalaryList.Add("Sales", 50000f);
            SalaryList.Add("Manager", 65000f);
            SalaryList.Add("Asst Manager", 40000f);

            // Salary list with formatted output
            Console.WriteLine("Salaries for different positions");
            foreach (KeyValuePair<string, float> kvp in SalaryList)
            {
                Console.WriteLine($"Position: {kvp.Key}   Salary: " + String.Format("{0:C}", kvp.Value));
            }
            Console.WriteLine();


        }

    }
}
