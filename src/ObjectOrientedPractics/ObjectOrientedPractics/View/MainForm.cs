using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {   
            InitializeComponent();
            ItemsTab1.Items = _store.Items;
            CustomersTab1.Customers = _store.Customers;

            CartsTab1.Items = _store.Items;
            CartsTab1.Customers = _store.Customers;
        }
    }
}
