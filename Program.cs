using PrincipioResponsabilidadUnica.Controlador;

namespace PrincipioResponsabilidadUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar Nombre del empleado: ");
            string name = Console.ReadLine();

            Console.Write("Ingresa posicion de trabajo: ");
            string position = Console.ReadLine();

            Console.Write("Ingresar salario por horas: ");
            decimal hourlySalary = decimal.Parse(Console.ReadLine());

            Console.Write("Ingresar horas trabajadas: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            Console.Write("Mail para: ");
            string email = Console.ReadLine();

            Employee employee = new Employee(name, position, hourlySalary);
            EmailService emailService = new EmailService();
            EmployeeController employeeController = new EmployeeController(employee, emailService);

            employeeController.ProcessPayrollAndSendEmail(hoursWorked, email);

            Console.WriteLine("Proceso terminado.");
        }
    }

}
