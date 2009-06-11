using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TwoProblems
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            var controller = new Controller(PathToExecutableDirectory);
            controller.Run();

         }
        public static string PathToExecutableDirectory
        {
            get
            {
                string path;
                bool unitTesting = Assembly.GetEntryAssembly() == null;
                if (unitTesting)
                {
                    path = new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath;
                    path = Uri.UnescapeDataString(path);
                }
                else
                {
                    //was suspect in WS1156, where it seemed to start looking in the,
                    //outlook express program folder after sending an email from wesay...
                    //so maybe it doesn't always mean *this* executing assembly?
                    //  path = Assembly.GetExecutingAssembly().Location;
                    path = Application.ExecutablePath;
                }
                if (path.ToLower().Contains("output\\debug"))
                {
                    path = path.Replace("output\\Debug", "");                    
                }
                    return Path.Combine(Directory.GetParent(path).FullName, "rules");
            }
        }
    }
}
