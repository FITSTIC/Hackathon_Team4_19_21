using System;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Personale
    {
        [Key]
        public int IdPers { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascita { get; set; }
        public DateTime DataAssunzione { get; set; }
        [Required]
        public int NumTelefono { get; set; }
        public enum Tipo { Coordinatore, Docente, Tutor }
    }

}