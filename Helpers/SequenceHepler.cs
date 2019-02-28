namespace HashCode2019.Helpers
{
    using HashCode2019.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceHepler
    {
        public SequenceHepler() { }

        public static void Proccess(InputData data)
        {
            for (var i = 0; i < data.PhotoInfo.Count; i++)
            {
                if (i + 1 >= data.PhotoInfo.Count) continue;

                var currentItem = data.PhotoInfo[i];
                var nextItem = data.PhotoInfo[i + 1];
                var currentList = currentItem.Tags.ToList();
                var comparationValue = Compare(currentList, nextItem.Tags.ToList()).InterestFactor;
                for (var j = i + 1; j < data.PhotoInfo.Count; j++)
                {
                    var newComparationValue = Compare(currentList, data.PhotoInfo[j].Tags.ToList()).InterestFactor;
                    if (newComparationValue > comparationValue)
                    {
                        Console.WriteLine(data.PhotoInfo[i + 1] + " <=> " + data.PhotoInfo[j]);

                        data.PhotoInfo[i + 1] = data.PhotoInfo[j];
                        data.PhotoInfo[j] = nextItem;

                        Console.WriteLine("new: " + data.PhotoInfo[i + 1] + " <=> " + data.PhotoInfo[j]);
                    }
                }
            }
        }

        private static SequenceResult Compare(List<string> seq1, List<string> seq2)
        {
            var result = new SequenceResult();
            if (seq1 != null && seq2 != null)
            {
                result.CommonTags = Intersect(seq1, seq2).Count;
                result.FirstSequenceIntersect = Except(seq1, seq2).Count;
                result.SecondSequenceIntersect = Except(seq2, seq1).Count;
                result.InterestFactor = (new int[3] { result.CommonTags, result.FirstSequenceIntersect, result.SecondSequenceIntersect }).Min();
            }

            return result;
        }

        private static List<string> Except(List<string> seq1, List<string> seq2)
        {
            return seq1.Except(seq2).ToList();
        }

        private static List<string> Intersect(List<string> seq1, List<string> seq2)
        {
            return seq1.Intersect(seq2).ToList();
        }

        private static List<string> Union(List<string> seq1, List<string> seq2)
        {
            return seq1.Union(seq2).ToList();
        }
    }
}
