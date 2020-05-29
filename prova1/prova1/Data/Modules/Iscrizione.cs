using System;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Iscrizione
    {
        [Key]
        public int IdIscrizione { get; set; }
        [Required]
        public DateTime DataIscrizione { get; set; }        
        public int IdCorso { get; set; }        
        public int IdPartecipante { get; set; }

    }
        
} 