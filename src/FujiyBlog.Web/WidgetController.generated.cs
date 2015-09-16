// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace FujiyBlog.Web.Controllers
{
    public partial class WidgetController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected WidgetController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Add()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Remove()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Remove);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Sort()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Sort);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WidgetController Actions { get { return MVC.Widget; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Widget";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Widget";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Add = "Add";
            public readonly string Remove = "Remove";
            public readonly string Edit = "Edit";
            public readonly string Sort = "Sort";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Add = "Add";
            public const string Remove = "Remove";
            public const string Edit = "Edit";
            public const string Sort = "Sort";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string zoneName = "zoneName";
        }
        static readonly ActionParamsClass_Add s_params_Add = new ActionParamsClass_Add();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Add AddParams { get { return s_params_Add; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Add
        {
            public readonly string zoneName = "zoneName";
            public readonly string widgetName = "widgetName";
        }
        static readonly ActionParamsClass_Remove s_params_Remove = new ActionParamsClass_Remove();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Remove RemoveParams { get { return s_params_Remove; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Remove
        {
            public readonly string settingsId = "settingsId";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string widgetSettingId = "widgetSettingId";
            public readonly string settings = "settings";
        }
        static readonly ActionParamsClass_Sort s_params_Sort = new ActionParamsClass_Sort();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Sort SortParams { get { return s_params_Sort; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Sort
        {
            public readonly string widgetsOrder = "widgetsOrder";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Administration = "Administration";
                public readonly string Archive = "Archive";
                public readonly string ArchiveEdit = "ArchiveEdit";
                public readonly string Categories = "Categories";
                public readonly string CategoriesEdit = "CategoriesEdit";
                public readonly string Html = "Html";
                public readonly string HtmlEdit = "HtmlEdit";
                public readonly string Index = "Index";
                public readonly string SearchBox = "SearchBox";
                public readonly string SearchBoxEdit = "SearchBoxEdit";
                public readonly string TagCloud = "TagCloud";
                public readonly string TagCloudEdit = "TagCloudEdit";
                public readonly string Widget = "Widget";
            }
            public readonly string Administration = "~/Views/Widget/Administration.cshtml";
            public readonly string Archive = "~/Views/Widget/Archive.cshtml";
            public readonly string ArchiveEdit = "~/Views/Widget/ArchiveEdit.cshtml";
            public readonly string Categories = "~/Views/Widget/Categories.cshtml";
            public readonly string CategoriesEdit = "~/Views/Widget/CategoriesEdit.cshtml";
            public readonly string Html = "~/Views/Widget/Html.cshtml";
            public readonly string HtmlEdit = "~/Views/Widget/HtmlEdit.cshtml";
            public readonly string Index = "~/Views/Widget/Index.cshtml";
            public readonly string SearchBox = "~/Views/Widget/SearchBox.cshtml";
            public readonly string SearchBoxEdit = "~/Views/Widget/SearchBoxEdit.cshtml";
            public readonly string TagCloud = "~/Views/Widget/TagCloud.cshtml";
            public readonly string TagCloudEdit = "~/Views/Widget/TagCloudEdit.cshtml";
            public readonly string Widget = "~/Views/Widget/Widget.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_WidgetController : FujiyBlog.Web.Controllers.WidgetController
    {
        public T4MVC_WidgetController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string zoneName);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string zoneName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "zoneName", zoneName);
            IndexOverride(callInfo, zoneName);
            return callInfo;
        }

        [NonAction]
        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string zoneName, string widgetName);

        [NonAction]
        public override System.Web.Mvc.ActionResult Add(string zoneName, string widgetName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "zoneName", zoneName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "widgetName", widgetName);
            AddOverride(callInfo, zoneName, widgetName);
            return callInfo;
        }

        [NonAction]
        partial void RemoveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int settingsId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Remove(int settingsId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Remove);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "settingsId", settingsId);
            RemoveOverride(callInfo, settingsId);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int widgetSettingId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int widgetSettingId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "widgetSettingId", widgetSettingId);
            EditOverride(callInfo, widgetSettingId);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int widgetSettingId, string settings);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int widgetSettingId, string settings)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "widgetSettingId", widgetSettingId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "settings", settings);
            EditOverride(callInfo, widgetSettingId, settings);
            return callInfo;
        }

        [NonAction]
        partial void SortOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string widgetsOrder);

        [NonAction]
        public override System.Web.Mvc.ActionResult Sort(string widgetsOrder)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Sort);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "widgetsOrder", widgetsOrder);
            SortOverride(callInfo, widgetsOrder);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
