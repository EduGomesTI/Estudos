using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;
        public ProdutoController(IProdutoRepositorio produtoRepositorio, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment)
        {
            _produtoRepositorio = produtoRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_produtoRepositorio.ObterTodos());
            } catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                produto.Validate();
                if (!produto.EhValidado)
                {
                    return BadRequest(produto.ObterMensagensValidacao());
                }
                if(produto.Id > 0)
                {
                    _produtoRepositorio.Atualizar(produto);
                }
                else
                {
                    _produtoRepositorio.Adicionar(produto);
                }
 
                return Created("api/produto", produto);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost("Deletar")]
        public IActionResult Deletar([FromBody] Produto produto) 
        {
            try
            {
                //produto recebido do FromBody deve ter a propriedade Id > 0
                _produtoRepositorio.Remover(produto);
                return Json(_produtoRepositorio.ObterTodos()); //Não é a melhor solução.
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }

        }
        
        [HttpPost("EnviarArquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                IFormFile formFile = _httpContextAccessor.HttpContext.Request.Form.Files["arquivoEnviado"];
                string nomeArquivo = formFile.FileName;
                string extensao = Path.GetExtension(formFile.FileName);   //nomeArquivo.Split(".").Last();
                char[] arrayNomeCompacto = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray();
                string novoNomeArquivo = new string(arrayNomeCompacto).Replace(" ", "-") + extensao;
                string pastaArquivos = _hostingEnvironment.WebRootPath + @"\arquivos\";
                string nomeCompleto = pastaArquivos + novoNomeArquivo;

                using(FileStream streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo);
                }

                return Json(novoNomeArquivo);

            }catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
