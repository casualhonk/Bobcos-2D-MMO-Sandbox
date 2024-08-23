using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace bobcos6server
{
    
    class Class1
    {



       
        public static void GameLog(string log)
        {
            return;
            try
            {
                StreamReader reader = new StreamReader("Logs/GameLogs.txt");

                string readded = reader.ReadToEnd();
                reader.Close();


                StreamWriter writer = new StreamWriter("Logs/GameLogs.txt");

                writer.WriteLine(readded);
                writer.WriteLine($"[{DateTime.Now}] {log}");

                writer.Close();
            }
            catch
            {

            }
           

        }

        public static void UserLog(string log,string username)
        {
            return;

            try
            {



                StreamReader reader = new StreamReader($"Logs/UserLogs/{username.ToUpper()}.txt");

                string readded = reader.ReadToEnd();
                reader.Close();
                StreamWriter writer = new StreamWriter($"Logs/UserLogs/{username.ToUpper()}.txt");
                writer.WriteLine(readded);


                writer.WriteLine($"[{DateTime.Now}] {log}");

                writer.Close();
            }
            catch
            {

            }
        }

        public static void WorldLog(string log, string worldname)
        {
            return;

            try
            {


                StreamReader reader = new StreamReader($"Logs/WorldLogs/{worldname.ToUpper()}.txt");

                string readded = reader.ReadToEnd();
                reader.Close();
                StreamWriter writer = new StreamWriter($"Logs/WorldLogs/{worldname.ToUpper()}.txt");
                writer.WriteLine(readded);

                writer.WriteLine($"[{DateTime.Now}] {log}");

                writer.Close();
            }
            catch
            {

            }
        }


    }
        
}
        
