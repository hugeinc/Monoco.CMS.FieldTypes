using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace Monoco.CMS.Fields
{
    public class Link
    {
        public string AltTitle { get; set; }  // xml title
        public string Title { get; set; }  // xml text
        public string Url { get; set; }
        public string Target { get; set; }
        public string LinkType { get; set; }
        public string DynamicLinkUrl { get; set; }
        public string QueryString { get; set; }
        public string Class { get; set; }
        public string Anchor { get; set; }

        public Item TargetItem { get; set; }

        public LinkFieldType LinkFieldType { get; set; }
    }

    public enum LinkFieldType
    {
        External,
        Media,
        Internal,
    }
}