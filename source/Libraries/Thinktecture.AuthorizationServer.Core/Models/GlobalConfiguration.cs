using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Thinktecture.AuthorizationServer.Models
{
    // highlander class
    public class GlobalConfiguration
    {
        [Key]
        public virtual int ID { get; set; }
        [Required]
        public virtual string ASName { get; set; }
        public virtual string ASLogoUrl { get; set; }
        [Required]
        public virtual string Issuer { get; set; }

        public virtual List<ASAdmin> Administrators { get; set; }
    }

    public class ASAdmin
    {
        public int ID { get; set; }
        public string NameID { get; set; }
    }
}
