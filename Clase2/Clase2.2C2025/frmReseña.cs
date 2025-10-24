using Clase2._202025.Entidad;

namespace Clase2._2C2025
{
    public partial class frmRese�a : Form
    {
        public frmRese�a()
        {
            InitializeComponent();
            cargarPuntuacion();
        }

        private void cargarPuntuacion()
        {
            cboPuntuacion.Items.Clear(); // Limpia los �tems existentes

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
            cboPuntuacion.SelectedIndex = 0; // Selecciona el primer �tem por defecto
        }

        private void btnGuardarRese�a_Click(object sender, EventArgs e)
        {

            Rese�a rese�a = new Rese�a(
                dtpFecha.Value.ToString("dd/MM/yyyy"),
                txtDireccion.Text,
                cboTipoLocal.SelectedItem.ToString(),
                cboPuntuacion.SelectedItem.ToString()
                );

            //CargarGrillaRese�as(rese�a);
            EnviarRese�asAAPI(rese�a);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //mostrar un formulario de alta
            frmAlta frmAlta = new frmAlta();
            frmAlta.Show();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerRese�asdeAPI();
        }

        private void CargarGrillaRese�as(Rese�a rese�a)
        {
            dgvRese�as.Rows.Add(rese�a.Fecha,
                rese�a.Direccion,
                rese�a.TipoLocal,
                rese�a.Puntuacion);
        }

        private async Task EnviarRese�asAAPI(Rese�a rese�a)
        {
            // SERIALIZAR EL OBJETO RESE�A A JSON
            var json = System.Text.Json.JsonSerializer.Serialize(rese�a);

            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            //ENVIAR LA SOLICITUD post A LA API 
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("https://localhost:7211/api/Rese�as", data);
            }
        }

        private async Task ObtenerRese�asdeAPI()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7211/api/Rese�as");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    //var rese�as = System.Text.Json.JsonSerializer.Deserialize<List<Rese�a>>(jsonResponse);
                    var rese�as = System.Text.Json.JsonSerializer.Deserialize<List<Rese�a>>(jsonResponse,
                                    new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    foreach (var rese�a in rese�as)
                    {
                        CargarGrillaRese�as(rese�a);
                    }
                }
            }
        }

        
    }
}
