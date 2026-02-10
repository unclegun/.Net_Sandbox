using Microsoft.AspNetCore.Mvc;
using SandboxApp.Models;

namespace SandboxApp.Controllers
{
    public class SandboxController : Controller
    {
        // GET: Sandbox
        public IActionResult Index()
        {
            return View();
        }

        // GET: Sandbox/Forms
        public IActionResult Forms()
        {
            return View();
        }

        // POST: Sandbox/Forms
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Forms(SampleFormModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = $"Form submitted successfully! Name: {model.Name}, Email: {model.Email}";
                return RedirectToAction(nameof(Forms));
            }
            return View(model);
        }

        // GET: Sandbox/Partials
        public IActionResult Partials()
        {
            var items = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4" };
            return View(items);
        }

        // GET: Sandbox/Components
        public IActionResult Components()
        {
            return View();
        }

        // GET: Sandbox/AjaxExample
        public IActionResult AjaxExample()
        {
            return View();
        }

        // POST: Sandbox/GetData (for AJAX testing)
        [HttpPost]
        public IActionResult GetData([FromBody] dynamic data)
        {
            return Json(new { success = true, message = "Data received successfully!", receivedData = data });
        }

        // GET: Sandbox/AgentSelector
        public IActionResult AgentSelector()
        {
            var viewModel = AgentSelectorViewModel.GetSampleData();
            return View(viewModel);
        }

        // POST: Sandbox/AgentSelector
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AgentSelector(AgentSelectorFormModel model)
        {
            if (ModelState.IsValid)
            {
                var selectedCount = model.SelectedAgentIds?.Count ?? 0;
                TempData["SuccessMessage"] = $"Successfully selected {selectedCount} agent(s)! Reason: {model.Reason}";
                return RedirectToAction(nameof(AgentSelector));
            }

            // Reload the form data if validation fails
            var viewModel = AgentSelectorViewModel.GetSampleData();
            viewModel.FormModel = model;
            return View(viewModel);
        }
    }
}
