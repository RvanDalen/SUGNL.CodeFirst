using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using SUGNL.CodeFirst.Webroot.Models.Templates.Base;

namespace SUGNL.CodeFirst.Webroot.Models.Templates.Data
{
	[SitecoreType(true, "{e2e6d59b-5419-4c8b-889c-6bf9f648a99e}")]
	public interface ITitles : ISitecoreItem
	{
		[SitecoreField("{a4de5701-cf6a-4417-973f-29ed9a14ae0b}", SitecoreFieldType.SingleLineText)]
		string TitleText { get; set; }
	}
}
