using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAndSort
{
    public partial class Form1 : Form
    {
        List<Person> MasterList;
        List<Person> SorterList;
        List<Person> SearcherList;

        public Form1()
        {
            InitializeComponent();
            MasterList = new List<Person>();
            SorterList = new List<Person>();
            SearcherList = new List<Person>();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();

            MasterList = fm.LoadPeople();
            lbxPeople.Items.Clear();
            lbxPeople.Items.AddRange(MasterList.ToArray());
        }

        private void rdoStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            Sorter sort = new Sorter();

            SorterList = sort.SortAZ(MasterList);
            lbxSorted.Items.Clear();
            lbxSorted.Items.AddRange(SorterList.ToArray());



        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            Sorter sort = new Sorter();

            SorterList = sort.SortZA(MasterList);
            lbxSorted.Items.Clear();
            lbxSorted.Items.AddRange(SorterList.ToArray());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           Searcher Searcherlbx = new Searcher();

            
            if (rdoStartsWith.Checked)
            {
                SearcherList = Searcherlbx.StartsWith(MasterList, tbxSearch.Text.ToLower());

                lbxSearch.Items.Clear();
                lbxSearch.Items.AddRange(SearcherList.ToArray());
            }
            else if (rdoEndsWith.Checked)
            {
                SearcherList = Searcherlbx.EndsWith(MasterList, tbxSearch.Text.ToLower());

                lbxSearch.Items.Clear();
                lbxSearch.Items.AddRange(SearcherList.ToArray());
            }
            else if (rdoContains.Checked)
            {
                SearcherList = Searcherlbx.Contains(MasterList, tbxSearch.Text.ToLower());

                lbxSearch.Items.Clear();
                lbxSearch.Items.AddRange(SearcherList.ToArray());
            }

            else
            {
                MessageBox.Show("Fail level, OVER 9000!!!");
            }
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            FileManager filemanagersave = new FileManager();
            Person personS = (Person)lbxSearch.SelectedItem;
            filemanagersave.SavePerson(personS);

        }

    }
   
}
