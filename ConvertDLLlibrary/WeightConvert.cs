using System;

namespace ConvertDLLLibraryG
{
    public static class WeightConvert
    {
        private const double OzToGram = 28.349;
        private const double GramToOz = 0.0352;

        public static double OzToGrams(double OZ)
        {
            return OZ * OzToGram;
        }

        public static double GramToOzs(double grams)
        {
            return grams * GramToOz;
        }
    }
}
