using System.ComponentModel.DataAnnotations;

namespace Examen_Final
{
    public class Dispositivo
    {
        /* Número de Serie, Marca, Modelo
         * */
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Marca { get; set;}
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Modelo { get; set;}
    }
}
