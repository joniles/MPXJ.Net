using org.mpxj.proxy;

namespace org.mpxj
{
    public class NotesTopic : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.NotesTopic>
    {
        public net.sf.mpxj.NotesTopic JavaObject { get; }

        internal NotesTopic(net.sf.mpxj.NotesTopic javaObject)
        {
            JavaObject = javaObject;
        }

        public NotesTopic(java.lang.Integer uniqueID, java.lang.Integer sequenceNumber, string name, bool availableForEPS, bool availableForProject, bool availableForWBS, bool availableForActivity)
        {
            JavaObject = new net.sf.mpxj.NotesTopic(uniqueID, sequenceNumber, name, availableForEPS, availableForProject, availableForWBS, AvailableForActivity);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public java.lang.Integer SequenceNumber => JavaObject.getSequenceNumber();

        public string Name => JavaObject.getName();

        public bool AvailableForEPS => JavaObject.getAvailableForEPS();

        public bool AvailableForProject => JavaObject.getAvailableForProject();

        public bool AvailableForWBS => JavaObject.getAvailableForWBS();

        public bool AvailableForActivity => JavaObject.getAvailableForActivity();
    }
}

