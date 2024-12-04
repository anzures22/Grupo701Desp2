using Grupo701Desp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grupo701Desp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private UTRNGEntities db = new UTRNGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                alumnos nuevoAlumno = new alumnos
                {
                    Matricula = long.Parse(TextBox1.Text), 
                    Telefono = TextBox3.Text,
                    CorreoE = TextBox4.Text
                };

                
                db.alumnos.Add(nuevoAlumno);
                db.SaveChanges();

                
                Response.Write("Alumno agregado con éxito.");
            }
            catch (Exception ex)
            {
                
                Response.Write("Ocurrió un error: " + ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                long matricula = long.Parse(TextBox1.Text);

                
                alumnos alumno = db.alumnos.Find(matricula);

                if (alumno != null)
                {
                    
                    TextBox2.Text = alumno.NombreC;
                    TextBox3.Text = alumno.Telefono;
                    TextBox4.Text = alumno.CorreoE;
                }
                else
                {
                    
                    Response.Write("No se encontró ningún alumno con esa matrícula.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Response.Write("Ocurrió un error: " + ex.Message);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la matrícula ingresada
                long matricula = long.Parse(TextBox1.Text);

                // Buscar el alumno en la base de datos
                alumnos alumno = db.alumnos.Find(matricula);

                if (alumno != null)
                {
                    // Actualizar los datos del alumno
                    alumno.NombreC = TextBox2.Text;
                    alumno.Telefono = TextBox3.Text;
                    alumno.CorreoE = TextBox4.Text;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();

                    // Mostrar un mensaje de éxito
                    Response.Write("Datos del alumno actualizados con éxito.");
                }
                else
                {
                    // Si no se encuentra, mostrar un mensaje
                    Response.Write("No se encontró ningún alumno con esa matrícula.");
                }
            }
            catch (Exception ex)
            {
                
                Response.Write("Ocurrió un error: " + ex.Message);
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                long matricula = long.Parse(TextBox1.Text);

                
                alumnos alumno = db.alumnos.Find(matricula);

                if (alumno != null)
                {
                   
                    db.alumnos.Remove(alumno);
                    db.SaveChanges();

                    
                    Response.Write("Alumno eliminado con éxito.");
                }
                else
                {
                    
                    Response.Write("No se encontró ningún alumno con esa matrícula.");
                }
            }
            catch (Exception ex)
            {
                
                Response.Write("Ocurrió un error: " + ex.Message);
            }
        }
    }
}