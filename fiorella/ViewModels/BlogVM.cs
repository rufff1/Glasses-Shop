using fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.ViewModels
{
    public class BlogVM
    {
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BlogTag> BlogTags { get; set; }
        public Blog Blog { get; set; }
    }
}
