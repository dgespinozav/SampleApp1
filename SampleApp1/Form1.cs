namespace SampleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
        }

        public string mensaje_res (string _mensaje)
        {
            string mensaje;


            if (_mensaje == "hola")
            {
                mensaje = "hola bienvenido " + DateTime.Now;
            } else {
                mensaje = "hasta luego " + DateTime.Now;
            }


          

            return mensaje;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i;
            string j;
            decimal o = numericUpDown1.Value;
            string retorno;

            i = "hola";
            j = "adios";


            if (o == 0)
            {
                retorno = this.mensaje_res(i);
                MessageBox.Show(retorno);
            }
            else
            {
                retorno = this.mensaje_res(j);
                MessageBox.Show(retorno);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0  || numericUpDown1.Value > 1)
            {
                numericUpDown1.Value = 0;

            }
        }


    }
}