using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoC.Sitecore.CodeFirstRenderings.DataProviders;
using SUGNL.CodeFirst.Webroot.Models.Templates.Base;
using SUGNL.CodeFirst.Webroot.Models.Templates.Data;
using SUGNL.CodeFirst.Webroot.Models.Templates.Parameters;

namespace SUGNL.CodeFirst.Webroot.Controllers
{
	public class ComponentController : Controller
	{
		[ControllerAction("{6cc8251d-e8d7-4432-bd72-837443450e53}")]
		[DataSourceLocation("./")]
		[Cacheable(VaryByData = true, VaryByParm = true)]
		//[DataSourceTemplate("templateId")]
		//[ParametersTemplate("")]
		//[ExperienceEditorButtons((""))]
		//[FieldValue("", "")]
		public ActionResult Title(ISitecoreItem contextItem, ITitles datasource, IHeadingParameters renderingParameters)
		{
			return View(new TitleViewModel
			{
				Datasource = datasource,
				Parameters = renderingParameters
			});
		}
	}

	public class TitleViewModel
	{
		public ITitles Datasource { get; set; }

		public IHeadingParameters Parameters { get; set; }
	}
}