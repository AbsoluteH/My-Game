using Godot;
using System;

public partial class Label : Godot.Label
{
        public override void _Ready()
    {
        GD.Print("label 就绪");
        Text = "ssaa";
        var eventBus = GetNode<EventBus>("/root/EventBus");
        eventBus.NewDay += day =>
        {
        GD.Print("label 运行");
            Text = $"第 {day} 天";   // 操作自己的属性，不用 GetNode 找 Label
        };  
    }
}
