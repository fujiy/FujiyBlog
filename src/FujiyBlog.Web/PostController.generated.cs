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
namespace FujiyBlog.Web.Controllers {
    public partial class PostController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PostController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Index() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Tag() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Tag);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Category() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Category);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Author() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Author);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Details() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Details);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DetailsById() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DetailsById);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DoComment() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DoComment);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PostController Actions { get { return MVC.Post; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Post";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Tag = "Tag";
            public readonly string Category = "Category";
            public readonly string Author = "Author";
            public readonly string Archive = "Archive";
            public readonly string Details = "Details";
            public readonly string DetailsById = "DetailsById";
            public readonly string DoComment = "DoComment";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Archive = "~/Views/Post/Archive.cshtml";
            public readonly string Comments = "~/Views/Post/Comments.cshtml";
            public readonly string Details = "~/Views/Post/Details.cshtml";
            public readonly string DoComment = "~/Views/Post/DoComment.cshtml";
            public readonly string Index = "~/Views/Post/Index.cshtml";
            public readonly string Post = "~/Views/Post/Post.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_PostController: FujiyBlog.Web.Controllers.PostController {
        public T4MVC_PostController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index(int? skip) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            callInfo.RouteValueDictionary.Add("skip", skip);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Tag(string tag, int? skip) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Tag);
            callInfo.RouteValueDictionary.Add("tag", tag);
            callInfo.RouteValueDictionary.Add("skip", skip);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Category(string category, int? skip) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Category);
            callInfo.RouteValueDictionary.Add("category", category);
            callInfo.RouteValueDictionary.Add("skip", skip);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Author(string author, int? skip) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Author);
            callInfo.RouteValueDictionary.Add("author", author);
            callInfo.RouteValueDictionary.Add("skip", skip);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Archive() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Archive);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Details(string postSlug) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Details);
            callInfo.RouteValueDictionary.Add("postSlug", postSlug);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DetailsById(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DetailsById);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DoComment(int id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DoComment);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
