using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace BlazorServerApp.Controllers
{
    /// <summary>
    /// Test
    /// </summary>
    /// <param name="retcode">返回码</param>
    /// <param name="data">返回的数据</param>
    /// <param name="text">返回的描述文字</param>
    /// [ApiController]
    [Tags("Test")]
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TestController : BaseController
    {
        [HttpGet]
        public JObject Test(string id)
        {
            JObject j = new JObject();
            JObject data = new JObject();
            j["retcode"] = 0;
            j["data"] = data;
            j["text"] = null;
            try
            {
                j["retcode"] = 0;
                j["text"] = "Success";
                data["id"] = id;
            }
            catch (Exception ex)
            {
                j["retcode"] = 1;
                j["text"] = JsonConvert.DeserializeObject<JToken>(JsonConvert.SerializeObject(ex));
            }
            return j;
        }
    }
}
