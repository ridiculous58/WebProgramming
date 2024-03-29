// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebProgramming.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/user/deleteuser/{id}")]
    public partial class UserDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Pages\Admin\UserDelete.razor"
       
    [Inject]
    private NewsDbContext Context { get; set; }

    [Parameter]
    public string id { get; set; }
    IdentityUser identityUser = new IdentityUser();
    protected async override Task OnInitializedAsync()
    {

        identityUser = await Context.Users.FirstOrDefaultAsync(x => x.Id == id);
        bool isSuccess = (await userManager.DeleteAsync(identityUser)).Succeeded;
        await Context.SaveChangesAsync();
        if (isSuccess)
        {
            NavManager.NavigateTo("/admin/user");
        }


        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
    }
}
#pragma warning restore 1591
