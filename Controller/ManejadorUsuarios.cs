using DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ManejadorUsuarios
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Username, TextBox Contraseña, TextBox Nombre, TextBox Apellido, ComboBox Nivel)
        {
            MessageBox.Show(f.Guardar($"insert into usuarios (Username, Password, Nombre, Apellido, Nivel) values ('{Username.Text}', sha1('{Contraseña.Text}'), '{Nombre.Text}', '{Apellido.Text}', {Nivel.Text})"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int ID, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from usuarios where id ={ID}");
                MessageBox.Show("Registro eliminado con exito", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox Username, TextBox Contraseña, TextBox Nombre, TextBox Apellido, ComboBox Nivel, int ID)
        {
            MessageBox.Show(f.Modificar($"update usuarios set Username = '{Username.Text}', Password = sha1('{Contraseña.Text}'), Nombre = '{Nombre.Text}', Apellido = '{Apellido.Text}', Nivel = {Nivel.Text} where ID = {ID}"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from v_usuarios where nombre like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.Columns.Insert(6, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(7, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
