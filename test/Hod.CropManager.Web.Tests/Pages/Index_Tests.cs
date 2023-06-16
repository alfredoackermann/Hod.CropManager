using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Hod.CropManager.Pages;

public class Index_Tests : CropManagerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
