using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioResponsabilidadUnica
{
    public class EmailService
    {
        public void SendEmail(string email, string subject, string message)
        {
            Console.WriteLine($"Enviando correo a {email}...");
            Console.WriteLine($"Asunto: '{subject}'");
            Console.WriteLine($"Mensaje: '{message}'");
            Console.WriteLine("Correo enviado.");
        }
    }

}
