using Godot;
using System;

/// <summary>
/// 商品等级枚举类型
/// </summary>
public enum GoodsTierEnum
{
    /// <summary>
    /// 原材料：农场/矿场产出
    /// </summary>
    RawMaterial,
    /// <summary>
    /// 制成品：加工厂产出
    /// </summary>
    ProcessedGood,
    /// <summary>
    /// 进口奢侈品：本地不能生产
    /// </summary>
    LuxuryImport,
    /// <summary>
    /// 违禁品：特殊规则
    /// </summary>
    Contraband,
}
/// <summary>
/// s商品类别枚举类型
/// </summary>
public enum GoodsCategoryEnum
{
    /// <summary>
    /// 农产品
    /// </summary>
    Agricultural,
    /// <summary>
    /// 畜牧产品
    /// </summary>
    Livestock,
    /// <summary>
    /// 林产品
    /// </summary>
    Forestry,
    /// <summary>
    /// 矿产产品
    /// </summary>
    Mining,
    /// <summary>
    /// 水产产品
    /// </summary>
    Fishery,
    /// <summary>
    /// 纺织产品
    /// </summary>
    Textile,
    /// <summary>
    /// 木材加工产品
    /// </summary>
    Woodwork,
    /// <summary>
    /// 金属加工产品
    /// </summary>
    Metalwork,
    /// <summary>
    /// 食品加工产品
    /// </summary>
    FoodProcessed,
    /// <summary>
    /// 奢侈品产品
    /// </summary>
    Luxury,
    /// <summary>
    /// 违禁品
    /// </summary>
    Contraband,
}