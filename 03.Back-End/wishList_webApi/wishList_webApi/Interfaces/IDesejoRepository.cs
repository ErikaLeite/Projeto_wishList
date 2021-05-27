using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wishList_webApi.Domains;

namespace wishList_webApi.Interfaces
{
    /// <summary>
    /// interface responsável pelo repositório do Desejo
    /// </summary>
    interface IDesejoRepository
    {
        /// <summary>
        /// método lista todos os desejos
        /// </summary>
        /// <returns>lista de desejos</returns>
        List<Desejo> Listar();

        /// <summary>
        /// Busca um desejo através do id
        /// </summary>
        /// <param name="id">id do desejo a ser buscado</param>
        /// <returns></returns>
        Desejo BuscarPorId(int id);

        /// <summary>
        /// cadastra um novo desejo
        /// </summary>
        /// <param name="novoDesejo">objeto a ser cadastrado</param>
        void Cadastrar(Desejo novoDesejo);

        /// <summary>
        /// atualiza um desejo através do seu Id
        /// </summary>
        /// <param name="id">id do desejo a ser atualizado</param>
        /// <param name="desejoAtualizado">objeto com as novas informações adicionadas</param>
        void Atualizar(int id, Desejo desejoAtualizado);

        /// <summary>
        /// deleta um desejo existente
        /// </summary>
        /// <param name="id">id do desejo a ser deletado</param>
        void Deletar(int id);

        /// <summary>
        /// Listar todos os desejos com quem os desejou
        /// </summary>
        /// <returns>lista desejos e quem os desejou</returns>
        List<Desejo> ListarDesejos();
    }
}
