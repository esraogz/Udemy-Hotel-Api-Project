using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
    public class CreateToken
    {
        public string TokenCreate()
        {
            //JWT Token Örneği : xxxxx.yyyyy.zzzzz
            //                   ----- ----- -----
            //                   Header Payload Signature

            //Signature : Token ı mühürlerken kullanılacak gizli kelimeyi byte a çevirip güvenlik anahtarı nesnesine dönüştürür.
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapiauthenticationsecretkey");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            //Header : Hangi keyi hangi algortimaya göre şifreleyeceğini sölüyor.
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Tokenın tamamı
            JwtSecurityToken token = new JwtSecurityToken(issuer: "https://localhost",
                                                          audience: "https://localhost",
                                                          notBefore: DateTime.Now, 
                                                          expires: DateTime.Now.AddSeconds(20), 
                                                          signingCredentials: credentials);

            
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token); //Yukarıda oluşan tokenı xxxxx.yyyyy.zzzzz bu formata dönüştürür
        }

        public string TokenCreateAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapiauthenticationsecretkey");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Role,"Visitor"),
            };

            JwtSecurityToken token = new JwtSecurityToken(issuer: "https://localhost",
                                                          audience: "https://localhost",
                                                          notBefore: DateTime.Now,
                                                          expires: DateTime.Now.AddSeconds(20),
                                                          claims: claims,
                                                          signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);

        }
    }
}
