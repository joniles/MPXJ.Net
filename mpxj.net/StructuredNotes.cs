using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class StructuredNotes : Notes, IJavaObjectProxy<org.mpxj.StructuredNotes>
    {
        private readonly ProxyManager _proxyManager;

        public new org.mpxj.StructuredNotes JavaObject => (org.mpxj.StructuredNotes)base.JavaObject;

        internal StructuredNotes(ProxyManager proxyManager, org.mpxj.StructuredNotes value) : base(value) 
        {
            _proxyManager = proxyManager;
        }

        public StructuredNotes(ProjectContext context, int uniqueId, NotesTopic topic, Notes notes) : base(new org.mpxj.StructuredNotes(context.JavaObject, uniqueId.ConvertType(), topic.JavaObject, notes.JavaObject))
        {
            _proxyManager = context._proxyManager;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();
    
        public int? TopicID => JavaObject.getTopicID().ConvertType();

        public NotesTopic NotesTopic => _proxyManager.ProxyObject(JavaObject.getNotesTopic());

        public Notes Notes => _proxyManager.ProxyObject(JavaObject.getNotes());
    }
}
