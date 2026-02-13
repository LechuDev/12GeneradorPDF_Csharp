using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ReportApp.Models;

namespace ReportApp.Services
{
    public class ReportService
    {
        public byte[] GenerarReporte(List<Venta> ventas)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Text("Reporte de Ventas").FontSize(20).Bold();
                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.RelativeColumn();
                            columns.ConstantColumn(100);
                        });

                        table.Header(header =>
                        {
                            header.Cell().Text("Fecha");
                            header.Cell().Text("Producto");
                            header.Cell().Text("Monto");
                        });

                        foreach (var v in ventas)
                        {
                            table.Cell().Text(v.Fecha.ToShortDateString());
                            table.Cell().Text(v.Producto);
                            table.Cell().Text($"${v.Monto}");
                        }
                    });
                });
            });

            return document.GeneratePdf();
        }
    }
}