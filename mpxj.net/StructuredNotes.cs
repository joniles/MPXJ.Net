using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class StructuredNotes : Notes, IJavaObjectProxy<net.sf.mpxj.StructuredNotes>
    {
        private readonly ProxyManager _proxyManager;

        public new net.sf.mpxj.StructuredNotes JavaObject => (net.sf.mpxj.StructuredNotes)base.JavaObject;

        internal StructuredNotes(ProxyManager proxyManager, net.sf.mpxj.StructuredNotes value) : base(value) 
        {
            _proxyManager = proxyManager;
        }

        public StructuredNotes(ProjectFile file, int uniqueId, NotesTopic topic, Notes notes) : base(new net.sf.mpxj.StructuredNotes(file.JavaObject, uniqueId.ConvertType(), topic.JavaObject, notes.JavaObject))
        {
            _proxyManager = file._proxyManager;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();
    
        public int? TopicID => JavaObject.getTopicID().ConvertType();

        public NotesTopic NotesTopic => _proxyManager.ProxyObject(JavaObject.getNotesTopic());

        public Notes Notes => _proxyManager.ProxyObject(JavaObject.getNotes());
    }
}
