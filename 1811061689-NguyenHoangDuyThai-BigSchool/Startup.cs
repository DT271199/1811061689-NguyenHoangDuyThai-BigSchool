using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811061689_NguyenHoangDuyThai_BigSchool.Startup))]
namespace _1811061689_NguyenHoangDuyThai_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
