using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendasWebMvc.Models;
using vendasWebMvc.Services;

namespace vendasWebMvc.TestData
{
    /*public class DepartamentoServiceTestData : IDepartamentoService
    {
        protected List<Departamento> Departamentos { get; } = new List<Departamento>(
            new Departamento[]
            {
                new Departamento
                {
                    Id = 1,
                    Nome = "RH",
                    Vendedores = new List<Vendedor>(
                        new Vendedor[]
                        {
                            new Vendedor
                            {
                                Id = 1,
                                Nome = "Mariana",
                                Email = "mari@net.com",
                                SalarioBase = 1500
                            },
                            new Vendedor
                            {
                                Id = 24,
                                Nome = "Tricolor",
                                SalarioBase = 2424,
                                Email = "tricoleti@net.com"
                            }
                        }
                    )
                }
            }
        );

        public bool DepartamentoExists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return Departamentos;
        }

        public async Task<Departamento> FindByIdAsync(int id) => Departamentos.FirstOrDefault(d => d.Id == id);

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
    }*/
}
