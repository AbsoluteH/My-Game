using Godot;
using System;

[GlobalClass]
public partial class StaticData_City : Resource
{
    [Export]
    public string CityName { get; set; }
    [Export]
    public Texture2D CityImage { get; set; }
    [Export]
    public CitySizeEnum CitySize { get; set; }
}
