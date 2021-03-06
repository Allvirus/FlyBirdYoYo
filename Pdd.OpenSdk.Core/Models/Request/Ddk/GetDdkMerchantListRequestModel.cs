using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Ddk
{
    public partial class GetDdkMerchantListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id_list")]
        public string MallIdList { get; set; }
        /// <summary>
        /// 店铺类型
        /// </summary>
        [JsonProperty("merchant_type_list")]
        public string MerchantTypeList { get; set; }
        /// <summary>
        /// 查询范围0----商品拼团价格区间；1----商品券后价价格区间；2----佣金比例区间；3----优惠券金额区间；4----加入多多进宝时间区间；5----销量区间；6----佣金金额区间
        /// </summary>
        [JsonProperty("query_range_str")]
        public string QueryRangeStr { get; set; }
        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        [JsonProperty("cat_id")]
        public int? CatId { get; set; }
        /// <summary>
        /// 是否有优惠券 （0 所有；1 必须有券。）
        /// </summary>
        [JsonProperty("has_coupon")]
        public int? HasCoupon { get; set; }
        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_number")]
        public int? PageNumber { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 筛选范围
        /// </summary>
        [JsonProperty("range_vo_list")]
        public RangeVoListRequestModel RangeVoList { get; set; }
        public partial class RangeVoListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 起始数值
            /// </summary>
            [JsonProperty("range_from")]
            public int? RangeFrom { get; set; }
            /// <summary>
            /// 结束数值
            /// </summary>
            [JsonProperty("range_to")]
            public int? RangeTo { get; set; }
            /// <summary>
            /// 筛选方式：0----商品拼团价格区间；1----商品券后价价格区间；2----佣金比例区间；3----优惠券金额区间；4----加入多多进宝时间区间；5----销量区间；6----佣金金额区间
            /// </summary>
            [JsonProperty("range_id")]
            public int? RangeId { get; set; }

        }

    }

}
