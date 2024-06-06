using System.ComponentModel.DataAnnotations;

namespace Examen_Final
{
    public class Laptop:Dispositivo
    {
        /*Memoria RAM: la cantidad de memoria RAM en GB.
Almacenamiento: la capacidad de almacenamiento en GB.*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Memoria { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Almacenamiento { get; set; }
    }
}
