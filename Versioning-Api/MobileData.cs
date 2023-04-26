using Versioning_Api.Models.Domain;

namespace Versioning_Api
{
    public class MobileData
    {
        public static List<Mobile> Get()
        {
            var mobiles = new[]
            {
                new {Id=1, Name="Apple"},
                new {Id=2, Name="Oneplus"},
                new {Id=3, Name="Samsung"},
                new {Id=4, Name="Redmi"},
                new {Id=5, Name="Vivo"},
                new {Id=6, Name="oppo"},
                new {Id=7, Name="Realme"},
                new {Id=8, Name="Iqoo"}

            };
            return mobiles.Select(m=> new Mobile { Id=m.Id, Name=m.Name }).ToList();
        }
    }
}
