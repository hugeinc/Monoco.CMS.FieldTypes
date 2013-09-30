using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monoco.CMS.Fields;

namespace Monoco.CMS.GlassMapper.LinkList
{
    public class LinkList : IEnumerable<Link>
    {
        private IEnumerable<Link> Links { get; set; }

        public LinkList(IEnumerable<Link> links)
        {
            Links = links;
        }

        public IEnumerator<Link> GetEnumerator()
        {
            return Links.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Links.GetEnumerator();
        }
    }
}