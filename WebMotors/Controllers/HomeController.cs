using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using WebMotors.Domain.Entities;
using WebMotors.Service.Services;

namespace WebMotors.Web.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnuncioService _anuncioService;
        private readonly IFornecedorService _fornecedorService;

        public HomeController(IAnuncioService anuncioService, IFornecedorService fornecedorService) 
        {
            _anuncioService = anuncioService;
            _fornecedorService = fornecedorService;
        }
        private IEnumerable<Marca> listaMarcas
        {
            get
            {
                if (_marcas == null)
                {
                    _marcas = _fornecedorService.ObterMarcas();
                }

                return _marcas;
            }
        }

        private IEnumerable<Marca> _marcas;       

        public ActionResult Listar()
        {
            return View(_anuncioService.Listar());
        }

        //[Permission("Administrador")]
        public ActionResult Cadastrar()
        {
            ViewBag.Marcas = listaMarcas;

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Anuncio obj)
        {
            try
            {
                //COMO NA TABELA OS CAMPOS ESTÃO COMO VARCHAR NESSE MOMENTO EU FAÇO A TROCA P/
                //GRAVAR O TEXTO AO INVÉS DO ID

                var marcaId = int.Parse(obj.Marca);
                var marcas = _fornecedorService.ObterMarcas();
                var marcaNome = marcas.FirstOrDefault(m => m.ID == marcaId).Name;

                obj.Marca = marcaNome;

                var modeloId = int.Parse(obj.Modelo);
                var modelos = _fornecedorService.ObterModelos(marcaId);
                var modeloNome = modelos.FirstOrDefault(m => m.ID == modeloId).Name;

                obj.Modelo = modeloNome;

                var versaoId = int.Parse(obj.Versao);
                var versoes = _fornecedorService.ObterVersoes(modeloId);
                var versaoNome = versoes.FirstOrDefault(m => m.ID == versaoId).Name;

                obj.Versao = versaoNome;

                _anuncioService.Cadastrar(obj);

                return RedirectToAction("Listar");
            }
            catch
            {
                TempData["msg"] = "<script>alert('Erro ao Cadastrar OU AO CONSUMIR O WEBSERVICE. Entre em contato com o suporte');</script>";
                return RedirectToAction("Listar");
            }
        }

        //[Permission("Administrador")]
        public ActionResult Editar(int id)
        {
            try
            {
                if (id == 0) return RedirectToAction("Listar");

                ViewBag.Marcas = listaMarcas;

                var anuncio = _anuncioService.ObterPorId(id);

                var marcas = _fornecedorService.ObterMarcas();
                var marcaId = marcas.FirstOrDefault(m => m.Name == anuncio.Marca).ID;

                var modelos = _fornecedorService.ObterModelos(marcaId);
                var modeloId = modelos.FirstOrDefault(m => m.Name == anuncio.Modelo).ID;

                var versoes = _fornecedorService.ObterVersoes(modeloId);
                var versaoId = versoes.FirstOrDefault(m => m.Name == anuncio.Versao).ID;

                ViewBag.MarcaId = marcaId;
                ViewBag.ModeloId = modeloId;
                ViewBag.VersaoId = versaoId;

                return View(anuncio);
            }
            catch
            {
                return LocalRedirect("/Home/Editar");
            }
        }

        [HttpPost]
        public ActionResult Editar(int id, Anuncio obj)
        {
            try
            {

                //COMO NA TABELA OS CAMPOS ESTÃO COMO VARCHAR NESSE MOMENTO EU FAÇO A TROCA P/
                //GRAVAR O TEXTO AO INVÉS DO ID

                var marcaId = int.Parse(obj.Marca);
                var marcas = _fornecedorService.ObterMarcas();
                var marcaNome = marcas.FirstOrDefault(m => m.ID == marcaId).Name;

                obj.Marca = marcaNome;

                var modeloId = int.Parse(obj.Modelo);
                var modelos = _fornecedorService.ObterModelos(marcaId);
                var modeloNome = modelos.FirstOrDefault(m => m.ID == modeloId).Name;

                obj.Modelo = modeloNome;

                var versaoId = int.Parse(obj.Versao);
                var versoes = _fornecedorService.ObterVersoes(modeloId);
                var versaoNome = versoes.FirstOrDefault(m => m.ID == versaoId).Name;

                obj.Versao = versaoNome;

                _anuncioService.Editar(obj);

                return RedirectToAction("Listar");
            }
            catch
            {
                TempData["msg"] = "<script>alert('Erro ao Editar OU AO CONSUMIR O WEBSERVICE. Entre em contato com o suporte');</script>";
                return RedirectToAction("Listar");
            }
        }

        //[Permission("Administrador")]
        public ActionResult Excluir(int id)
        {
            return View(_anuncioService.ObterPorId(id));
        }

        [HttpPost]
        public ActionResult Excluir(int id, Anuncio obj)
        {
            try
            {
                _anuncioService.Excluir(id);

                return RedirectToAction("Listar");
            }
            catch
            {
                TempData["msg"] = "<script>alert('Erro ao Excluir. Entre em contato com o suporte');</script>";
                return View();
            }
        }

        public IActionResult Index()
        {
            return LocalRedirect("/Home/Listar");
        }

        #region Consultar Modelos e Versoes
        [HttpGet]
        public JsonResult ObterModelos(int id)
        {
            var modelos = _fornecedorService.ObterModelos(id);
            var result = JsonConvert.SerializeObject(modelos);

            return new JsonResult(result);
        }

        [HttpGet]
        public JsonResult ObterVersoes(int id)
        {
            var versoes = _fornecedorService.ObterVersoes(id);
            var result = JsonConvert.SerializeObject(versoes);

            return new JsonResult(result);
        }
        #endregion

    }
}
