using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HashCode2019.Model;

namespace HashCode2019
{
    class Program
    {
        private InputData _data;

        static void Main(string[] args)
        {
            
        }

        void ReadInputData()
        {
            var lines = File.ReadLines("input.txt").ToList();
            _data = new InputData();
            _data.PhotoCount = Int32.Parse(lines[0]);
            lines.RemoveAt(0);
            _data.PhotoInfo = new List<PhotoParameters>();

            foreach (var line in lines)
            {
                _data.PhotoInfo.Add(new PhotoParameters(line));
            }
        }
    }
}
