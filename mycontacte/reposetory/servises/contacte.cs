using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mycontacte.reposetory.servises
{
    internal class contacte : Interface1
    {
        private string address = "Data Source=.;Initial Catalog=test;Integrated Security= True";

        public bool delete(int id)
        {
            SqlConnection  addres = new SqlConnection(address);
            try
            {
                string qury = "Delete from mycontact where IDcontact=@delete";
                SqlCommand command = new SqlCommand(qury, addres);
                command.Parameters.AddWithValue("@delete", id);
                addres.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                MessageBox.Show("خطا");
                return false;
            }
            finally 
            {
                addres.Close();
            }
        }

        public bool insert(string name, string family, int age, string kodemeli, string addres)
        {

            SqlConnection conectiom = new SqlConnection(address);
            try
            {
                string qary = "Insert Into mycontact (name,family,kodemeli,age,addres) values (@name,@family,@kodemeli,@age,@addres)";
                SqlCommand cmd = new SqlCommand(qary, conectiom);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@kodemeli", kodemeli);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@addres", addres);
                conectiom.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conectiom.Close();
            }

        }

        public DataTable search(string item)
        {
            string query = "select * from mycontact where Name like @item or family like @item";
            SqlConnection connection = new SqlConnection(address);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@item" , "%"+item+"%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable selectAll()
        {
            string query = "select * from mycontact";
            SqlConnection connection = new SqlConnection(address);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable selectRow(int id)
        {
            string query = "select * from mycontact where IDcontact=" + id;
            SqlConnection connection = new SqlConnection(address);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        

        public bool update(int id, string name, string family, int age, string kodemeli, string addres)
        {
            SqlConnection conectiom = new SqlConnection(address);
            try
            {
                string qary = "update mycontact set name=@name,family=@family,kodemeli=@kodemeli,age=@age,addres=@addres where IDcontact=@id";
                SqlCommand cmd = new SqlCommand(qary, conectiom);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@kodemeli", kodemeli);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@addres", addres);
                conectiom.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conectiom.Close();
            }
        }

        
    }
}
