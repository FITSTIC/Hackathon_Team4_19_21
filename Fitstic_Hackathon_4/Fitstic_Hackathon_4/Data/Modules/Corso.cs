using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace prova1.Data
{
    public class Corso
    {
        [Key]
        public int IdCorso { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string AnnoAccademico { get; set; } //ad.es. 2019-2021
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Sede { get; set; }
        public int IdOrganizzatore { get; set; }
        public List<Modulo> ListaModuli { get; set; }
    }
}