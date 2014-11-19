//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMS.Client.MRP.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class T_PurchaseOrderDetail
    {
        /// <summary>
        /// 明细编码
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 采购单号
        /// </summary>
        public string PONo { get; set; }
        /// <summary>
        /// 物资
        /// </summary>
        public T_StandardMaterial Material { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
