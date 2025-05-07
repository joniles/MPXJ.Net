using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class WorkContour : IProjectEntityWithUniqueID, IJavaObjectProxy<org.mpxj.WorkContour>
    {
        public org.mpxj.WorkContour JavaObject { get; }

        internal WorkContour(org.mpxj.WorkContour javaObject)
        {
            JavaObject = javaObject;
        }

        public WorkContour(int? uniqueId, string name, bool isDefault, double[] curveValues)
        {
            JavaObject = new org.mpxj.WorkContour(uniqueId.ConvertType(), name, isDefault, curveValues);
        }

        public static readonly WorkContour Flat = new WorkContour(org.mpxj.WorkContour.FLAT);
        public static readonly WorkContour BackLoaded = new WorkContour(org.mpxj.WorkContour.BACK_LOADED);
        public static readonly WorkContour FrontLoaded = new WorkContour(org.mpxj.WorkContour.FRONT_LOADED);
        public static readonly WorkContour DoublePeak = new WorkContour(org.mpxj.WorkContour.DOUBLE_PEAK);
        public static readonly WorkContour EarlyPeak = new WorkContour(org.mpxj.WorkContour.EARLY_PEAK);
        public static readonly WorkContour LatePeak = new WorkContour(org.mpxj.WorkContour.LATE_PEAK);
        public static readonly WorkContour Bell = new WorkContour(org.mpxj.WorkContour.BELL);
        public static readonly WorkContour Turtle = new WorkContour(org.mpxj.WorkContour.TURTLE);
        public static readonly WorkContour Contoured = new WorkContour(org.mpxj.WorkContour.CONTOURED);

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => throw new System.NotImplementedException();
        }

        public double[] CurveValues => JavaObject.getCurveValues();

        public string Name => JavaObject.getName();

        public bool IsContourManual => JavaObject.isContourManual();

        public bool IsContourFlat => JavaObject.isContourFlat();

        public bool IsContourDefault => JavaObject.isContourDefault();

        public override string ToString() => JavaObject.toString();
    }
}
