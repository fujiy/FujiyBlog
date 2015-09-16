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
    public partial class PostController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PostController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Tag()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tag);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Category()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Category);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Author()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Author);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ArchiveDate()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ArchiveDate);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Details()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DetailsById()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DetailsById);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PostController Actions { get { return MVC.Post; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Post";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Post";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Tag = "Tag";
            public readonly string Category = "Category";
            public readonly string Author = "Author";
            public readonly string Archive = "Archive";
            public readonly string ArchiveDate = "ArchiveDate";
            public readonly string Details = "Details";
            public readonly string DetailsById = "DetailsById";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Tag = "Tag";
            public const string Category = "Category";
            public const string Author = "Author";
            public const string Archive = "Archive";
            public const string ArchiveDate = "ArchiveDate";
            public const string Details = "Details";
            public const string DetailsById = "DetailsById";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Tag s_params_Tag = new ActionParamsClass_Tag();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Tag TagParams { get { return s_params_Tag; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Tag
        {
            public readonly string tag = "tag";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Category s_params_Category = new ActionParamsClass_Category();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Category CategoryParams { get { return s_params_Category; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Category
        {
            public readonly string category = "category";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Author s_params_Author = new ActionParamsClass_Author();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Author AuthorParams { get { return s_params_Author; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Author
        {
            public readonly string author = "author";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_ArchiveDate s_params_ArchiveDate = new ActionParamsClass_ArchiveDate();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ArchiveDate ArchiveDateParams { get { return s_params_ArchiveDate; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ArchiveDate
        {
            public readonly string year = "year";
            public readonly string month = "month";
            public readonly string page = "page";
        }
        static readonly ActionParamsClass_Details s_params_Details = new ActionParamsClass_Details();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Details DetailsParams { get { return s_params_Details; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Details
        {
            public readonly string postSlug = "postSlug";
        }
        static readonly ActionParamsClass_DetailsById s_params_DetailsById = new ActionParamsClass_DetailsById();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DetailsById DetailsByIdParams { get { return s_params_DetailsById; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DetailsById
        {
            public readonly string id = "id";
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
                public readonly string Archive = "Archive";
                public readonly string Details = "Details";
                public readonly string Index = "Index";
                public readonly string Post = "Post";
            }
            public readonly string Archive = "~/Views/Post/Archive.cshtml";
            public readonly string Details = "~/Views/Post/Details.cshtml";
            public readonly string Index = "~/Views/Post/Index.cshtml";
            public readonly string Post = "~/Views/Post/Post.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_PostController : FujiyBlog.Web.Controllers.PostController
    {
        public T4MVC_PostController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? page);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(int? page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            IndexOverride(callInfo, page);
            return callInfo;
        }

        [NonAction]
        partial void TagOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string tag, int? page);

        [NonAction]
        public override System.Web.Mvc.ActionResult Tag(string tag, int? page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "tag", tag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            TagOverride(callInfo, tag, page);
            return callInfo;
        }

        [NonAction]
        partial void CategoryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string category, int? page);

        [NonAction]
        public override System.Web.Mvc.ActionResult Category(string category, int? page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Category);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "category", category);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            CategoryOverride(callInfo, category, page);
            return callInfo;
        }

        [NonAction]
        partial void AuthorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string author, int? page);

        [NonAction]
        public override System.Web.Mvc.ActionResult Author(string author, int? page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Author);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "author", author);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            AuthorOverride(callInfo, author, page);
            return callInfo;
        }

        [NonAction]
        partial void ArchiveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Archive()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Archive);
            ArchiveOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ArchiveDateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int year, int month, int? page);

        [NonAction]
        public override System.Web.Mvc.ActionResult ArchiveDate(int year, int month, int? page)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ArchiveDate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "year", year);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "month", month);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ArchiveDateOverride(callInfo, year, month, page);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string postSlug);

        [NonAction]
        public override System.Web.Mvc.ActionResult Details(string postSlug)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postSlug", postSlug);
            DetailsOverride(callInfo, postSlug);
            return callInfo;
        }

        [NonAction]
        partial void DetailsByIdOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult DetailsById(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DetailsById);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DetailsByIdOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
