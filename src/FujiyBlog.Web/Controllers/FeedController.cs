﻿using System;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using FujiyBlog.Core.DomainObjects;
using FujiyBlog.Core.Services;

namespace FujiyBlog.Web.Controllers
{
    public partial class FeedController : AbstractController
    {
        private readonly FeedGenerator feedGenerator;

        public FeedController(FeedGenerator feedGenerator)
        {
            this.feedGenerator = feedGenerator;
        }

        [OutputCache(Duration = 500)]
        public virtual ActionResult Rss20()
        {
            string feedUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Feed.Rss20());

            Func<User, string> authorUrl = x => Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Post.Author(x.Username, null));
            Func<Post, string> postUrl = x => Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Post.Details(x.Slug));

            return Content(feedGenerator.GetBlog<Rss20FeedFormatter>(feedUrl, authorUrl, postUrl));
        }

        [OutputCache(Duration = 500)]
        public virtual ActionResult Atom10()
        {
            string feedUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Feed.Rss20());

            Func<User, string> authorUrl = x => Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Post.Author(x.Username, null));
            Func<Post, string> postUrl = x => Request.Url.Scheme + "://" + Request.Url.Authority + Url.Action(MVC.Post.Details(x.Slug));

            return Content(feedGenerator.GetBlog<Atom10FeedFormatter>(feedUrl, authorUrl, postUrl));
        }

    }
}
