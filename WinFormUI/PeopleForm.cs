using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            // TODO - Get real data here
            people = SQLiteDataAccess.LoadPeople();
            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeople.DataSource = null;
            listPeople.DataSource = people;
            listPeople.DisplayMember = "FullName";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel
            {
                FirstName = textNameF.Text,
                LastName = textNameL.Text
            };


            // TODO - do something with this item
            SQLiteDataAccess.SavePerson(p);

            textNameF.Text = "";
            textNameL.Text = "";
        }
    }
}
