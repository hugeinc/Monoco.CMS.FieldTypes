using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Configuration;
using Monoco.CMS.Fields;

namespace Monoco.CMS.GlassMapper.LinkList
{
    public class LinkListDataHandler : Glass.Mapper.Sc.DataMappers.AbstractSitecoreFieldMapper
    {
        public LinkListDataHandler()
            : base(typeof (LinkList))
        {

        }

        public override object GetFieldValue(string fieldValue, Glass.Mapper.Sc.Configuration.SitecoreFieldConfiguration config, Glass.Mapper.Sc.SitecoreDataMappingContext context)
        {
            throw new NotImplementedException();
        }

        public override string SetFieldValue(object value, Glass.Mapper.Sc.Configuration.SitecoreFieldConfiguration config, Glass.Mapper.Sc.SitecoreDataMappingContext context)
        {
            throw new NotImplementedException();
        }

        public override object GetField(Sitecore.Data.Fields.Field field, SitecoreFieldConfiguration config, SitecoreDataMappingContext context)
        {

            if (field == null || string.IsNullOrEmpty(field.Value.Trim())) return null;

            List<Link> links = new List<Link>();
            Monoco.CMS.Fields.LinkListField linksField = new Monoco.CMS.Fields.LinkListField(field);

            foreach (var link in linksField.Links)
            {
                links.Add(link);
            }

            LinkList linkList = new LinkList(links);

            return linkList;
        }
    }
}