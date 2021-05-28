using IptvSaless.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IptvSaless.Startup))]
namespace IptvSaless
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
            createRole();
           createUser();
        }
        public void createUser() {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.UserName = "testadmin";
            user.Email = "TestAdmin@web.ci";
            var check = userManager.Create(user,"1234");
            if (check.Succeeded) {
                userManager.AddToRole(user.Id,"admin");
            }
        }
        public void createRole() {
        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role;
            if (!roleManager.RoleExists("admin")) {
                role = new IdentityRole();
                role.Name = "admin";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("anonymous"))
            {
                role = new IdentityRole();
                role.Name = "anonymous";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("user"))
            {
                role = new IdentityRole();
                role.Name = "user";
                roleManager.Create(role);
            }
        }
    }
}
