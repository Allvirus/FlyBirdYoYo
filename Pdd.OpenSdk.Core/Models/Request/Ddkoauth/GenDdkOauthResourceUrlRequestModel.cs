using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Ddkoauth
{
    public partial class GenDdkOauthResourceUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广位
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 频道来源：4-限时秒杀
        /// </summary>
        [JsonProperty("resource_type")]
        public int? ResourceType { get; set; }

    }

}
