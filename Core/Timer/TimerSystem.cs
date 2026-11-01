using Godot;
using System;

public partial class TimerSystem : Node
{
    public int Day { get; private set; } = 1;
    public override void _Ready()
    {
        var timer = GetNode<Timer>("MyTimer");
        timer.Timeout += OnTimerTimeout;
        timer.Start();
    }
    public void OnTimerTimeout()
    {
        Day++;
        EventBus.Instance.EmitSignal(EventBus.SignalName.NewDay, Day);
    }
}
