using Capa_Persicstencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica13{
    public partial class Tabla : Form
    {
        CD_Productos productos = new CD_Productos();
        private bool esNuevo = false;
        private int idProductoSeleccionado = 0;
        public Tabla()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void ConfigurarControles()
        {
            dataGridView1.AutoGenerateColumns = true;

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            dataGridView1.SelectionChanged += DataGridViewProductos_SelectionChanged;
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = productos.Mostrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        productos.Eliminar(idProductoSeleccionado);
                        MessageBox.Show("Producto eliminado correctamente");
                        CargarDatos();
                        LimpiarControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    string nombre = txtNombre.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();
                    string marca = txtMarca.Text.Trim();
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    int stock = Convert.ToInt32(txtStock.Text);

                    if (esNuevo)
                    {
                        productos.Insertar(nombre, descripcion, marca, precio, stock);
                        MessageBox.Show("Producto agregado correctamente");
                    }
                    else
                    {
                        productos.Editar(nombre, descripcion, marca, precio, stock, idProductoSeleccionado);
                        MessageBox.Show("Producto actualizado correctamente");
                    }

                    CargarDatos();
                    LimpiarControles();
                    esNuevo = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}");
                }
            }
        }
        private void DataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                esNuevo = false;
                idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            idProductoSeleccionado = 0;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text) || !double.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Ingrese un precio válido");
                txtPrecio.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtStock.Text) || !int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("Ingrese una cantidad de stock válida");
                txtStock.Focus();
                return false;
            }

            return true;
        }
    }
}