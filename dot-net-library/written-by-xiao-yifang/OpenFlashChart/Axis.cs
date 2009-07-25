using System;
using System.Collections.Generic;
using System.Text;
using JsonFx.Json;


namespace OpenFlashChart
{
    public class Axis
    {
        private int? stroke;
        private string colour;
        private string grid_colour;
        
      
        private int? steps;
        private int _3d;
       
        private double? min;
        private double? max;
        private bool offset;

        [JsonProperty("stroke")]
        public int? Stroke
        {
            set { this.stroke = value; }
            get { return this.stroke; }
        }
        [JsonProperty("colour")]
        public string Colour
        {
            set { this.colour = value; }
            get { return this.colour; }
        }
        [JsonProperty("grid-colour")]
        public string GridColour
        {
            set { this.grid_colour = value; }
            get { return this.grid_colour; }
        }
        [JsonProperty("steps")]
        public int? Steps
        {
            set { steps = value; }
            get { return this.steps; }
        }
        
       
        public void SetColors(string color,string gridcolor)
        {
            this.colour = color;
            this.grid_colour = gridcolor;
        }
        public void Set3D(int width)
        {
            this.Axis3D = width;
        }
       
        [JsonProperty("min")]
        public double? Min
        {
            get { return min; }
            set { this.min = value; }
        }
        [JsonProperty("max")]
        public double? Max
        {
            get { return max; }
            set { this.max = value; }
        }
        [JsonProperty("3d")]
        public int Axis3D
        {
            get { return _3d; }
            set { _3d = value; }
        }

        [JsonProperty("offset")]
        public bool Offset
        {
            set { offset = value; }
            get { return offset; }
        }

        

        public void SetRange(double? min, double? max)
        {
            Max = max;
            Min = min;
        }
    }
}
