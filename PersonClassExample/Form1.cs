using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PersonList List1 = new PersonList();
        int Count;

       private void btnDisplay_Click(object sender, EventArgs e)
        {
         

                Person person1 = new Person(txtName.Text, txtID.Text);

              //  List1.add(person1);
                List1 += person1;
                Count = List1.Count;

           MessageBox.Show("A new person has been added to the list. There are a total of " + Count + " in the list"); 

                lblOutput.Text = person1.getpersoninfo();
     

           




           
        }

       private void btnSearch_Click(object sender, EventArgs e)
       {
           string getname = txtSearch.Text;
           Person p2 = new Person();
           p2 = List1[getname];
           lblOutput.Text = p2.getpersoninfo();
       }

       private void btnIndex_Click(object sender, EventArgs e)
       {
           int index = Convert.ToInt32(txtSearch.Text);

           Person p2 = new Person();

           p2 = List1.getbyindex(index);
           lblOutput.Text = p2.getpersoninfo();



       }
    

       
    }
}
