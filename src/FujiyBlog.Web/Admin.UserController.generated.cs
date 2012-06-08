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
    public partial class UserController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UserController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Edit() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Disable() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Disable);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Enable() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Enable);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult EditRoleGroup() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.EditRoleGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteRoleGroup() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteRoleGroup);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserController Actions { get { return MVC.Admin.User; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "User";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "User";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Create = "Create";
            public readonly string Edit = "Edit";
            public readonly string Disable = "Disable";
            public readonly string Enable = "Enable";
            public readonly string RoleGroups = "RoleGroups";
            public readonly string EditRoleGroup = "EditRoleGroup";
            public readonly string DeleteRoleGroup = "DeleteRoleGroup";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Index = "Index";
            public const string Create = "Create";
            public const string Edit = "Edit";
            public const string Disable = "Disable";
            public const string Enable = "Enable";
            public const string RoleGroups = "RoleGroups";
            public const string EditRoleGroup = "EditRoleGroup";
            public const string DeleteRoleGroup = "DeleteRoleGroup";
        }


        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Disable s_params_Disable = new ActionParamsClass_Disable();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Disable DisableParams { get { return s_params_Disable; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Disable {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Enable s_params_Enable = new ActionParamsClass_Enable();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Enable EnableParams { get { return s_params_Enable; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Enable {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_EditRoleGroup s_params_EditRoleGroup = new ActionParamsClass_EditRoleGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditRoleGroup EditRoleGroupParams { get { return s_params_EditRoleGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditRoleGroup {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_DeleteRoleGroup s_params_DeleteRoleGroup = new ActionParamsClass_DeleteRoleGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteRoleGroup DeleteRoleGroupParams { get { return s_params_DeleteRoleGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteRoleGroup {
            public readonly string id = "id";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string _Layout = "~/Areas/Admin/Views/User/_Layout.cshtml";
            public readonly string Create = "~/Areas/Admin/Views/User/Create.cshtml";
            public readonly string Edit = "~/Areas/Admin/Views/User/Edit.cshtml";
            public readonly string EditRoleGroup = "~/Areas/Admin/Views/User/EditRoleGroup.cshtml";
            public readonly string Index = "~/Areas/Admin/Views/User/Index.cshtml";
            public readonly string RoleGroups = "~/Areas/Admin/Views/User/RoleGroups.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_UserController: FujiyBlog.Web.Areas.Admin.Controllers.UserController {
        public T4MVC_UserController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ViewResult Index() {
            var callInfo = new T4MVC_ViewResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Create() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Create);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Create(FujiyBlog.Web.Areas.Admin.ViewModels.AdminUserCreate userData) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Create);
            callInfo.RouteValueDictionary.Add("userData", userData);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(FujiyBlog.Web.Areas.Admin.ViewModels.AdminUserSave userData) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("userData", userData);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Disable(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Disable);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Enable(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Enable);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ViewResult RoleGroups() {
            var callInfo = new T4MVC_ViewResult(Area, Name, ActionNames.RoleGroups);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult EditRoleGroup(int? id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.EditRoleGroup);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult EditRoleGroup(int? id, string name, System.Collections.Generic.IEnumerable<string> roles) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.EditRoleGroup);
            callInfo.RouteValueDictionary.Add("id", id);
            callInfo.RouteValueDictionary.Add("name", name);
            callInfo.RouteValueDictionary.Add("roles", roles);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteRoleGroup(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteRoleGroup);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
