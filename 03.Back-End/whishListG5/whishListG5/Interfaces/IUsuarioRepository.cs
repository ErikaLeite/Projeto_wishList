using whishListG5.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace whishListG5.Interfaces
{
    interface IUsuarioRepository
    {
            List<Usuario> Listar();


            Usuario BuscarPorId(int id);


            void Cadastrar(Usuario novoUsuario);


            void Atualizar(int id, Usuario usuarioAtualizado);


            void Deletar(int id);

    }
}
