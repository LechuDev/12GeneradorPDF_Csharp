
# 📄 ReportApp – Generador de Reportes PDF

## 🚀 Descripción

**ReportApp** es una aplicación ASP.NET Core MVC que permite registrar ventas y generar **reportes PDF dinámicos** con tablas y datos simulados.  
Este proyecto demuestra integración de **Entity Framework Core con SQLite**, uso de librerías externas como **QuestPDF**, y aplicación de una arquitectura **MVC + Services** para mantener el código limpio y escalable.

---

## 🏗️ Arquitectura

El proyecto sigue el patrón **MVC (Model–View–Controller)** con una capa adicional de **Services**:

- **Models** → Representan los datos (`Venta.cs`).  
- **Views** → Interfaz de usuario (`Index.cshtml`, `Generar.cshtml`).  
- **Controllers** → Coordinan la lógica y las peticiones (`ReportesController.cs`).  
- **Services** → Lógica especializada, en este caso la generación de PDFs (`ReportService.cs`).  

👉 Esta arquitectura se documenta como **MVC + Services**, mostrando buenas prácticas de separación de responsabilidades.

---

## 🛠️ Herramientas y Frameworks utilizados

- **ASP.NET Core MVC 9.0** → Framework principal para la aplicación web.  
- **Entity Framework Core (SQLite)** → ORM para persistencia de datos y migraciones.  
- **QuestPDF** → Librería moderna para generación de PDFs dinámicos.  
- **Bootstrap/Bulma (opcional en Views)** → Para dar estilo a las vistas.  

---

## 📂 Estructura del proyecto

```cmd
ReportApp/
 ├── Controllers/
 │    └── ReportesController.cs
 ├── Data/
 │    └── AppDbContext.cs
 ├── Models/
 │    └── Venta.cs
 ├── Services/
 │    └── ReportService.cs
 ├── Views/
 │    └── Reportes/
 │         ├── Index.cshtml
 │         └── Generar.cshtml
 ├── Views/Shared/
 │    └── Error.cshtml
 ├── Program.cs
 ├── appsettings.json
 └── ReportApp.csproj
```

---

## 📊 Datos simulados

El proyecto incluye **ventas de ejemplo** sembradas automáticamente en la base de datos:

- Laptop Gamer – $25,000  
- Mouse Inalámbrico – $800  
- Monitor 4K – $7,000  

Esto permite visualizar registros en la vista `Index.cshtml` y generar un PDF con contenido realista.

---

## 📑 Generación de PDF

El servicio `ReportService.cs` utiliza **QuestPDF** para crear un documento con:

- Encabezado del reporte.  
- Tabla con fecha, producto y monto.  
- Exportación automática a PDF descargable.  

### Configuración de licencia QuestPDF

En `Program.cs` se incluye:

```csharp
using QuestPDF.Infrastructure;
QuestPDF.Settings.License = LicenseType.Community;
```

Esto habilita el uso gratuito bajo la **Community License**.

---

## 📌 Flujo de uso

1. El usuario accede a `/Reportes/Index`.  
2. Visualiza las ventas registradas.  
3. Presiona el botón **Generar PDF**.  
4. El sistema crea y descarga automáticamente el archivo `ReporteVentas.pdf`.  

---

## 🎯 Valor del proyecto

- Demuestra **integración de librerías externas** en ASP.NET Core.  
- Muestra **automatización de reportes**, útil en cualquier empresa.  
- Refleja **arquitectura limpia (MVC + Services)** y buenas prácticas.  
- Proyecto atractivo para portafolio porque **todo mundo necesita reportes**.  

---

🌟 Con este README tu **ReportApp** queda listo para presentarse en tu portafolio como un proyecto sólido, profesional y vendible.  

¿Quieres que el siguiente paso sea armar un **banner visual para tu README** (con estilo ASCII o Markdown decorado) para que luzca más llamativo en GitHub?
