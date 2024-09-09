using ClinicServiceNamespase;

namespace ClinicDesctop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbButton_Click(object sender, EventArgs e)
        {
            ClinicClient cliclClient = new ClinicClient(
                "https://localhost:7183/", new HttpClient());
            ICollection<Client> clients = cliclClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();

            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                listViewClients.Items.Add(item);
            }
        }

    }
}
