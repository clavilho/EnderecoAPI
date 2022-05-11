using Endereco.Application.DTO;
using Endereco.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Endereco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable> PegarTodosEnderecos()
        {
            return Ok(_enderecoService.PegarTodosEnderecos());
        }

        [HttpGet("{cep}")]
        public ActionResult<string> Get(int cep)
        {
            return Ok(_enderecoService.BuscarEnderecoPeloCep(cep));
        }

        [HttpPost]
        public ActionResult CadastrarEndereco([FromBody] EnderecoDTO endereco)
        {
            try
            {
                if (endereco == null)
                    return NotFound("Não é possivel cadastrar um endereço em branco");

                _enderecoService.AdicionarEndereco(endereco);
                return Ok("Endereco cadastrado");

            }
            catch (System.Exception)
            {

                throw;
            }
        }
        [HttpPut]
        public ActionResult AtualizarEndereco([FromBody] EnderecoDTO endereco)
        {
            try
            {
                if (endereco == null)
                    return NotFound("Endereco Não encontrado na base");

                _enderecoService.AtualizarEndereco(endereco);
                return Ok("Endereco Atualizado com sucesso!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        [HttpDelete()]
        public ActionResult ExcluirEndereco([FromBody] EnderecoDTO endereco)
        {
            try
            {
                if (endereco == null)
                    return NotFound("É preciso informar o endereço que deseja excluir");

                _enderecoService.RemoverEndereco(endereco);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
