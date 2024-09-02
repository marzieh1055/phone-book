using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace mycontacte.reposetory
{
     interface Interface1
    {
        DataTable selectAll();
        DataTable selectRow(int id);
        DataTable search(string item);
        bool insert(string name, string family , int age, string kodemeli,string addres);
        bool update(int id , string name, string family , int age, string kodemeli ,string addres);
        bool delete(int id);
    }
}
