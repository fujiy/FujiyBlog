﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC {
    public static FujiyBlog.Web.Controllers.AccountController Account = new FujiyBlog.Web.Controllers.T4MVC_AccountController();
    public static FujiyBlog.Web.Controllers.PostController Post = new FujiyBlog.Web.Controllers.T4MVC_PostController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC {
}

namespace System.Web.Mvc {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class T4Extensions {
        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result) {
            return htmlHelper.RouteLink(linkText, result.GetRouteValueDictionary());
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes) {
            return ActionLink(htmlHelper, linkText, result, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes) {
            return htmlHelper.RouteLink(linkText, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result) {
            return htmlHelper.BeginForm(result, FormMethod.Post);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod) {
            return htmlHelper.BeginForm(result, formMethod, null);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, object htmlAttributes) {
            return BeginForm(htmlHelper, result, formMethod, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, formMethod, htmlAttributes);
        }

        public static void RenderAction(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            htmlHelper.RenderAction(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static MvcHtmlString Action(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.Action(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }
        public static string Action(this UrlHelper urlHelper, ActionResult result) {
            return urlHelper.RouteUrl(result.GetRouteValueDictionary());
        }

        public static string ActionAbsolute(this UrlHelper urlHelper, ActionResult result) {
            return string.Format("{0}{1}",urlHelper.RequestContext.HttpContext.Request.Url.GetLeftPart(UriPartial.Authority),
                urlHelper.RouteUrl(result.GetRouteValueDictionary()));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.BeginForm(result, ajaxOptions, null);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return BeginForm(ajaxHelper, result, ajaxOptions, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return ajaxHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result) {
            return MapRoute(routes, name, url, result, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, string[] namespaces) {
            return MapRoute(routes, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRoute(routes, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            routes.Add(name, route);
            return route;
        }

        // Note: can't name the AreaRegistrationContext methods 'MapRoute', as that conflicts with the existing methods
        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result) {
            return MapRouteArea(context, name, url, result, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, string[] namespaces) {
            return MapRouteArea(context, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRouteArea(context, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            if ((namespaces == null) && (context.Namespaces != null)) {
                 namespaces = context.Namespaces.ToArray();
            }
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            context.Routes.Add(name, route);
            route.DataTokens["area"] = context.AreaName;
            bool useNamespaceFallback = (namespaces == null) || (namespaces.Length == 0);
            route.DataTokens["UseNamespaceFallback"] = useNamespaceFallback;
            return route;
        }

        private static Route CreateRoute(string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Start by adding the default values from the anonymous object (if any)
            var routeValues = new RouteValueDictionary(defaults);

            // Then add the Controller/Action names and the parameters from the call
            foreach (var pair in result.GetRouteValueDictionary()) {
                routeValues.Add(pair.Key, pair.Value);
            }

            var routeConstraints = new RouteValueDictionary(constraints);

            // Create and add the route
            var route = new Route(url, routeValues, routeConstraints, new MvcRouteHandler());

            route.DataTokens = new RouteValueDictionary();

            if (namespaces != null && namespaces.Length > 0) {
                route.DataTokens["Namespaces"] = namespaces;
            }

            return route;
        }

        public static IT4MVCActionResult GetT4MVCResult(this ActionResult result) {
            var t4MVCResult = result as IT4MVCActionResult;
            if (t4MVCResult == null) {
                throw new InvalidOperationException("T4MVC was called incorrectly. You may need to force it to regenerate by right clicking on T4MVC.tt and choosing Run Custom Tool");
            }
            return t4MVCResult;
        }

        public static RouteValueDictionary GetRouteValueDictionary(this ActionResult result) {
            return result.GetT4MVCResult().RouteValueDictionary;
        }

        public static ActionResult AddRouteValues(this ActionResult result, object routeValues) {
            return result.AddRouteValues(new RouteValueDictionary(routeValues));
        }

        public static ActionResult AddRouteValues(this ActionResult result, RouteValueDictionary routeValues) {
            RouteValueDictionary currentRouteValues = result.GetRouteValueDictionary();

            // Add all the extra values
            foreach (var pair in routeValues) {
                currentRouteValues.Add(pair.Key, pair.Value);
            }

            return result;
        }

        public static ActionResult AddRouteValues(this ActionResult result, System.Collections.Specialized.NameValueCollection nameValueCollection) {
            // Copy all the values from the NameValueCollection into the route dictionary
            nameValueCollection.CopyTo(result.GetRouteValueDictionary());
            return result;
        }

        public static ActionResult AddRouteValue(this ActionResult result, string name, object value) {
            RouteValueDictionary routeValues = result.GetRouteValueDictionary();
            routeValues.Add(name, value);
            return result;
        }
        
        public static void InitMVCT4Result(this IT4MVCActionResult result, string area, string controller, string action) {
            result.Controller = controller;
            result.Action = action;
            result.RouteValueDictionary = new RouteValueDictionary();
             
            result.RouteValueDictionary.Add("Controller", controller);
            result.RouteValueDictionary.Add("Action", action);
        }

        public static bool FileExists(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return false;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return System.IO.File.Exists(filePath);
        }

        static DateTime CenturyBegin=new DateTime(2001,1,1);
        public static string TimestampString(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return string.Empty;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return Convert.ToString((System.IO.File.GetLastWriteTimeUtc(filePath).Ticks-CenturyBegin.Ticks)/1000000000,16);            
        }
    }
}

   
[GeneratedCode("T4MVC", "2.0")]   
public interface IT4MVCActionResult {   
    string Action { get; set; }   
    string Controller { get; set; }   
    RouteValueDictionary RouteValueDictionary { get; set; }   
}   
  

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult {
    public T4MVC_ActionResult(string area, string controller, string action): base()  {
        this.InitMVCT4Result(area, controller, action);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_1_4_4_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.4.4-vsdoc.min.js") ? Url("jquery-1.4.4-vsdoc.min.js") : Url("jquery-1.4.4-vsdoc.js");
                      
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Themes {
            private const string URLPATH = "~/Content/Themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Base {
                private const string URLPATH = "~/Content/Themes/Base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/Themes/Base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                }
            
                public static readonly string jquery_ui_css = Url("jquery-ui.css");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Default {
                private const string URLPATH = "~/Content/Themes/Default";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class img {
                    private const string URLPATH = "~/Content/Themes/Default/img";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string download_png = Url("download.png");
                    public static readonly string footerbg_jpg = Url("footerbg.jpg");
                    public static readonly string grunge_header_jpg = Url("grunge-header.jpg");
                    public static readonly string mainbg_jpg = Url("mainbg.jpg");
                    public static readonly string postheadingbottombg_jpg = Url("postheadingbottombg.jpg");
                    public static readonly string postheadingsideripbg_jpg = Url("postheadingsideripbg.jpg");
                    public static readonly string searchbg_jpg = Url("searchbg.jpg");
                    public static readonly string topbg_jpg = Url("topbg.jpg");
                    public static readonly string widgetheadingbg_jpg = Url("widgetheadingbg.jpg");
                    public static readonly string widgetmainbg_jpg = Url("widgetmainbg.jpg");
                }
            
                public static readonly string Site_css = Url("Site.css");
            }
        
        }
    
    }

}

static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}




namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

	

#endregion T4MVC
#pragma warning restore 1591


