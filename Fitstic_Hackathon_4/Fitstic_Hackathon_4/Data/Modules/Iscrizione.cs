using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Iscrizione
    {        
        public int Id { get; set; }
        [Required]
        public DateTime DataIscrizione { get; set; }        
        public int CorsoId { get; set; }        
        public int PartecipanteId{ get; set; }

        public Iscrizione()
        {

        }
    }
        
} 