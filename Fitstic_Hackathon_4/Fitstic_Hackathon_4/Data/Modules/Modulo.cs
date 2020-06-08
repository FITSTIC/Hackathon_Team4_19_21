using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Modulo
    {
        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }        
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }        
        public string Materia { get; set; }
        public int TutorId { get; set; }        
        public int DocenteId { get; set; }
        public int CorsoId { get; set; }

        public Modulo()
        {

        }
    }
}