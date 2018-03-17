using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovayaKuznetsova
{
    abstract class Connector
    {
        // TODO: что требуется для каждого метода - определить, и что на выход
        // для передачи массива - а тама массив?

        // object[] GetParamRecords();
        static public bool SaveRecord(object saving)
        {
            return false;
        }
        static public bool SaveAllRecords(object[] saving)
        {
            return false;
        }
        static public object GetRecord(int id)
        {
            return new object();
        }
        static public object[] GetAllRecords()
        {
            return new object[0];
        }
        static public bool CreateRecord()
        {
            return false;
        }
        static public bool DeleteRecord()
        {
            return false;
        }
    }
}
