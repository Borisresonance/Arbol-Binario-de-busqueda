namespace Arbol_Binario_de_busqueda
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        //This var will store passoword 
        private const string CorrectPassword = "UNAD";

        private void Acceso_Load(object sender, EventArgs e)
        { // will get current date in a long format
            Datelb.Text = DateTime.Now.ToLongDateString();
        }

        private void Accessbtn_Click(object sender, EventArgs e)
        {
            //read pass input
            string enteredPassword = txtPassword.Text;

            if (enteredPassword == CorrectPassword)
            {
                // Show a success message (optional)
                MessageBox.Show("Access Granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Close the AccessForm
                this.Hide();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Incorrect Password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
