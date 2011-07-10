// <auto-generated />
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
namespace FujiyBlog.Web.Areas.Admin.Controllers {
    public partial class SettingController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SettingController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SettingController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SettingController Actions { get { return MVC.Admin.Setting; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Setting";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Email = "Email";
            public readonly string Comments = "Comments";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string _Layout = "~/Areas/Admin/Views/Setting/_Layout.cshtml";
            public readonly string Comments = "~/Areas/Admin/Views/Setting/Comments.cshtml";
            public readonly string Email = "~/Areas/Admin/Views/Setting/Email.cshtml";
            public readonly string Index = "~/Areas/Admin/Views/Setting/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_SettingController: FujiyBlog.Web.Areas.Admin.Controllers.SettingController {
        public T4MVC_SettingController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Index(FujiyBlog.Web.Areas.Admin.ViewModels.AdminBasicSettings settings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            callInfo.RouteValueDictionary.Add("settings", settings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Email() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Email);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Email(FujiyBlog.Web.Areas.Admin.ViewModels.AdminEmailSettings settings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Email);
            callInfo.RouteValueDictionary.Add("settings", settings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Comments() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Comments);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Comments(FujiyBlog.Web.Areas.Admin.ViewModels.AdminCommentsSettings settings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Comments);
            callInfo.RouteValueDictionary.Add("settings", settings);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
