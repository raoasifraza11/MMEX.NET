using MMEX.Common.Resources.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEX.Desktop.Costants
{
    public class constPathDsktp
    {
        private static readonly char _sep = Path.DirectorySeparatorChar;
        public static string InstallationDirectory()
        {
            DirectoryInfo Folder = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            if (Folder.Name.ToUpper() == "BIN") // bin\mmex.exe
                Folder = Folder.Parent;
            return Folder.FullName;
        }

        public static bool isPortable()
        {
            FileInfo File = new FileInfo(InstallationDirectory() + _sep + constPath.MmexIniDb);
            return File != null;
        }

        public static string UserDirectory()
        {
            if (isPortable())
                return InstallationDirectory();
            else
            {
                string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _sep + "mmex";
                Directory.CreateDirectory(Folder);
                return Folder;
            }
        }      

        public static string MmexIni()
        {
            return UserDirectory() + _sep + constPath.MmexIniDb;
        }

    }
}
