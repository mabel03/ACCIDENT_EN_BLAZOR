#pragma checksum "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\Pages\RegistrarAccidente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0078a3c45d02cc24849017ac637fdb2e7b6c7d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea3_Programacion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Tarea3_Programacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\_Imports.razor"
using Tarea3_Programacion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\Pages\RegistrarAccidente.razor"
using AccidenteTransito.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\Pages\RegistrarAccidente.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarAccidente")]
    public partial class RegistrarAccidente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\User\Desktop\Tarea3_Programacion\Tarea3_Programacion\Pages\RegistrarAccidente.razor"
       
    Accidente registrar = new Accidente();
    private IEnumerable<Accidente> accidentes;

    protected void Cancelar()
    {

    }
    protected async Task EnviarDatos()
    {
        await AccidenteService.Enviar(registrar);
    }


    protected override async Task OnInitializedAsync()
    {
        try
        {
            accidentes = await AccidenteService.GetAccidente();
        }
        catch (Exception)
        {
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccidenteService AccidenteService { get; set; }
    }
}
#pragma warning restore 1591
