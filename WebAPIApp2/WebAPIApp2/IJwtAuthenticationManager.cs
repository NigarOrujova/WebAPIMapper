
namespace WebAPIApp2
{
    public interface IJwtAuthenticationManager
    {
       string Authenticate(string username, string password);
    }
}
