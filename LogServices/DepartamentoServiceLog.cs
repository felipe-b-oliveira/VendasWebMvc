using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendasWebMvc.Models;
using vendasWebMvc.Services;
using Microsoft.EntityFrameworkCore;

namespace vendasWebMvc.LogServices
{
    public class DepartamentoServiceLog : IDepartamentoService
    {
        protected DepartamentoService DepartamentoServiceOriginal { get; set; }

        public DepartamentoServiceLog()
        {
            DepartamentoServiceOriginal = new DepartamentoService(new VendasWebMvcContext(new DbContextOptions<VendasWebMvcContext>()));
        }

        public bool DepartamentoExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Departamento>> FindAllAsync()
        {
            Console.WriteLine("Log entrou no FindAllAsync");

            var r = DepartamentoServiceOriginal.FindAllAsync();

            Console.WriteLine("Log terminou FindAllAsync");

            return r;
        }

        public Task<Departamento> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Departamento obj)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Departamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
