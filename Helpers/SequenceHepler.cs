namespace HashCode2019.Helpers
{
    using HashCode2019.Model;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceHepler
    {
        public SequenceHepler() { }
   
        public static SequenceResult Compare(List<string> seq1, List<string> seq2)
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

        //private static List<string> Union(List<string> seq1, List<string> seq2)
        //{
        //    return seq1.Union(seq2).ToList();
        //}
    }
}
