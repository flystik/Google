using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HashCode2019.Model;

namespace HashCode2019.Helpers
{
    public static class PhotoHelper
    {
        public static PhotoParameters ToHorizontalPhoto(PhotoParameters p1, PhotoParameters p2)
        {
            var tags = p1.Tags.Union(p2.Tags).ToList();
            return new PhotoParameters()
            {
                Id = String.Join(' ', p1.Id, p2.Id),
                Orientation = Orientation.Horizontal,
                Tags = tags,
                TagCount = tags.Count
            };
        }
    }
}
