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

        /* chequear que el campo mtBox no est� vac�o y/o es correcto con 3 numeros 
         chequear si est� la descripci�n.  MOSTRAR CARTEL SI NO EST� COMPLETO
         si est� el c�digo, "ese c�digo est� ingresado con la inscripcion: "
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
                MessageBox.Show("Falta completar el dato c�digo");
                mtCodigo.Focus();
            }
            else if (tDescripcion.Text.Length < 1)
            {
                MessageBox.Show("Falta completar el dato descripci�n");
                tDescripcion.Focus();
            }
            else
            {

                int posCodigoRepetido = yaExisteCodigo(int.Parse(mtCodigo.Text)); //est� mal declarar una variable ac�?
                if (posCodigoRepetido >= 0) //si es >= a 0,es porque encontr� elemento con codigo
                {
                    MessageBox.Show("El c�digo ya se encuentra ingresado con la descripci�n: " + listadoDescripcion[posCodigoRepetido]);
                    mtCodigo.Focus();
                }
                else devuelve = true;
            }
            return devuelve;
        }

        // Devuelve -1 si no encuentra c�digo. Si lo encuentra, devuelve la position 
        private int yaExisteCodigo(int codigo)
        {
            int devuelve = -1;
            //recorre el arreglo del listado c�digos hasta que no hay mas elementos en el arreglo y no encontr� elemento.
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
