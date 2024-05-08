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

        public class Builder
        {
            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.NotesTopic.Builder(file.JavaObject);
            }

            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.NotesTopic.Builder _javaObject;

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                _javaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                _javaObject.name(value);
                return this;
            }

            public Builder AvailableForEPS(bool value)
            {
                _javaObject.availableForEPS(value);
                return this;
            }

            public Builder AvailableForProject(bool value)
            {
                _javaObject.availableForProject(value);
                return this;
            }

            public Builder AvailableForWBS(bool value)
            {
                _javaObject.availableForWBS(value);
                return this;
            }

            public Builder AvailableForActivity(bool value)
            {
                _javaObject.availableForActivity(value);
                return this;
            }

            public NotesTopic Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
