using System;
using System.Net.Mail;

namespace Exer3.Mail
{ 
    public class MailHelper
    {
        public static void EnvoyeMessage(string p_Sujet, string p_Message, string p_Destinataire)
        {
            SmtpClient smtpClient;

            //Instanciation du client
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //On indique au client d'utiliser les informations qu'on va lui fournir
            smtpClient.UseDefaultCredentials = true;
            ////Ajout des informations de connexion
            smtpClient.Credentials = new System.Net.NetworkCredential("programmation.web.2c3@gmail.com", "2c32c32c3");
            ////On indique que l'on envoie le mail par le réseau
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            ////On active le protocole SSL
            smtpClient.EnableSsl = true;

            MailMessage mail = new MailMessage();

            //Destinataire
            mail.To.Add(p_Destinataire);
            //Sujet
            mail.Subject = p_Sujet;
            //Corps du message
            mail.Body = p_Message;
            //Expéditeur
            mail.From = new MailAddress("programmation.web.2c3@gmail.com");

            smtpClient.Send(mail);
        }
    }
}
