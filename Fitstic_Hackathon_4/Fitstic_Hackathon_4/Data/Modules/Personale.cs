using System;
using System.ComponentModel.DataAnnotations;


namespace Fitstic_Hackathon_4.Data
{
    public class Personale
    {        
        public int Id{ get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascita { get; set; }
        public DateTime DataAssunzione { get; set; }
        [Required]
        public int NumTelefono { get; set; }
                
        public Personale()
        {

        }
    }

    public class Docente : Personale
    {

        public Docente()
        {

        }
    }

    public class Organizzatore : Personale
    {

        public Organizzatore()
        {

        }
    }

    public class Tutor : Personale
    {

        public Tutor()
        {

        }
    }


}