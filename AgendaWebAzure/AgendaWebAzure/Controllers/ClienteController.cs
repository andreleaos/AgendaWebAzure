using AgendaWebAzure.Models.Entitties;
using AgendaWebAzure.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWebAzure.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _clienteService.GetAllAsync();
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var result = await _clienteService.GetByIdAsync(id);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Nome, Email, Fone")] Cliente cliente)
        {
            try
            {
                await _clienteService.AddAsync(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var result = await _clienteService.GetByIdAsync(id);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id, Nome, Email, Fone")] Cliente cliente)
        {
            try
            {
                await _clienteService.UpdateAsync(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _clienteService.GetByIdAsync(id);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([Bind("Id, Nome, Email, Fone")] Cliente cliente)
        {
            try
            {
                await _clienteService.DeleteAsync(cliente.Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
