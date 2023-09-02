using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsBackupRestore
    {
        private CD_clsBackupRestore objetoCD = new CD_clsBackupRestore();
        public void Backup(string ruta)
        {
            objetoCD.BackupDB(ruta);
        }
        public void Restore(string ruta)
        {
            objetoCD.RestoreDB(ruta);
        }
    }
}
