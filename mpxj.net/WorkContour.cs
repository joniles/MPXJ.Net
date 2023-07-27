using org.mpxj.proxy;

namespace org.mpxj
{
    public class WorkContour : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.WorkContour>
    {
        public net.sf.mpxj.WorkContour JavaObject { get; }

        internal WorkContour(net.sf.mpxj.WorkContour javaObject)
        {
            JavaObject = javaObject;
        }

        public static readonly WorkContour Flat = new WorkContour(net.sf.mpxj.WorkContour.FLAT);
        public static readonly WorkContour BackLoaded = new WorkContour(net.sf.mpxj.WorkContour.BACK_LOADED);
        public static readonly WorkContour FrontLoaded = new WorkContour(net.sf.mpxj.WorkContour.FRONT_LOADED);
        public static readonly WorkContour DoublePeak = new WorkContour(net.sf.mpxj.WorkContour.DOUBLE_PEAK);
        public static readonly WorkContour EarlyPeak = new WorkContour(net.sf.mpxj.WorkContour.EARLY_PEAK);
        public static readonly WorkContour LatePeak = new WorkContour(net.sf.mpxj.WorkContour.LATE_PEAK);
        public static readonly WorkContour Bell = new WorkContour(net.sf.mpxj.WorkContour.BELL);
        public static readonly WorkContour Turtle = new WorkContour(net.sf.mpxj.WorkContour.TURTLE);
        public static readonly WorkContour Contoured = new WorkContour(net.sf.mpxj.WorkContour.CONTOURED);

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public double[] CurveValues => JavaObject.getCurveValues();

        public string Name => JavaObject.getName();

        public bool IsContourManual => JavaObject.isContourManual();

        public bool IsContourFlat => JavaObject.isContourFlat();

        public bool IsContourDefault => JavaObject.isContourDefault();

        public override string ToString() => JavaObject.toString();
    }
}
