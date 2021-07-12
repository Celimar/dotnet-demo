using System.Collections.Generic;
using teste01.Domains.Models;

namespace teste01.Domains.Services
{
    public interface IFerramentaService
    {
        FerramentaModel GetFerramentaModel(int id);
        IEnumerable<FerramentaModel> GetAllFerramentaModel();
        bool AddFerramenta(FerramentaModel model);
    }
}