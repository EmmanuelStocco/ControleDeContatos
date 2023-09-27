using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class AlterarSenhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Alterar(AlterarSenhaModel alterarSenhaModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    TempData["MensagemSucesso"] = "Senha alterada com sucesso";
                    return View("Index", alterarSenhaModel);
                }
                return View("Index", alterarSenhaModel);

            } catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar sua senha, detalhe do erro: {erro.Message}";
                return View("Index", alterarSenhaModel);
            }
        }
    }
}
