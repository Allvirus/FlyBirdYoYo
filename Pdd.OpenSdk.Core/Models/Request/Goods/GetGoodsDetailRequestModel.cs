using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Goods
{
    public partial class GetGoodsDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 1213414
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

    }

}
