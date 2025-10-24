using Clase2._202025.Entidad;

namespace Clase2._2C2025
{
    public partial class frmReseña : Form
    {
        public frmReseña()
        {
            InitializeComponent();
            cargarPuntuacion();
        }

        private void cargarPuntuacion()
        {
            cboPuntuacion.Items.Clear(); // Limpia los ítems existentes

            cboPuntuacion.Items.Add("1");
            cboPuntuacion.Items.Add("2");
            cboPuntuacion.Items.Add("3");
            cboPuntuacion.Items.Add("4");
            cboPuntuacion.Items.Add("5");
            cboPuntuacion.Items.Add("6");
            cboPuntuacion.Items.Add("7");
            cboPuntuacion.Items.Add("8");
            cboPuntuacion.Items.Add("9");
            cboPuntuacion.Items.Add("10");
            cboPuntuacion.SelectedIndex = 0; // Selecciona el primer ítem por defecto
        }

        private void btnGuardarReseña_Click(object sender, EventArgs e)
        {

            Reseña reseña = new Reseña(
                dtpFecha.Value.ToString("dd/MM/yyyy"),
                txtDireccion.Text,
                cboTipoLocal.SelectedItem.ToString(),
                cboPuntuacion.SelectedItem.ToString()
                );

            //CargarGrillaReseñas(reseña);
            EnviarReseñasAAPI(reseña);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //mostrar un formulario de alta
            frmAlta frmAlta = new frmAlta();
            frmAlta.Show();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerReseñasdeAPI();
        }

        private void CargarGrillaReseñas(Reseña reseña)
        {
            dgvReseñas.Rows.Add(reseña.Fecha,
                reseña.Direccion,
                reseña.TipoLocal,
                reseña.Puntuacion);
        }

        private async Task EnviarReseñasAAPI(Reseña reseña)
        {
            // SERIALIZAR EL OBJETO RESEÑA A JSON
            var json = System.Text.Json.JsonSerializer.Serialize(reseña);

            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            //ENVIAR LA SOLICITUD post A LA API 
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("https://localhost:7211/api/Reseñas", data);
            }
        }

        private async Task ObtenerReseñasdeAPI()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7211/api/Reseñas");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    //var reseñas = System.Text.Json.JsonSerializer.Deserialize<List<Reseña>>(jsonResponse);
                    var reseñas = System.Text.Json.JsonSerializer.Deserialize<List<Reseña>>(jsonResponse,
                                    new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    foreach (var reseña in reseñas)
                    {
                        CargarGrillaReseñas(reseña);
                    }
                }
            }
        }

        
    }
}
