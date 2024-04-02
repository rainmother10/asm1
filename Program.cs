using System.Runtime.CompilerServices;

namespace ASM1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new From_Login());
            if (Appdata.islogin=true)
            {
                if(Appdata.role == Appdata.ROLE_User)
                {
                    Form2_User form2 = new Form2_User();
                    
                    Application.Run(form2);
                    
                }
                else if (Appdata.role == Appdata.ROLE_ADmin) 
                {
                    Form3 form3 = new Form3();
                    
                    
                    
                    Application.Run(form3);
                }
            }
        }
    }
}