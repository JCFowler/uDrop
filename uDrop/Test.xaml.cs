using System;
using System.Collections.ObjectModel;
using uDrop.Database;
using uDrop.Model;
using Xamarin.Forms;

namespace uDrop
{
    public partial class Test : ContentPage
    {
        ObservableCollection<Computer> obs = new ObservableCollection<Computer>();
        DBFire db;

        public Test()
        {
            InitializeComponent();
            _lst.BindingContext = obs;

            db = new DBFire();

            _lst.IsRefreshing = true;
            updateTable();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Computer c = (Computer)e.SelectedItem;
            name.Text = c.fullname;
            power.Text = c.hardwarePower.ToString();
        }

        async void add_Clicked(object sender, System.EventArgs e)
        {
            _lst.IsRefreshing = true;

            Computer c = new Computer();
            c.id = String.Empty;
            c.fullname = name.Text;
            c.hardwarePower = Int32.Parse(power.Text);

            await db.addComputer(c);

            updateTable();

            name.Text = "";
            power.Text = "";
        }

        async void delete_Clicked(object sender, System.EventArgs e)
        {
            if (_lst.SelectedItem != null)
            {
                _lst.IsRefreshing = true;
                await db.deleteComputer((Computer)_lst.SelectedItem);
                updateTable();
            }
        }

        async void edit_Clicked(object sender, System.EventArgs e)
        {
            if (_lst.SelectedItem != null)
            {
                _lst.IsRefreshing = true;

                var c = (Computer)_lst.SelectedItem;
                c.fullname = name.Text;
                c.hardwarePower = Int32.Parse(power.Text);

                await db.editComputer(c);
                updateTable();
            }
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            updateTable();
        }

        async void updateTable()
        {
            var dblit = await db.getList();

            obs.Clear();

            foreach (var item in dblit)
            {
                obs.Add(item);
            }

            _lst.IsRefreshing = false;
        }
    }
}
