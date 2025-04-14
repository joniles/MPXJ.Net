using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class NotesTopicContainer : ProjectEntityContainer<org.mpxj.NotesTopic, NotesTopic>
    {
        public new org.mpxj.NotesTopicContainer JavaObject => (org.mpxj.NotesTopicContainer)base.JavaObject;

        internal NotesTopicContainer(ProxyManager proxyManager, org.mpxj.NotesTopicContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public NotesTopic DefaultTopic => _fromJava(JavaObject.getDefaultTopic());
    }
}
