using System;

namespace mycontacte.reposetory.servises
{
    internal class contacteBase
    {


        public bool insert(string name, string family, int age, string kodemeli, string addres)
        {

            //SqlConnection conectiom = new SqlConnection(address);
            //try
            //{
            //    string qary = "Insert Into mycontact (name,family,kodemeli,age,addres) values (@name,@family,@kodemeli,@age,@addres)";
            //    SqlCommand cmd = new SqlCommand(qary, conectiom);
            //    cmd.Parameters.AddWithValue("@name", name);
            //    cmd.Parameters.AddWithValue("@family", family);
            //    cmd.Parameters.AddWithValue("@kodemeli",kodemeli);
            //    cmd.Parameters.AddWithValue("@age", age);
            //    cmd.Parameters.AddWithValue("@addres", addres);
            //    conectiom.Open();
            //    cmd.ExecuteNonQuery();
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
            //finally 
            //{
            //    conectiom.Close(); 
            //}
            throw new NotImplementedException();

        }
    }
}