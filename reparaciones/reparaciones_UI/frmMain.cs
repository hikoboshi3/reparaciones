using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Modelos.Entidades;
using System.Drawing.Printing;
using System.Reflection;

namespace reparaciones_UI
{
    public partial class frmMain : Form
    {
        RDN bll = new RDN();
        long _idVehiculo = 0;
        Presupuesto _presupuesto = new Presupuesto();
        List<Desperfecto> _desperfectos = new List<Desperfecto>();

        #region Inicializar
        public frmMain()
        {
            InitializeComponent();
        }
            private void frmMain_Load(object sender, EventArgs e)
            {
                cboTipo.DataSource = Enum.GetValues(typeof(TipoAutomovil));
                SetGrillaDesperfectos();
                SetGrillaRepuestos();
                CargarRepuestos();
            }
            private void CargarRepuestos()
            {
                BLL.ApiCaller api = new BLL.ApiCaller();
                string json  = api.GetRepuestos();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                foreach(DataRow row in dt.Rows)
                {
                    dgRepuestos.Rows.Add(row["Id"].ToString(), row["Nombre"].ToString(), row["Precio"].ToString());
                }
            }

            private void SetGrillaDesperfectos()
            {
                dgDesperfectos.ColumnCount = 4;

                dgDesperfectos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dgDesperfectos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgDesperfectos.ColumnHeadersDefaultCellStyle.Font = new Font(dgDesperfectos.Font, FontStyle.Bold);
                dgDesperfectos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                dgDesperfectos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgDesperfectos.GridColor = Color.DarkSlateBlue;
                dgDesperfectos.RowHeadersVisible = false;

                dgDesperfectos.Columns[0].Name = "Id";
                dgDesperfectos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgDesperfectos.Columns[0].Width = 0;
                dgDesperfectos.Columns[0].Visible = false;
                dgDesperfectos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgDesperfectos.Columns[1].Name = "Descripción";
                dgDesperfectos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgDesperfectos.Columns[1].Width = 250;
                dgDesperfectos.Columns[1].Visible = true;
                dgDesperfectos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgDesperfectos.Columns[2].Name = "Mano de Obra";
                dgDesperfectos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgDesperfectos.Columns[2].Width = 80;
                dgDesperfectos.Columns[2].Visible = true;
                dgDesperfectos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgDesperfectos.Columns[3].Name = "Tiempo";
                dgDesperfectos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgDesperfectos.Columns[3].Width = 80;
                dgDesperfectos.Columns[3].Visible = true;
                dgDesperfectos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            private void SetGrillaRepuestos()
            {
                dgRepuestos.ColumnCount = 3;

                dgRepuestos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dgRepuestos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgRepuestos.ColumnHeadersDefaultCellStyle.Font = new Font(dgRepuestos.Font, FontStyle.Bold);
                dgRepuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                dgRepuestos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgRepuestos.GridColor = Color.DarkSlateBlue;
                dgRepuestos.RowHeadersVisible = false;

                dgRepuestos.Columns[0].Name = "Id";
                dgRepuestos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgRepuestos.Columns[0].Width = 0;
                dgRepuestos.Columns[0].Visible = false;
                dgRepuestos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgRepuestos.Columns[1].Name = "Nombre";
                dgRepuestos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgRepuestos.Columns[1].Width = 100;
                dgRepuestos.Columns[1].Visible = true;
                dgRepuestos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgRepuestos.Columns[2].Name = "Precio";
                dgRepuestos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgRepuestos.Columns[2].Width = 100;
                dgRepuestos.Columns[2].Visible = true;
                dgRepuestos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                check.Width = 90;
                check.Name = "Agregar";
                dgRepuestos.Columns.Add(check);

            }

        #endregion

        #region Vehiculo

        private void optAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (optAuto.Checked)
            {
                panMoto.Visible = false;
                panAuto.Visible = true;
            }
            else
            {
                panMoto.Visible = true;
                panAuto.Visible = false;
            }
        }

        private void optMoto_CheckedChanged(object sender, EventArgs e)
            {
                if (optAuto.Checked)
                {
                    panMoto.Visible = false;
                    panAuto.Visible = true;
                }
                else
                {
                    panMoto.Visible = true;
                    panAuto.Visible = false;
                }
            }

            private void btnAddVehiculo_Click(object sender, EventArgs e)
            {

            if (string.IsNullOrWhiteSpace(txtMarca.Text) 
                || string.IsNullOrWhiteSpace(txtModelo.Text) 
                || string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if ((string.IsNullOrWhiteSpace(txtPuertas.Text) || cboTipo.SelectedItem == null)
                && string.IsNullOrWhiteSpace(txtCilindrada.Text))
            {
                //campos exclusivos de un tipo de vehículo u otro
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }


            BLL.ApiCaller api = new BLL.ApiCaller();

                if (optAuto.Checked)
                {
                    Automovil auto = new Automovil();
                    auto.marca = txtMarca.Text;
                    auto.modelo = txtModelo.Text;
                    auto.patente = txtPatente.Text;
                    auto.tipo = (int)Enum.Parse(typeof(TipoAutomovil), cboTipo.SelectedItem.ToString());
                    auto.cantidad_puertas = Convert.ToInt16(txtPuertas.Text);

                    _idVehiculo = api.IngresarAutomovil(auto);
                    if (_idVehiculo > 0)
                    {
                        txtMarcaTitle.Text = auto.marca;
                        txtModelo.Text = auto.modelo;
                        txtPatenteTitle.Text = auto.patente;
                        tabMain.SelectedTab = tabPage2;
                    }
                }
                else
                {
                    Moto moto = new Moto();
                    moto.marca = txtMarca.Text;
                    moto.modelo = txtModelo.Text;
                    moto.patente = txtPatente.Text;
                    moto.cilindrada = txtCilindrada.Text;

                    _idVehiculo = api.IngresarMoto(moto);

                    if(_idVehiculo > 0)
                    {
                        txtMarcaTitle.Text = moto.marca;
                        txtModelo.Text = moto.modelo;
                        txtPatenteTitle.Text = moto.patente;
                        txtCilindrada.Text = "";
                        tabMain.SelectedTab = tabPage2;
                    }
                }

            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPatente.Text = "";
            cboTipo.SelectedItem = null;
            txtPuertas.Text = "";


        }
        #endregion

        #region Desperfecto
            private void btnAddDesperfecto_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtManoDeObra.Text)
                || string.IsNullOrWhiteSpace(txtNombre.Text)
                || string.IsNullOrWhiteSpace(txtApellido.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }


                List<Repuesto> _repuestos = new List<Repuesto>();
                try
                {
                    if(dgRepuestos.Rows.Count >= 1)
                    { 
                        foreach (DataGridViewRow row in dgRepuestos.Rows)
                        {
                            DataGridViewCheckBoxCell cell = row.Cells[3] as DataGridViewCheckBoxCell;
                            if (cell.Value != null)
                            {
                                try
                                {
                                    if((bool)cell.Value == true)
                                    {
                                        //Agrego el repuesto
                                        //No hacen falta más datos que el ID. Luego vemos, por ahora los mando...
                                        Repuesto _repuesto = new Repuesto();
                                        _repuesto.IdRepuesto = Convert.ToInt32(row.Cells[0].Value.ToString());
                                        _repuesto.Nombre = row.Cells[1].Value.ToString();
                                        _repuesto.Precio = Convert.ToDecimal(row.Cells[2].Value.ToString());
                                        _repuestos.Add(_repuesto);
                                    }

                                }
                                catch
                                {
                                    //...por las dudas...
                                }

                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                }

                if (_repuestos.Count == 0)
                {
                    if(MessageBox.Show ("Confirma que no se necesitan repuestos?", "Confirmar",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                }
                dgDesperfectos.Rows.Add("0", 
                    txtDescripcion.Text, 
                    txtManoDeObra.Text,
                    numDias.Value);

                Modelos.Entidades.Desperfecto _falla = new Desperfecto
                {
                    Descripcion = txtDescripcion.Text,
                    ManoDeObra = Convert.ToDecimal(txtManoDeObra.Text),
                    Tiempo = Convert.ToInt32(numDias.Value),
                    Repuestos = _repuestos
                };

                _desperfectos.Add(_falla);

                // Deschequeamos....
                try
                {
                    if (dgRepuestos.Rows.Count >= 1)
                    {
                        foreach (DataGridViewRow row in dgRepuestos.Rows)
                        {
                            DataGridViewCheckBoxCell cell = row.Cells[3] as DataGridViewCheckBoxCell;
                            if (cell.Value != null)
                            {
                                try
                                {
                                    cell.Value = null;
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }

                txtDescripcion.Text = "";
                txtManoDeObra.Text ="";
                numDias.Value= 1;
            }

        #endregion

        #region Validaciones
        private void txtPuertas_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPuertas.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Solo números, por favor.");
                txtPuertas.Text = string.Empty;
            }
        }

        private void txtManoDeObra_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtManoDeObra.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Solo números, por favor.");
                txtManoDeObra.Text = string.Empty;
            }
        }

        #endregion

        #region Acciones

            private void btnCargarPresupuesto_Click(object sender, EventArgs e)
            {

            if (_idVehiculo == 0)
            {
                //campos exclusivos de un tipo de vehículo u otro
                MessageBox.Show("Debe cargar el vehículo para hacer un presupuesto.");
                return;

            }

                _presupuesto.Nombre = txtNombre.Text;
                _presupuesto.Apellido = txtApellido.Text;
                _presupuesto.Email = txtEmail.Text;
                _presupuesto.IdVehiculo = _idVehiculo;
                //Armamos el Presupuesto
                _presupuesto.Fallas = _desperfectos;

                long _idPresupuesto = bll.CrearPresupuesto(_presupuesto);

                printer = new PrintDocument();
                PrinterSettings _ps = new PrinterSettings();
                printer.PrinterSettings = _ps;
                printer.PrintPage += Imprimir;
                printer.Print();

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                dgDesperfectos.Rows.Clear();
                txtMarcaTitle.Text = "";
                txtModeloTitle.Text = "";
                txtPatenteTitle.Text = "";

            }
            private void Imprimir(object sender, PrintPageEventArgs e)
            {
                Font _fontTitulo = new Font("Arial", 12);
                Font _font = new Font("Arial", 10);
                int ancho = 600;
                int Y = 30;
                int i = 30;

                e.Graphics.DrawString("PRESUPUESTO Nro.: " + _presupuesto.Id.ToString(), _fontTitulo, Brushes.Black, new RectangleF(10, Y + 20, ancho, 20));
                e.Graphics.DrawString(DateTime.Today.ToString(), _font, Brushes.Black, new RectangleF(10, Y + 60, ancho, 20));
                e.Graphics.DrawString(_presupuesto.Nombre + " " + _presupuesto.Apellido, _font, Brushes.Black, new RectangleF(10, Y + 80, ancho, 20));

                e.Graphics.DrawString("DETALLE", _fontTitulo, Brushes.Black, new RectangleF(10, Y + 120, ancho, 20));

                foreach (Desperfecto _des in _desperfectos)
                {
                    e.Graphics.DrawString(_des.Descripcion, _font, Brushes.Black, new RectangleF(10, 150 + i, ancho, 20));
                    i += 20;
                }

                e.Graphics.DrawString("______________________________", _font, Brushes.Black, new RectangleF(10, 160 + i, ancho, 20));

                e.Graphics.DrawString("TOTAL: $ " + _presupuesto.Total.ToString(), _fontTitulo, Brushes.Black, new RectangleF(10, 180 + i, ancho, 20));
            }


        #endregion


    }
}

