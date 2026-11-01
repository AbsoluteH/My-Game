using Godot;
using System;

public partial class TemplateCity2dNodeScript : Node2D
{
    [Export]
    public string CityName { get; set; }
    [Export]
    public Texture2D CityTexture { get; set; }
}
