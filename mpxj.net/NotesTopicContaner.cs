using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: ProjectEntityContainer
    public class NotesTopicContainer : ShallowProxyList<net.sf.mpxj.NotesTopic>, IJavaObjectProxy<net.sf.mpxj.NotesTopicContainer>
    {
        public new net.sf.mpxj.NotesTopicContainer JavaObject { get => (net.sf.mpxj.NotesTopicContainer)base.JavaObject; }

        internal NotesTopicContainer(net.sf.mpxj.NotesTopicContainer javaObject) : base(javaObject) { }

        public net.sf.mpxj.NotesTopic DefaultTopic
        {
            get => JavaObject.getDefaultTopic();
        }
    }
}
