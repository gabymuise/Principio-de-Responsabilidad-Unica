using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioResponsabilidadUnica.Controlador
{
public class EmployeeController
{
    private readonly Employee _employee;
    private readonly EmailService _emailService;

    public EmployeeController(Employee employee, EmailService emailService)
    {
        _employee = employee;
        _emailService = emailService;
    }

    public void ProcessPayrollAndSendEmail(int hoursWorked, string email)
    {
        decimal payroll = _employee.CalculatePayRoll(hoursWorked);
        string subject = "Información de empleados";
        string message = $"Hola {_employee.Name},\nTu nomina para {hoursWorked} horas trabajadas son: {payroll:C}";

        _emailService.SendEmail(email, subject, message);
    }
}

}
