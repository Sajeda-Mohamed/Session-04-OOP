using Assignment.Interfaces;
using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            //q1 => b
            //q2 => a
            //q3 => b
            //q4 => b
            //q5 => d
            //q6 => a
            //q7 => b
            //q8 => a
            //q9 => b
            //q10 => c 
            #endregion

            #region Part2
            #region Q1 IShape
            //IShape Circle = new Circle(7);
            //IShape Rectangle = new Rectangle(5, 4);

            //Circle.DisplayShapeInfo();
            //Rectangle.DisplayShapeInfo(); 
            #endregion

            #region Q2 IAuthenticationService
            //IAuthenticationService authentication = new BasicAuthenticationService("Sajeda", "123456", "Authorized");

            //authentication.AuthenticateUser();
            //authentication.AuthorizeUser();
            #endregion

            #region Q3 INotificationService
            //INotificationService Email = new EmailNotificationService();
            //INotificationService SMS = new SmsNotificationService();
            //INotificationService Push = new PushNotificationService();

            //Email.SendNotification("Sajeda123@gmail.com", "You may have an Email");
            //SMS.SendNotification("Sajeda", "You have a SMS Message");
            //Push.SendNotification("SAjeda", "You have a Push Notification");
            #endregion
            #endregion
        }
    }
}
