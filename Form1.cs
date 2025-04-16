using System.Net.Security;

namespace Repaso_Disenio_y_Desarrollo
{
    public partial class Form1 : Form
    {
        public int[] listadoCodigos = new int[100];
        public string[] listadoDescripcion = new string[100];
        public string[] listadoMuestra = new string[100];
        public int position = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* chequear que el campo mtBox no está vacío y/o es correcto con 3 numeros 
         chequear si está la descripción.  MOSTRAR CARTEL SI NO ESTÁ COMPLETO
         si está el código, "ese código está ingresado con la inscripcion: "
        -----

        */


        private void bAgregar_Click(object sender, EventArgs e)
        {

            if (chequeoDataEntry())
            {
                listadoCodigos[position] = int.Parse(mtCodigo.Text);
                listadoDescripcion[position] = tDescripcion.Text;
                listadoMuestra[position] = listadoCodigos[position] + " - " + listadoDescripcion[position];
                lbListadoProductos.Items.Add(listadoMuestra[position]); // agrega item al listbox

                position++;
                lCantidadProductos.Text = position+"";

                mtCodigo.ResetText();
                tDescripcion.ResetText();
            }
        }

        private Boolean chequeoDataEntry()
        {
            bool devuelve = false;
            if (mtCodigo.Text.Length < 1)
            {
                MessageBox.Show("Falta completar el dato código");
                mtCodigo.Focus();
            }
            else if (tDescripcion.Text.Length < 1)
            {
                MessageBox.Show("Falta completar el dato descripción");
                tDescripcion.Focus();
            }
            else
            {

                int posCodigoRepetido = yaExisteCodigo(int.Parse(mtCodigo.Text)); //está mal declarar una variable acá?
                if (posCodigoRepetido >= 0) //si es >= a 0,es porque encontró elemento con codigo
                {
                    MessageBox.Show("El código ya se encuentra ingresado con la descripción: " + listadoDescripcion[posCodigoRepetido]);
                    mtCodigo.Focus();
                }
                else devuelve = true;
            }
            return devuelve;
        }

        // Devuelve -1 si no encuentra código. Si lo encuentra, devuelve la position 
        private int yaExisteCodigo(int codigo)
        {
            int devuelve = -1;
            //recorre el arreglo del listado códigos hasta que no hay mas elementos en el arreglo y no encontró elemento.
            for (int i = 0; i <= position && devuelve < 0; i++)
            {
                if (listadoCodigos[i] == int.Parse(mtCodigo.Text))
                {
                    devuelve = i;
                }
            }
            return devuelve;
        }
    }
}
