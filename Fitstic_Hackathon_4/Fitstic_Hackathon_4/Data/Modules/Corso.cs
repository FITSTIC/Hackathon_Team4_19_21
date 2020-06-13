using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Corso
    {        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string AnnoAccademico { get; set; } //ad.es. 2019-2021
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Sede { get; set; }
        public int? OrganizzatoreId { get; set; }
        public Organizzatore Organizzatore { get; set; }
        public List<Modulo> ListaModuli { get; set; }
        public List<Partecipante> ListaPartecipanti { get; set; }

        public Corso()
        {

        }
    }
}