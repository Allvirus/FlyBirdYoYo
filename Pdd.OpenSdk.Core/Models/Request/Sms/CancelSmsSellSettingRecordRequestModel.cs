using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Sms
{
    public partial class CancelSmsSellSettingRecordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

    }

}
