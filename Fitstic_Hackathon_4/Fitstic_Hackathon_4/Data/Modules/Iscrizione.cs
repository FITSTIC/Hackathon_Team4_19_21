using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Iscrizione
    {        
        public int Id { get; set; }        
        public DateTime DataIscrizione { get; set; }        
        [Required]
        public int CorsoId { get; set; }        
        public Corso Corso { get; set; }
        [Required]
        public int PartecipanteId{ get; set; }
        public Partecipante Partecipante { get; set; }

        public Iscrizione()
        {

        }
    }
        
} 