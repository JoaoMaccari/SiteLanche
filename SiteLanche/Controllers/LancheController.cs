using Microsoft.AspNetCore.Mvc;
using SiteLanche.Repositories.Interfaces;
using SiteLanche.ViewModels;

namespace SiteLanche.Controllers {
    public class LancheController : Controller {

        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository) {
            _lancheRepository = lancheRepository;
        }


        public IActionResult List() {

            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de Lanches";
            ViewBag.TotalLanches = totalLanches;

            var lancheLidtViewModel = new LancheListViewModel();
            lancheLidtViewModel.Lanches = _lancheRepository.Lanches;
            lancheLidtViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheLidtViewModel);
        }
    }
}
