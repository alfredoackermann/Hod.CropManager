using Volo.Abp.Settings;

namespace Hod.CropManager.Settings;

public class CropManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CropManagerSettings.MySetting1));
    }
}
