using org.mpxj.proxy;

namespace org.mpxj
{
    public class NotesTopicContainer : ProjectEntityContainer<net.sf.mpxj.NotesTopic, NotesTopic>
    {
        public new net.sf.mpxj.NotesTopicContainer JavaObject { get => (net.sf.mpxj.NotesTopicContainer)base.JavaObject; }

        internal NotesTopicContainer(ProxyManager proxyManager, net.sf.mpxj.NotesTopicContainer javaObject) : base(proxyManager, javaObject) { }

        public NotesTopic DefaultTopic
        {
            get => _proxyManager.ProxyObject(JavaObject.getDefaultTopic());
        }
    }
}
