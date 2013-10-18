Sitecore LinkList Field Type.
========

## Updates

This project has been updated to build with Sitecore 7 and .NET 4.5
Guaranteed to work for Glass.Mapper.Sc 3.0.5.14

#### Additions

- Link now has a LinkFieldType enum property for External/Media/Internal

#### Glass Mapper Integration

In GlassMapperScCustom.cs add the following to the CastleConfig method.

    container.Register(
      Component.For<AbstractDataMapper>().ImplementedBy<LinkListDataHandler>().LifeStyle.Transient
    );