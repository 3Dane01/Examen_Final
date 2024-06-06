using System.ComponentModel.DataAnnotations;

namespace Examen_Final
{
    public class Tablet : Dispositivo
    {
        /*Tamaño de Pantalla: el tamaño de la pantalla en pulgadas.
Soporte para Stylus: indica si la tablet tiene soporte para lápiz óptico.*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string TamañoPantalla {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Soporte { get; set; }
        
    }
}
