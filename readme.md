# SUGNL.CodeFirst
This is the result of the live demo I gave about CodeFirst at the Sitecore User Group.

To get it to work on your machine:
* Install a clean Sitecore solution somewhere
* Add a File System publishing target to the Visual Studio solution which points to the clean Sc webroot
* Copy the Sitecore dlls to /local_packages/Sitecore
* Publish to the clean Sc instance

On application start it will:
* Generate Templates under /sitecore/templates/GlassTemplates
* Generate Controller Renderings under /sitecore/layouts/renderings/MVC Actions

Final note: one Lumi package I have included as local_package because I found a bug that I fixed but have not published to Nuget yet.
Blogpost will follow shortly.