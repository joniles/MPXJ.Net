using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class NotesTopic : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.NotesTopic>
    {
        public net.sf.mpxj.NotesTopic JavaObject { get; }

        internal NotesTopic(net.sf.mpxj.NotesTopic javaObject)
        {
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int SequenceNumber => JavaObject.getSequenceNumber().ConvertType().Value;

        public string Name => JavaObject.getName();

        public bool AvailableForEPS => JavaObject.getAvailableForEPS();

        public bool AvailableForProject => JavaObject.getAvailableForProject();

        public bool AvailableForWBS => JavaObject.getAvailableForWBS();

        public bool AvailableForActivity => JavaObject.getAvailableForActivity();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.NotesTopic.Builder>
        {
            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.NotesTopic.Builder(file.JavaObject);
            }

            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.NotesTopic.Builder JavaObject { get; }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder AvailableForEPS(bool value)
            {
                JavaObject.availableForEPS(value);
                return this;
            }

            public Builder AvailableForProject(bool value)
            {
                JavaObject.availableForProject(value);
                return this;
            }

            public Builder AvailableForWBS(bool value)
            {
                JavaObject.availableForWBS(value);
                return this;
            }

            public Builder AvailableForActivity(bool value)
            {
                JavaObject.availableForActivity(value);
                return this;
            }

            public NotesTopic Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
