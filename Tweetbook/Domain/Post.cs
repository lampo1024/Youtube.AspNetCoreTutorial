using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Tweetbook.Domain
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }

        public virtual List<PostTag> Tags { get; set; }
    }
}