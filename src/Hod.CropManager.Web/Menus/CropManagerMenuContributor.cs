using System.Threading.Tasks;
using Hod.CropManager.Localization;
using Hod.CropManager.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Hod.CropManager.Web.Menus;

public class CropManagerMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<CropManagerResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                CropManagerMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        context.Menu.AddItem(
            new ApplicationMenuItem(CropManagerMenus.CropManagement, l["Menu:CropManagement"], icon: "fas fa-leaf")
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Crop, l["Menu:Crop"], "/CropManager/Domain/Crop"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.CropType, l["Menu:CropType"], "/CropManager/Domain/CropType"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Field, l["Menu:Field"], "/CropManager/Domain/Field"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Harvest, l["Menu:Harvest"], "/CropManager/Domain/Harvest"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Equipment, l["Menu:Equipment"], "/CropManager/Domain/Equipment"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.LandPreparation, l["Menu:LandPreparation"], "/CropManager/Domain/LandPreparation"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.IssueType, l["Menu:IssueType"], "/CropManager/Domain/IssueType"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Fertilizer, l["Menu:Fertilizer"], "/CropManager/Domain/Fertilizer"))
                .AddItem(new ApplicationMenuItem(CropManagerMenus.Pesticide, l["Menu:Pesticide"], "/CropManager/Domain/Pesticide"))
            );

        return Task.CompletedTask;
    }
}
