using System;

namespace Examples
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }
    public interface IArea
    {
        public float Area { get; set; }
    }
    public interface IPerimeter
    {
        public float Perimeter { get; set; }
    }
    public interface IShape : IArea, IPerimeter
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }
    public struct Rectangle : IShape
    {
        public string Name { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public Color Color { get; set; }
    }
    public struct Circle : IShape
    {
        public string Name { get; set; }
        public float Radius { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public Color Color { get; set; }
    }
    public struct Triangle : IShape
    {
        public string Name { get; set; }
        public float Side1 { get; set; }
        public float Side2 { get; set; }
        public float Side3 { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public Color Color { get; set; }
    }
}