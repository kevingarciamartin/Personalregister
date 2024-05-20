using Personalregister;

string selectedAction;
var employees = new LinkedList<Employee>();

do
{
    Console.WriteLine();
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. See employees");
    Console.WriteLine("99. Exit application");
    Console.WriteLine();
    selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Wage: ");
            double wage;
            double.TryParse(Console.ReadLine(), out wage);
            Employee newEmployee = new Employee(firstName, lastName, wage);
            employees.AddLast(newEmployee);
            break;
        case "2":
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"First name: {employee.firstName}, Last name: {employee.lastName}, wage: {employee.wage}");
            }
            break;
        case "99":
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }

} while (selectedAction != "99");

Console.WriteLine("Closing application");