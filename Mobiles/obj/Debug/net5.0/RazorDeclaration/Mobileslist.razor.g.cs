// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mobiles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Mobiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\_Imports.razor"
using Mobiles.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Mobileslist")]
    public partial class Mobileslist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Het\OneDrive - St. Clair College\SEMESTER 2\WEB 315 (INTRODUCTION TO ASP.NET)\WEB315_Fall22_Assignment1\Mobiles\Mobileslist.razor"
      
    public int arrayList = 0;
    public string[] MobileList = {};
    private void DisplayArrayList()
    {
        MobileList = MobileList.Concat(new [] {"iPhone", "Samsung", "Oneplus", "Nokia", "Xiaomi"}).ToArray();
    }

    private int newArrayList = 0;
    public int inputvalues = 5;
    private void onchangeinput(int num)
    {
        newArrayList = num;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
