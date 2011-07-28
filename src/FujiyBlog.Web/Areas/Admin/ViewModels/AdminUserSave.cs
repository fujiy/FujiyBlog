﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FujiyBlog.Web.Areas.Admin.ViewModels
{
    public class AdminUserSave
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Username { get; set; }

        [Required, StringLength(255), RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [StringLength(20)]
        public string DisplayName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(20)]
        public string Location { get; set; }

        [StringLength(500)]
        public string About { get; set; }
    }
}