using System;
using System.Collections.Generic;
using teste01.Domains.Models;
using teste01.Infra.Repositories;

namespace teste01.Domains.Services
{
    public class FerramentaService: IFerramentaService
    {
        private readonly IRepository _repository;

        public FerramentaService(IRepository repository)
        {
            _repository = repository;
        }

        public FerramentaModel GetFerramentaModel(int id) 
        {
            var sql = "Select * from ferramenta where id = @id";

            return _repository.QueryFirst<FerramentaModel>(sql, new {id = id});
        }

        public IEnumerable<FerramentaModel> GetAllFerramentaModel()
        {
            var sql = "Select * from ferramenta";
            
            return _repository.Query<FerramentaModel>(sql);
        }

        public bool AddFerramenta(FerramentaModel model)
        {
            var sql = "Insert into ferramenta (id, nome) values (@id, @nome)";
            
            return _repository.Execute(sql, new {
                id = model.Id, 
                nome = model.Nome
            });
        }
    }
}
