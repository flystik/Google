using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode2019.Model
{
    public class PhotoParameters
    {
        public static int PhotoCounter = 0;

        public int Id { get;}
        public int TagCount { get; }
        public Orientation Orientation { get; }
        public IEnumerable<string> Tags { get; }

        public PhotoParameters(string inputLine)
        {
            var parameters = inputLine.Split(' ');
            TagCount = Int32.Parse(parameters[1]);
            Id = PhotoCounter++;
            Orientation = parameters[0] == "H" ? Orientation.Horizontal : Orientation.Vertical;
            Tags = new List<string>(parameters.Skip(2).Select(p => p));
        }
    }

    public enum Orientation
    {
        Horizontal,
        Vertical
    }
}
