using System;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace SUGNL.CodeFirst.Webroot.Models.Templates.Base
{
	public interface ISitecoreItem
	{
		[SitecoreId]
		Guid Id { get; set; }

		[SitecoreInfo(SitecoreInfoType.Name)]
		string Name { get; set; }
	}
}
