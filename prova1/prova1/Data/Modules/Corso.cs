using System;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Corso
    {
        [Key]
        public int IdCorso { get; set; }
        public string Nome { get; set; }
        public string AnnoAccademico { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Sede { get; set; }
        public int IdOrganizzatore { get; set; }
    }
}