using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whishListG5.Contexts;
using whishListG5.Domains;
using whishListG5.Interfaces;

namespace whishListG5.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        wishListContext ctx = new wishListContext();

        /// <summary>
        /// Todo o CRUD foi implementado no projeto propositalmente, para caso haja a necessidade ou vontade de refiná-lo futuramente por qualquer parte idealizadora
        /// </summary>
        /// 

        public void Atualizar(int id, Desejo desejoAtualizado)
        {
            Desejo desejoBuscado = ctx.Desejos.Find(id);

            if (desejoAtualizado.Desejo1 != null)
            {
                desejoBuscado.Desejo1 = desejoAtualizado.Desejo1;
            }

            ctx.Desejos.Update(desejoBuscado);

            ctx.SaveChanges();
        }

        public Desejo BuscarPorId(int id)
        {
            return ctx.Desejos.FirstOrDefault(d => d.IdDesejo == id);
        }

        /// <summary>
        /// Método que utilizaremos para cadastrar novos desejos
        /// </summary>
        public void Cadastrar(Desejo novoDesejo)
        {
            ctx.Desejos.Add(novoDesejo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Desejo desejoBuscado = ctx.Desejos.Find(id);

            ctx.Desejos.Remove(desejoBuscado);

            ctx.SaveChanges();
        }

        public List<Desejo> Listar()
        {
            return ctx.Desejos.ToList();
        }

        /// <summary>
        /// Método que utilizaremos para a listagem de todos os desejos e seus respectivos idealizadores!!!
        /// </summary>
        /// <returns>retorna uma lista de desejo e os ids dos usuarios</returns>
        public List<Desejo> ListarDesejos()
        {
            return ctx.Desejos.Include(d => d.IdUsuario).ToList();
        }
    }
}
