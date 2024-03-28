using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace gh
{
    internal class SerialandDeser
    {
        public static T Deserisis<T> () { 
            OpenFileDialog ofd = new OpenFileDialog ();
            if (ofd.ShowDialog() == true)
            {
                string json = File.ReadAllText (ofd.FileName);
                T obj = JsonConvert.DeserializeObject<T> (json);

                return obj;
            }
            else
            {
                return default(T);
            }
        }
    }
}
