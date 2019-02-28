using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode2019.Model
{
    public class PhotoParameters
    {
        public int Id { get;}
        public Orientation Orientation { get; }
        public IEnumerable<string> Tags { get; }

        public PhotoParameters(string inputLine)
        {
            var parameters = inputLine.Split(inputLine);
            Id = Int32.Parse(parameters[0]);
            Orientation = parameters[1] == "H" ? Orientation.Horizontal : Orientation.Vertical;
            Tags = new List<string>(parameters.Select(p => p));
        }
    }

    public enum Orientation
    {
        Horizontal,
        Vertical
    }
}
