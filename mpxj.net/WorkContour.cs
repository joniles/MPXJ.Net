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

        public readonly WorkContour Flat = new WorkContour(net.sf.mpxj.WorkContour.FLAT);
        public readonly WorkContour BackLoaded = new WorkContour(net.sf.mpxj.WorkContour.BACK_LOADED);
        public readonly WorkContour FrontLoaded = new WorkContour(net.sf.mpxj.WorkContour.FRONT_LOADED);
        public readonly WorkContour DoublePeak = new WorkContour(net.sf.mpxj.WorkContour.DOUBLE_PEAK);
        public readonly WorkContour EarlyPeak = new WorkContour(net.sf.mpxj.WorkContour.EARLY_PEAK);
        public readonly WorkContour LatePeak = new WorkContour(net.sf.mpxj.WorkContour.LATE_PEAK);
        public readonly WorkContour Bell = new WorkContour(net.sf.mpxj.WorkContour.BELL);
        public readonly WorkContour Turtle = new WorkContour(net.sf.mpxj.WorkContour.TURTLE);
        public readonly WorkContour Contoured = new WorkContour(net.sf.mpxj.WorkContour.CONTOURED);

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public double[] CurveValues
        {
            get => JavaObject.getCurveValues();
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public bool IsContourManual
        {
            get => JavaObject.isContourManual();
        }

        public bool IsContourFlat
        {
            get => JavaObject.isContourFlat();
        }

        public bool IsContourDefault
        {
            get => JavaObject.isContourDefault();
        }

        public override string ToString() => JavaObject.toString();
    }
}
