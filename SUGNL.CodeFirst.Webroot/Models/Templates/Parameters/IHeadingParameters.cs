using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using SUGNL.CodeFirst.Webroot.Models.Templates.Base;

namespace SUGNL.CodeFirst.Webroot.Models.Templates.Parameters
{
	[SitecoreType(true, "{9be51280-b78a-4f35-9772-73ef4b1a2ed4}")]
	public interface IHeadingParameters : IStandardRenderingParameters
	{
		[SitecoreField("{9a4e92da-cfac-45b4-a65e-e89a7d7c5f68}", SitecoreFieldType.Droplist, FieldSource = "/sitecore/content/Heading Size")]
		string HeadingSize { get; set; }
	}
}
