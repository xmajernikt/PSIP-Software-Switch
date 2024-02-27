using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    internal class MacTable
    {
        private static Hashtable macHashTable = new Hashtable();
        private static MainWindow mainWindow;
        private static readonly Object lockObject = new Object();
        private static DataTable macTable;

        public MacTable(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            


        }

    }

}
