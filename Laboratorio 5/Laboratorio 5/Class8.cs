using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class User
    {


        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerify;



        protected virtual void OnEmailVerified()
        {
            if (EmailVerify != null)
            {
                EmailVerify(this, EventArgs.Empty);
            }

        }

        public void OnEmailSent(object source, EventArgs args)
        {
            string answer;
            Console.WriteLine("presione 1 si quiere verificar su correo");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                OnEmailVerified();
            }

        }
    }

}