using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportApp.Data;
using ReportApp.Services;

namespace ReportApp.Controllers
{
    public class ReportesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ReportService _reportService;

        public ReportesController(AppDbContext context, ReportService reportService)
        {
            _context = context;
            _reportService = reportService;
        }

        public async Task<IActionResult> Index()
        {
            var ventas = await _context.Ventas.ToListAsync();
            return View(ventas);
        }

        public async Task<IActionResult> Generar()
        {
            var ventas = await _context.Ventas.ToListAsync();
            var pdfBytes = _reportService.GenerarReporte(ventas);

            return File(pdfBytes, "application/pdf", "ReporteVentas.pdf");
        }
    }
}