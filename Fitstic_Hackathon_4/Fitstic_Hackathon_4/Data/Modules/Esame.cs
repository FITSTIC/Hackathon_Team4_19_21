using System;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Esame
    {
        [Key]
        public int IdEsame { get; set; }
        public DateTime Data { get; set; }
        public int Punteggio { get; set; }
        [Required]
        public int IdModulo { get; set; }
        public int IdPartecipante { get; set; }

    }

}