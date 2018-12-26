using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Goods
{
    public partial class QueryGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

    }

}
