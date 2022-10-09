using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Project1.Web;

[Dependency(ReplaceServices = true)]
public class Project1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Project1";
}
