#pragma checksum "C:\Veterinaria Repositorio 3\VeterinariaWeb\VeterinariaWeb.App\VeterinariaWeb.App.Frontend\Pages\HistoriaClinica\HistoriaClinica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a45141765d8cc3fd281e89754bcb69a39d3a102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VeterinariaWeb.App.Frontend.Pages.HistoriaClinica.Pages_HistoriaClinica_HistoriaClinica), @"mvc.1.0.razor-page", @"/Pages/HistoriaClinica/HistoriaClinica.cshtml")]
namespace VeterinariaWeb.App.Frontend.Pages.HistoriaClinica
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Veterinaria Repositorio 3\VeterinariaWeb\VeterinariaWeb.App\VeterinariaWeb.App.Frontend\Pages\_ViewImports.cshtml"
using VeterinariaWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a45141765d8cc3fd281e89754bcb69a39d3a102", @"/Pages/HistoriaClinica/HistoriaClinica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce113bcacbec823bd98135e2edcc3ac287e6549", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HistoriaClinica_HistoriaClinica : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""login-wrap"">
	<div class=""login-html"">
		<input id=""tab-1"" type=""radio"" name=""tab"" class=""sign-in"" checked><label for=""tab-1"" class=""tab"">Historia Clínica</label>
		<div class=""login-form"">
			<div class=""sign-in-htm"">
				<div class=""group"">
					<label for=""user"" class=""label"">Fecha Apertura</label>
					<input id=""user"" type=""text"" class=""input"">
                    <label for=""user"" class=""label"">Veterinaria</label>
					<input id=""user"" type=""text"" class=""input"">
                    <label for=""user"" class=""label"">Propietario</label>
					<input id=""user"" type=""text"" class=""input"">
                    <label for=""user"" class=""label"">Mascota</label>
					<input id=""user"" type=""text"" class=""input"">
				</div>
				<div class=""hr""></div>
				<div class=""group"">
					<table class=""gen-table"">
						<tr>
							<th>Historia Clinica</th>
  						</tr>
					</table>
				</div>
				<div class=""group"">
					<input type=""submit"" class=""button"" value=""Guardar"">
					<input type=""");
            WriteLiteral(@"submit"" class=""button"" value=""Consultar"">
					<input type=""submit"" class=""button"" value=""Modificar"">
					<input type=""submit"" class=""button"" value=""Eliminar"">
				</div>
			</div>
		</div>
	</div>
</div>
<style>
    body{
	margin:0;
	color:#6a6f8c;
	background:#c8c8c8;
	font:600 16px/18px 'Open Sans',sans-serif;
}
*,:after,:before{box-sizing:border-box}
.clearfix:after,.clearfix:before{content:'';display:table}
.clearfix:after{clear:both;display:block}
a{color:inherit;text-decoration:none}

.login-wrap{
	width:100%;
	margin:auto;
	max-width:725px;
	min-height:400px;
	position:relative;
	/*background:url(https://raw.githubusercontent.com/khadkamhn/day-01-login-form/master/img/bg.jpg) no-repeat center;*/
    background:url(https://image.winudf.com/v2/image1/bGl0dGxlYXBwYXMuZG9nLndhbGxwYXBlcnNfc2NyZWVuXzdfMTU2ODgyODc5M18wODg/screen-7.jpg?fakeurl=1&type=.jpg) no-repeat center;
	box-shadow:0 12px 15px 0 rgba(0,0,0,.24),0 17px 50px 0 rgba(0,0,0,.19);
}
.login-html{
	width:100%;
	he");
            WriteLiteral(@"ight:100%;
	position:absolute;
	padding:90px 70px 50px 70px;
	/*background:rgba(40,57,101,.9);*/
	background:rgba(40,57,101,.3);
}
.login-html .sign-in-htm{
	top:0;
	left:0;
	right:0;
	bottom:0;
	position:absolute;
	transform:rotateY(180deg);
	backface-visibility:hidden;
	transition:all .4s linear;
}
.login-html .sign-in,
.login-form .group .check{
	display:none;
}
.login-html .tab,
.login-form .group .label,
.login-form .group .button,
.login-form .group .select{
	text-transform:uppercase;
}
.login-html .tab{
	font-size:22px;
	margin-right:15px;
	padding-bottom:5px;
	margin:0 15px 10px 0;
	display:inline-block;
	border-bottom:2px solid transparent;
}
.login-html .sign-in:checked + .tab{
	color:#fff;
	border-color:#1161ee;
}
.login-form{
	min-height:345px;
	position:relative;
	perspective:1000px;
	transform-style:preserve-3d;
}
.login-form .group{
	margin-bottom:15px;
}
.login-form .group .label,
.login-form .group .input,
.login-form .group .select{
	/*width:");
            WriteLiteral(@"100%;*/
	color:#fff;
	display:block;
}

.login-form .group .button{
	/*width:100%;*/
	color:#fff;
	display:inline-block;
}

.login-form .group .input,
.login-form .group .button,
.login-form .group .select{
	border:none;
	padding:15px 20px;
	border-radius:25px;
	background:rgba(40,57,101,.9);
}

.login-form .group input[data-type=""password""]{
	text-security:circle;
	-webkit-text-security:circle;
}
.login-form .group .label{
	/*color:#aaa;*/
	font-size:12px;
}
.login-form .group .button{
	background:#1161ee;
}
.login-form .group label .icon{
	width:15px;
	height:15px;
	border-radius:2px;
	position:relative;
	display:inline-block;
	background:rgba(255,255,255,.1);
}
.login-form .group label .icon:before,
.login-form .group label .icon:after{
	content:'';
	width:10px;
	height:2px;
	background:#fff;
	position:absolute;
	transition:all .2s ease-in-out 0s;
}
.login-form .group label .icon:before{
	left:3px;
	width:5px;
	bottom:6px;
	transform:scale(0) rotate(0);
");
            WriteLiteral(@"}
.login-form .group label .icon:after{
	top:6px;
	right:0;
	transform:scale(0) rotate(0);
}
.login-form .group .check:checked + label{
	color:#fff;
}
.login-form .group .check:checked + label .icon{
	background:#1161ee;
}
.login-form .group .check:checked + label .icon:before{
	transform:scale(1) rotate(45deg);
}
.login-form .group .check:checked + label .icon:after{
	transform:scale(1) rotate(-45deg);
}
.login-html .sign-in:checked + .tab + .login-form .sign-in-htm{
	transform:rotate(0);
}

.hr{
	height:2px;
	margin:40px 0 50px 0;
	background:rgba(255,255,255,.2);
}
.foot-lnk{
	text-align:center;
}

</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeterinariaWeb.App.Frontend.Pages.HistoriaClinicaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VeterinariaWeb.App.Frontend.Pages.HistoriaClinicaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VeterinariaWeb.App.Frontend.Pages.HistoriaClinicaModel>)PageContext?.ViewData;
        public VeterinariaWeb.App.Frontend.Pages.HistoriaClinicaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
