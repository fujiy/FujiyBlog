﻿using System;
using System.Linq;
using System.Web.Mvc;
using FujiyBlog.Core.DomainObjects;
using FujiyBlog.Core.EntityFramework;
using FujiyBlog.Core.Repositories;
using FujiyBlog.Web.Models;
using FujiyBlog.Web.ViewModels;

namespace FujiyBlog.Web.Controllers
{
    public partial class PostController : AbstractController
    {
        private readonly FujiyBlogDatabase db;
        private readonly PostRepository postRepository;
        private readonly IUserRepository userRepository;

        public PostController(FujiyBlogDatabase db, PostRepository postRepository, IUserRepository userRepository)
        {
            this.db = db;
            this.postRepository = postRepository;
            this.userRepository = userRepository;
        }

        public virtual ActionResult Index(int? page)
        {
            int skip = (page.GetValueOrDefault(1) - 1) * Settings.SettingRepository.PostsPerPage;
            
            PostIndex model = new PostIndex
                                  {
                                      CurrentPage = page.GetValueOrDefault(1),
                                      RecentPosts = postRepository.GetRecentPosts(skip, Settings.SettingRepository.PostsPerPage, isPublic: !Request.IsAuthenticated),
                                      TotalPages = (int)Math.Ceiling(postRepository.GetTotal(isPublic: !Request.IsAuthenticated) / (double)Settings.SettingRepository.PostsPerPage),
                                  };

            ViewBag.Title = Settings.SettingRepository.BlogName + " - " + Settings.SettingRepository.BlogDescription;
            ViewBag.Description = Settings.SettingRepository.BlogDescription;

            return View(model);
        }

        public virtual ActionResult Tag(string tag, int? page)
        {
            int skip = (page.GetValueOrDefault(1) - 1) * Settings.SettingRepository.PostsPerPage;

            PostIndex model = new PostIndex
            {
                CurrentPage = page.GetValueOrDefault(1),
                RecentPosts = postRepository.GetRecentPosts(skip, Settings.SettingRepository.PostsPerPage, tag, isPublic: !Request.IsAuthenticated),
                TotalPages = (int)Math.Ceiling(postRepository.GetTotal(tag, isPublic: !Request.IsAuthenticated) / (double)Settings.SettingRepository.PostsPerPage),
            };

            return View("Index", model);
        }

        public virtual ActionResult Category(string category, int? page)
        {
            int skip = (page.GetValueOrDefault(1) - 1) * Settings.SettingRepository.PostsPerPage;

            PostIndex model = new PostIndex
            {
                CurrentPage = page.GetValueOrDefault(1),
                RecentPosts = postRepository.GetRecentPosts(skip, Settings.SettingRepository.PostsPerPage, category: category, isPublic: !Request.IsAuthenticated),
                TotalPages = (int)Math.Ceiling(postRepository.GetTotal(category: category, isPublic: !Request.IsAuthenticated) / (double)Settings.SettingRepository.PostsPerPage),
            };

            return View("Index", model);
        }

        public virtual ActionResult Author(string author, int? page)
        {
            int skip = (page.GetValueOrDefault(1) - 1) * Settings.SettingRepository.PostsPerPage;

            PostIndex model = new PostIndex
            {
                CurrentPage = page.GetValueOrDefault(1),
                RecentPosts = postRepository.GetRecentPosts(skip, Settings.SettingRepository.PostsPerPage, authorUserName: author, isPublic: !Request.IsAuthenticated),
                TotalPages = (int)Math.Ceiling(postRepository.GetTotal(authorUserName: author, isPublic: !Request.IsAuthenticated) / (double)Settings.SettingRepository.PostsPerPage),
            };

            return View("Index", model);
        }

        public virtual ActionResult Archive()
        {
            PostArchive model = new PostArchive
            {
                AllPosts = postRepository.GetArchive(!Request.IsAuthenticated)
            };

            model.UncategorizedPosts = model.AllPosts.Where(x => !x.Post.Categories.Any()).ToList();
            model.AllCategories = model.AllPosts.SelectMany(x => x.Post.Categories).Distinct().ToList();
            model.TotalPosts = model.AllPosts.Count();
            model.TotalComments = model.AllPosts.Sum(x => x.CommentsTotal);

            return View(model);
        }

        public virtual ActionResult ArchiveDate(int year, int month, int? page)
        {
            int skip = (page.GetValueOrDefault(1) - 1) * Settings.SettingRepository.PostsPerPage;

            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1);

            PostIndex model = new PostIndex
            {
                CurrentPage = page.GetValueOrDefault(1),
                RecentPosts = postRepository.GetRecentPosts(skip, Settings.SettingRepository.PostsPerPage, startDate: startDate, endDate: endDate, isPublic: !Request.IsAuthenticated),
                TotalPages = (int)Math.Ceiling(postRepository.GetTotal(startDate: startDate, endDate: endDate, isPublic: !Request.IsAuthenticated) / (double)Settings.SettingRepository.PostsPerPage),
            };

            return View("Index", model);
        }

        public virtual ActionResult Details(string postSlug)
        {
            if(postSlug.EndsWith(".aspx", StringComparison.InvariantCultureIgnoreCase))
            {
                return RedirectToActionPermanent("Details", new {postSlug = postSlug.Substring(0, postSlug.Length - 5)});
            }

            return Details(postSlug, null);
        }

        public virtual ActionResult DetailsById(int id)
        {
            return Details(null, id);
        }

        private ActionResult Details(string slug, int? id)
        {
            Post post = id.HasValue ? postRepository.GetPost(id.GetValueOrDefault(), !Request.IsAuthenticated) : postRepository.GetPost(slug, !Request.IsAuthenticated);

            if (post == null)
            {
                return HttpNotFound();
            }

            ViewBag.Title = post.Title;
            ViewBag.Keywords = string.Join(",", post.Tags.Select(x => x.Name).Concat(post.Categories.Select(x => x.Name)));
            ViewBag.Description = post.Description;

            Post previousPost = postRepository.GetPreviousPost(post, !Request.IsAuthenticated);
            Post nextPost = postRepository.GetNextPost(post, !Request.IsAuthenticated);

            PostDetails postDetails = new PostDetails
            {
                Post = post,
                PreviousPost = previousPost,
                NextPost = nextPost
            };

            return View("Details", postDetails);
        }

        public virtual ActionResult DoComment(int id)
        {
            bool isLogged = Request.IsAuthenticated;
            Post post = postRepository.GetPost(id, !isLogged);

            if (post == null || !post.IsCommentEnabled || !Settings.SettingRepository.EnableComments)
            {
                throw new InvalidOperationException();
            }

            if (Settings.SettingRepository.CloseCommentsAfterDays.HasValue && post.PublicationDate.AddDays(Settings.SettingRepository.CloseCommentsAfterDays.Value) < DateTime.UtcNow)
            {
                throw new InvalidOperationException();
            }

            PostComment postComment = new PostComment
                                          {
                                              CreationDate = DateTime.UtcNow,
                                              IpAddress = Request.UserHostAddress,
                                              Post = post,
                                              IsApproved = isLogged || !Settings.SettingRepository.ModerateComments,
                                          };

            if (isLogged)
            {
                postComment.Author = userRepository.GetByUsername(User.Identity.Name);
                postComment.IsApproved = true;
                UpdateModel(postComment, new[] { "Comment" });
            }
            else
            {
                UpdateModel(postComment, new[] {"AuthorName", "AuthorEmail", "AuthorWebsite", "Comment"});
            }

            db.PostComments.Add(postComment);
            db.SaveChanges();

            return View("Comments", new[] { postComment });
        }
    }
}
