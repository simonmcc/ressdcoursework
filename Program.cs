using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace quizv4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void SaveObject(player[] thisObject)
        {
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            sw = File.Open("mydata.dat", FileMode.Create);
            bf.Serialize(sw, thisObject);
            sw.Close();
        }
        public static void LoadObject(ref player[] thisObject)
        {
            if (File.Exists("mydata.dat"))
            {
                Stream sr;
                BinaryFormatter bf = new BinaryFormatter();
                sr = File.OpenRead("mydata.dat");
                thisObject = (player[])bf.Deserialize(sr);
                sr.Close();
            }
            else 
            {
                thisObject = new player[0];
            }
        }
    }
}
