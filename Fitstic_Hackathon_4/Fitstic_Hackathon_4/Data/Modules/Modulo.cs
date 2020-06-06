using System;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Modulo
    {
        [Key]
        public int IdModulo { get; set; }
        [Required]
        public string Nome { get; set; }        
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }        
        public string Materia { get; set; }
        public int IdTutor { get; set; }
        public int IdDocente { get; set; }
        public int IdCorso { get; set; }
    }
}