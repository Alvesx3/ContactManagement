using ContactManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManagement.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;

        private readonly IClienteRepository _rep;
        public string Mensagem { get; set; }
        public DeleteModel(ILogger<DeleteModel> logger, IClienteRepository rep)
        {
            _logger = logger;
            _rep = rep;
        }

        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                _rep.Excluir(id);
                Mensagem = "Sucesso";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Create");
                Mensagem = "Falha";
            }
            return RedirectToPage("Index");
        }
    }
}
