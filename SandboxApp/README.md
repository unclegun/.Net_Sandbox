# .NET Sandbox Application

A fully-featured ASP.NET Core MVC sandbox application for experimenting with forms, partials, views, components, and more!

## 🚀 Getting Started

### Running the Application

```bash
cd SandboxApp
dotnet run
```

Then open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Development with Hot Reload

```bash
cd SandboxApp
dotnet watch run
```

This will automatically reload the application when you make changes to the code.

## 📁 Project Structure

```
SandboxApp/
├── Controllers/
│   ├── HomeController.cs          # Default home controller
│   └── SandboxController.cs       # Sandbox experimentation controller
├── Models/
│   ├── ErrorViewModel.cs          # Error handling model
│   └── SampleFormModel.cs         # Sample form with validation
├── Views/
│   ├── Home/                      # Default home views
│   ├── Sandbox/                   # Sandbox experimentation views
│   │   ├── Index.cshtml          # Sandbox home page
│   │   ├── Forms.cshtml          # Forms examples
│   │   ├── Partials.cshtml       # Partial views examples
│   │   ├── Components.cshtml     # View components examples
│   │   └── AjaxExample.cshtml    # AJAX examples
│   └── Shared/                    # Shared views and partials
│       ├── _Layout.cshtml        # Main layout
│       ├── _ExamplePartial.cshtml
│       ├── _ItemListPartial.cshtml
│       ├── _AlertPartial.cshtml
│       └── Components/           # View component views
│           ├── Alert/
│           └── PriorityList/
├── ViewComponents/                # View components with logic
│   ├── AlertViewComponent.cs
│   └── PriorityListViewComponent.cs
├── wwwroot/                       # Static files (CSS, JS, images)
└── Program.cs                     # Application entry point
```

## 🧪 Sandbox Features

### 1. Forms (`/Sandbox/Forms`)
Experiment with:
- Text inputs
- Email validation
- Number inputs
- Dropdowns/Select lists
- Textareas
- Checkboxes
- Server-side validation
- Client-side validation

### 2. Partial Views (`/Sandbox/Partials`)
Learn about:
- Creating reusable UI components
- Passing models to partials
- Using `<partial>` tag helper
- Organizing shared views

### 3. View Components (`/Sandbox/Components`)
Explore:
- Components with business logic
- Rendering components with parameters
- Component-specific views
- Reusable components across pages

### 4. AJAX Examples (`/Sandbox/AjaxExample`)
Try out:
- Fetch API calls
- POST requests with JSON
- Dynamic content loading
- Handling responses

## 🎯 How to Use This Sandbox

### Adding New Experiments

#### Create a New View
1. Add a new action method in `Controllers/SandboxController.cs`:
```csharp
public IActionResult MyExperiment()
{
    return View();
}
```

2. Create a new view file in `Views/Sandbox/MyExperiment.cshtml`

#### Create a New Partial View
1. Create a file in `Views/Shared/_MyPartial.cshtml`
2. Use it in any view: `<partial name="_MyPartial" />`

#### Create a New View Component
1. Create a class in `ViewComponents/MyComponent.cs`:
```csharp
public class MyComponentViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
```

2. Create its view in `Views/Shared/Components/MyComponent/Default.cshtml`
3. Invoke it: `@await Component.InvokeAsync("MyComponent")`

## 📦 Technologies Used

- .NET 10.0
- ASP.NET Core MVC
- Bootstrap 5
- Razor Views
- Entity Framework Core (ready to add if needed)

## 💡 Tips

1. **Hot Reload**: Use `dotnet watch run` to see changes instantly
2. **Validation**: Check out `Models/SampleFormModel.cs` for validation attributes
3. **Debugging**: Set breakpoints in controllers to debug requests
4. **Layout**: Modify `Views/Shared/_Layout.cshtml` to change site-wide appearance
5. **Styling**: Add custom CSS in `wwwroot/css/site.css`
6. **JavaScript**: Add custom JS in `wwwroot/js/site.js`

## 🔧 Common Tasks

### Add a Database
1. Install EF Core: `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
2. Create a DbContext class
3. Add connection string to `appsettings.json`
4. Run migrations: `dotnet ef migrations add InitialCreate`

### Add Authentication
```bash
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```

### Add API Controllers
Create controllers in `Controllers/` and derive from `ControllerBase` instead of `Controller`

## 📚 Resources

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core)
- [Razor Syntax Reference](https://docs.microsoft.com/aspnet/core/mvc/views/razor)
- [Bootstrap Documentation](https://getbootstrap.com/docs/)
- [View Components](https://docs.microsoft.com/aspnet/core/mvc/views/view-components)

## 🎉 Happy Experimenting!

This sandbox is your playground. Break things, try new ideas, and learn by doing!
