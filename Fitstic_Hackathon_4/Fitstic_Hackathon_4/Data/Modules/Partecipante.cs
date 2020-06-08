using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Partecipante
    {
        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }               
        public string Citta { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }                
        public string TipoDiploma { get; set; } //proposta: inserimento lista enum di titoli esistenti
        public DateTime AnnoDiploma { get; set; }

        public Partecipante()
        {

        }
    }
}