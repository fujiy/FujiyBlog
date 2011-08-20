﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FujiyBlog.Core.Dto;
using FujiyBlog.Core.DomainObjects;
using FujiyBlog.Core.Extensions;

namespace FujiyBlog.Core.EntityFramework
{
    public class PostRepository : RepositoryBase<Post>
    {
        public PostRepository(FujiyBlogDatabase database)
            : base(database)
        {
        }

        private Post GetPost(string slug, int? id, bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.Where(x => !x.IsDeleted).Include(x => x.Author);

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }

            Post post;

            if (id.HasValue)
            {
                int idInt = id.GetValueOrDefault();
                post = posts.SingleOrDefault(x => x.Id == idInt);
            }
            else
            {
                post = posts.SingleOrDefault(x => x.Slug == slug);
            }

            if (post == null)
            {
                return null;
            }

            Database.Entry(post).Collection(x=>x.Tags).Load();
            Database.Entry(post).Collection(x => x.Categories).Load();
            if (isPublic)
            {
                Database.Entry(post).Collection(x => x.Comments).Query().Where(x => !x.IsDeleted && x.IsApproved).Include(x => x.Author).Load();
            }
            else
            {
                Database.Entry(post).Collection(x => x.Comments).Query().Where(x => !x.IsDeleted).Include(x => x.Author).Load();
            }

            return post;
        }

        public IEnumerable<PostSummary> GetRecentPosts(int skip, int take, string tag = null, string category = null, string authorUserName = null, DateTime? startDate = null, DateTime? endDate = null, bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.PublicationDate).Include(x => x.Author).Include(x => x.Tags).Include(x => x.Categories);

            if (tag != null)
            {
                posts = posts.Where(x => x.Tags.Any(y => y.Name == tag));
            }

            if (category != null)
            {
                posts = posts.Where(x => x.Categories.Any(y => y.Name == category));
            }

            if (authorUserName != null)
            {
                posts = posts.Where(x => x.Author.Username == authorUserName);
            }

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }

            if (skip > 0)
            {
                posts = posts.Skip(skip);
            }

            if (startDate.HasValue)
            {
                posts = posts.Where(x => x.PublicationDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                posts = posts.Where(x => x.PublicationDate <= endDate.Value);
            }

            posts = posts.Take(take);

            Dictionary<int,int> counts;

            if (isPublic)
            {
                counts = (from post in posts
                          select new { post.Id, C = post.Comments.Count(x=> x.IsApproved && !x.IsDeleted) }).ToDictionary(e => e.Id, e => e.C);
            }
            else
            {
                counts = (from post in posts
                          select new { post.Id, C = post.Comments.Count(x => !x.IsDeleted) }).ToDictionary(e => e.Id, e => e.C);
            }

            var postSummaries = (from post in posts.ToList()
                                  select new PostSummary
                                             {
                                                 Post = post,
                                                 CommentsTotal = counts[post.Id]
                                             }).ToList();

            return postSummaries;
        }

        public IEnumerable<PostSummary> GetArchive(bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.Where(x => !x.IsDeleted).OrderByDescending(x => x.PublicationDate).Include(x => x.Categories);

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }

            Dictionary<int, int> counts;

            if (isPublic)
            {
                counts = (from post in posts
                          select new { post.Id, C = post.Comments.Count(x => x.IsApproved && !x.IsDeleted) }).ToDictionary(e => e.Id, e => e.C);
            }
            else
            {
                counts = (from post in posts
                          select new { post.Id, C = post.Comments.Count(x => !x.IsDeleted) }).ToDictionary(e => e.Id, e => e.C);
            }

            var postSummaries = (from post in posts.ToList()
                                 select new PostSummary
                                            {
                                                Post = post,
                                                CommentsTotal = counts[post.Id]
                                            }).ToList();

            return postSummaries;
        }

        public int GetTotal(string tag = null, string category = null, string authorUserName = null, DateTime? startDate = null, DateTime? endDate = null, bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.Where(x => !x.IsDeleted);

            if (tag != null)
            {
                posts = posts.Where(x => x.Tags.Any(y => y.Name == tag));
            }

            if (category != null)
            {
                posts = posts.Where(x => x.Categories.Any(y => y.Name == category));
            }

            if (authorUserName != null)
            {
                posts = posts.Where(x => x.Author.Username == authorUserName);
            }

            if (startDate.HasValue)
            {
                posts = posts.Where(x => x.PublicationDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                posts = posts.Where(x => x.PublicationDate <= endDate.Value);
            }

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }
            return posts.Count();
        }

        public Post GetPost(string slug, bool isPublic)
        {
            return GetPost(slug, null, isPublic);
        }

        public Post GetPost(int id, bool isPublic)
        {
            return GetPost(null, id, isPublic);
        }

        public Post GetPreviousPost(Post post, bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.Where(x => !x.IsDeleted).OrderByDescending(x => x.PublicationDate).Where(x => x.PublicationDate <= post.PublicationDate && x.Id != post.Id);

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }

            return posts.FirstOrDefault();
        }

        public Post GetNextPost(Post post, bool isPublic = true)
        {
            IQueryable<Post> posts = Database.Posts.Where(x => !x.IsDeleted).OrderBy(x => x.PublicationDate).Where(x => x.PublicationDate >= post.PublicationDate && x.Id != post.Id);

            if (isPublic)
            {
                posts = posts.WhereIsPublicPost();
            }

            return posts.FirstOrDefault();
        }

        public IEnumerable<Category> GetCategories()
        {
            return Database.Categories.OrderBy(x => x.Name).ToList();
        }

        public IEnumerable<TagWithCount> GetTagsCloud(int minimumPosts)
        {
            var tags = from tag in Database.Tags
                       where tag.Posts.Count() >= minimumPosts
                       orderby tag.Name
                       select new TagWithCount
                                  {
                                      Tag = tag,
                                      PostsCount = tag.Posts.Count()
                                  };

            return tags.ToList();
        }

        public IEnumerable<Tuple<DateTime, int>> GetArchiveCountByMonth(bool descending)
        {
            var months = Database.Posts.GroupBy(data => new {data.PublicationDate.Year, data.PublicationDate.Month});

            if(descending)
            {
                months = months.OrderByDescending(g => g.Key.Year).ThenByDescending(g => g.Key.Month);
            }
            else
            {
                months = months.OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month);
            }

            var monthsProj = months.Select(g => new
                                                    {
                                                        Data = g.Key,
                                                        Count = g.Count()
                                                    }).ToList();

            var monthsTuples = from data in monthsProj
                               select Tuple.Create(new DateTime(data.Data.Year, data.Data.Month, 1), data.Count);

            return monthsTuples;
        }

        public IEnumerable<Tag> GetOrCreateTags(IEnumerable<string> tagsNames)
        {
            var tags = (from tag in Database.Tags
                       where tagsNames.Contains(tag.Name)
                       select tag).ToList();

            var upperTags = tags.Select(x => x.Name.ToUpperInvariant());
            var tagsNotFound = from tag in tagsNames
                               where !upperTags.Contains(tag.ToUpperInvariant())
                               select tag;

            foreach (string newTagName in tagsNotFound)
            {
                Tag newTag = new Tag();
                newTag.Name = newTagName;
                tags.Add(Database.Tags.Add(newTag));
            }
            return tags;
        }
    }
}
