using mycontacte.reposetory;
using mycontacte.reposetory.servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycontacte
{
    public partial class ADDorEDIT : Form
    {
        testEntities db = new testEntities();
        public int id = 0;

        public ADDorEDIT()
        {
            InitializeComponent();
        }

        private void ADDorEDIT_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش شخص";
                mycontact contact = db.mycontacts.Find(id);
                txtname.Text = contact.name;
                textfamily.Text = contact.family;
                textkodemeli.Text = contact.kodemeli;
                age.Text = contact.age.ToString();
                txtphone.Text = contact.phone;
                textaddress.Text = contact.addres;
                sumbit.Text = "ویرایش";





            }
        }
        bool registerInput()
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textfamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textkodemeli.Text == "")
            {
                MessageBox.Show("لطفا کد ملی خود را را وارد کنید", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (age.Value == 0)
            {
                MessageBox.Show("لطفا سن خود را وارد کنید", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (age.Value < 18)
            {
                MessageBox.Show("باید سن شما بالای 18 باشد", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textaddress.Text == "")
            {
                return true;

            }
            if (txtphone.TextLength<11)
            {
                MessageBox.Show("شماره تماس صحیح نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            if (registerInput())
            {

                mycontact contact = new mycontact();

                if (id == 0)
                {
                    contact.name = txtname.Text;
                    contact.family = textfamily.Text;
                    contact.addres = textaddress.Text;
                    contact.age = (int)age.Value;
                    contact.kodemeli = textkodemeli.Text;
                    contact.phone = txtphone.Text;
                    db.mycontacts.Add(contact);
                }
                else
                {
                    contact = db.mycontacts.Find(id);
                    contact.name = txtname.Text;
                    contact.family = textfamily.Text;
                    contact.addres = textaddress.Text;
                    contact.age = (int)age.Value;
                    contact.kodemeli = textkodemeli.Text;
                    contact.phone = txtphone.Text;
                }
                db.SaveChanges();
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
