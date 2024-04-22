using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement builder
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
    }
}

