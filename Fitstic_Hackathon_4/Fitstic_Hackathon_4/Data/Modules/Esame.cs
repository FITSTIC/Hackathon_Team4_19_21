using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Esame
    {        
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public int Punteggio { get; set; }
        [Required]
        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; }
        [Required]
        public int PartecipanteId { get; set; }
        public Partecipante Partecipante { get; set; }

        public Esame()
        {

        }
    }

}