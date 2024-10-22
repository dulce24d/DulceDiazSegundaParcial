using System.ComponentModel.DataAnnotations;

namespace DulceDiazSegundaParcial.Model
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser mayor a cero.")]

        public int Numero { get; set; }
        [Required(ErrorMessage = "El nombre no debe ser vacio")]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string Departamento { get; set; }
    }
}