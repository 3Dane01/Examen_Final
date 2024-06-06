using System.ComponentModel.DataAnnotations;

namespace Examen_Final
{
    public class Smartphone : Dispositivo
    {
        /*Sistema Operativo: el sistema operativo del smartphone (Android, iOS, etc.).
Número de Cámaras: la cantidad de cámaras que tiene el smartphone.*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string SistemaOperativo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string NumeroCamaras { get; set; }
    }
}
