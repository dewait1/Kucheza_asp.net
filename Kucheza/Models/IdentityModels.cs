using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Kucheza.Models
{
    // Możesz dodać dane profilu dla użytkownika, dodając więcej właściwości do klasy ApplicationUser. Odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=317594, aby dowiedzieć się więcej.
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Numer telefonu")]
        public string miasto { get; set; }

        [Display(Name = "Opis")]
        public string opis { get; set; }

        [Display(Name = "Wiek")]
        public int wiek { get; set; }

        [Display(Name = "dd")]
        public int dzienUrodzin { get; set; }

        [Display(Name = "mm")]
        public int miesiacUrodzin { get; set; }

        [Display(Name = "rr")]
        public int rokUrodzin { get; set; }

        [Display(Name = "Praca")]
        public string aktualnaPraca { get; set; }

        [Display(Name = "Płeć")]
        public string plec { get; set; }

        [Display(Name = "Wyznanie")]
        public string religia { get; set; }
        public string opcjaPolityczna { get; set; }
        public string ulubionyCytat { get; set; }
        public string wyksztalcenie { get; set; }
        public string zdjecieProfilowe { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }

        public enum Gender
        {
            Male,
            Female
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

  
}