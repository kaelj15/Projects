using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        List<Staff> staff;
        List<Staff> searchRes;

        public Form1()
        {
            InitializeComponent();
            staff = new List<Staff>();
            staff = new List<Staff>();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            staff.Clear();

            staff.Add(new Staff("Tom", "Jones", "02-4-01"));
            staff.Add(new Staff("Sam", "Michaels", "01-2-12"));
            staff.Add(new Staff("Tom", "Long", "02-4-01"));
            staff.Add(new Staff("Tim", "Anders", "04-3-04"));
            staff.Add(new Staff("Lee", "Smith", "01-5-09"));
            staff.Add(new Staff("Sue", "West", "06-2-08"));
            staff.Add(new Staff("Bob", "Richards", "01-2-17"));
            staff.Add(new Staff("Lee", "Sanders", "01-5-09"));

            UpdateStaffListBox();
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            Sorter staffSorter = new Sorter();

            staff = staffSorter.SortAZ(staff);

            UpdateStaffListBox();
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            Sorter staffSorter = new Sorter();

            staff = staffSorter.SortZA(staff);

            UpdateStaffListBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Searcher staffSearcher = new Searcher();

            string searchTerm = tbxSearch.Text;

            searchRes = staffSearcher.Search(staff, searchTerm);

            lbxSearch.Items.Clear();
            lbxSearch.Items.AddRange(searchRes.ToArray());
        }

        private void UpdateStaffListBox()
        {
            lbxStaff.Items.Clear();
            lbxStaff.Items.AddRange(staff.ToArray());
        }
    }
}
