using mycontacte.reposetory;
using mycontacte.reposetory.servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycontacte
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void bindgrid()
        {
            using (testEntities db = new testEntities())
            { 

                dgcontact.AutoGenerateColumns = false;
                dgcontact.DataSource = db.mycontacts.ToList();
            }
        }

        

        private void Brefresh_Click(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void Bnew_Click(object sender, EventArgs e)
        {
            ADDorEDIT frm = new ADDorEDIT();
            frm.ShowDialog();
            if(frm.ShowDialog() == DialogResult.OK)
                bindgrid();
        }

        private void btnREMOV_Click(object sender, EventArgs e)
        {
            if(dgcontact.CurrentRow != null)
            {
                string name = dgcontact.CurrentRow.Cells[1].Value.ToString();
                string family = dgcontact.CurrentRow.Cells[2].Value.ToString();
                string fname = name + " " + family;

                if (MessageBox.Show($"آیا از حذف {fname} مطمئن هستید؟  ","توجه", MessageBoxButtons.YesNo)  == DialogResult.Yes)
                { 
                    int id = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());
                    using (testEntities db = new testEntities())
                    {
                        mycontact con = db.mycontacts.Single(x => x.IDcontact == id);
                        db.mycontacts.Remove(con);
                        db.SaveChanges();
                    }
                    
                    bindgrid();

                }
            
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب نمایید");
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgcontact.CurrentRow != null)
            {
                int id = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());
                ADDorEDIT edit = new ADDorEDIT();
                edit.id = id;
                if(edit.ShowDialog() == DialogResult.OK)
                {
                    bindgrid();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            using (testEntities db = new testEntities())
            {

                dgcontact.DataSource = db.mycontacts.Where(x => x.name.Contains(search.Text) || x.family.Contains(search.Text)).ToList();
            }
        }
    }
}
