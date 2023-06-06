namespace ОАИП_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AppDbContext con=new AppDbContext();
            //con.Database.EnsureDeleted();
            //con.Database.EnsureCreated();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Client user;
            using (var context = new AppDbContext())
            {
                var email = textBox_email.Text;
                var password = textBox_pass.Text;

                user = context.Clients.FirstOrDefault(u => u.Email == email && u.Password == password);
            }


            if (user != null)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(new AppDbContext(), user);
                Hide();
                mainForm.ShowDialog();

                DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Close();
                else if (dialogResult == DialogResult.No)
                    Show();
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regestr registrationForm = new Regestr(new AppDbContext());
            Hide();
            registrationForm.ShowDialog();
            Show();
        }
    }
}