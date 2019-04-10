#pragma checksum "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc8c13e997b84b6a74c324257c68219df8addc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\_ViewImports.cshtml"
using ChefsAndDishes;

#line default
#line hidden
#line 2 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\_ViewImports.cshtml"
using ChefsAndDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc8c13e997b84b6a74c324257c68219df8addc8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e01085002f792202768963d7d0c07b88e1c684e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 493, true);
            WriteLiteral(@"
<div class=""container"">
<div class=""row"">
    <div class=""col col-sm""></div>
    <div class=""col-6 col-sm""><h1 class=""text-center"">Chefs| <a href=""dishes"">Dishes</a> </h1></div>
    <div class=""col col-sm""><a href=""new"">Add a Chef</a></div>
</div>
<h4>Check out our roster of Chefs!</h4>
<hr>

<table class=""table table-striped"">
    <thead>
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Age</th>
      <th scope=""col""># of Dished</th>
    </tr>
  </thead>
");
            EndContext();
#line 20 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
 foreach (Chef currentChef in Model)
{
     int age = DateTime.Today.Year - currentChef.DateofBirth.Year;

#line default
#line hidden
            BeginContext(622, 33, true);
            WriteLiteral("     <tr>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(656, 21, false);
#line 24 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
                 Write(currentChef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(677, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(680, 20, false);
#line 24 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
                                         Write(currentChef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(700, 29, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(730, 3, false);
#line 25 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
                 Write(age);

#line default
#line hidden
            EndContext();
            BeginContext(733, 29, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(763, 33, false);
#line 26 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
                 Write(currentChef.CreatedDishes.Count());

#line default
#line hidden
            EndContext();
            BeginContext(796, 18, true);
            WriteLiteral("</th>\r\n    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\ChefsAndDishes\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(817, 22, true);
            WriteLiteral("</table>\r\n\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591