using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wishList_webApi.Domains;

namespace wishList_webApi.Interfaces
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
