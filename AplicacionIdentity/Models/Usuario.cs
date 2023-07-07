using Microsoft.AspNetCore.Identity;

namespace AplicacionIdentity.Models
{
    //Herencia
    public class Usuario : IdentityUser
    {
        public string nombres { get; set; }
        public string apellidos { get; set;}
    }
}
