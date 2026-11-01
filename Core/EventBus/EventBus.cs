using Godot;
using System;

public partial class EventBus : Node
{
    public static EventBus Instance { get; private set; }

    public override void _Ready()
    {
        Instance = this;
    }
#region 时间事件
    /// <summary>
    /// 新一天
    /// </summary>
    [Signal]
    public delegate void  NewDayEventHandler(int day);
    /// <summary>
    /// 新一个月
    /// </summary>
    [Signal]
    public delegate void  NewMonthEventHandler();
    /// <summary>
    /// 新一年
    /// </summary>
    [Signal]
    public delegate void  NewYearEventHandler();
#endregion
#region 经济事件
    /// <summary>
    /// 确认交易
    /// </summary>
    [Signal]
    public delegate void  ConfirmTradeEventHandler();
#endregion
#region 任务事件
    /// <summary>
    /// 任务发布
    /// </summary>
    [Signal]
    public delegate void  AssignmentReleaseEventHandler();
    /// <summary>
    /// 任务完成
    /// </summary>
    [Signal]
    public delegate void  AssignmentCompletedEventHandler();
#endregion
#region 随机事件
    /// <summary>
    /// 随机事件触发
    /// </summary>
    [Signal]
    public delegate void  RandomEventTriggerEventHandler();
#endregion
#region 城市事件
#endregion
#region 国家事件
#endregion
#region 行会事件
#endregion
#region 商会事件
#endregion
#region 声望事件
#endregion
#region 人物事件
#endregion
#region 地图事件
#endregion
}
