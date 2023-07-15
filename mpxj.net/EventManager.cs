using org.mpxj.proxy;

namespace org.mpxj
{
    public class EventManager : IJavaObjectProxy<net.sf.mpxj.EventManager>
    {
        public net.sf.mpxj.EventManager JavaObject { get; }

        internal EventManager(net.sf.mpxj.EventManager javaObject)
        {
            JavaObject = javaObject;
        }

        // TODO: implement if required
        //public void AddProjectListener(IProjectListener listener)
        //public void AddProjectListeners(IList<IProjectListener> listeners)
        //public void RemoveProjectListener(IProjectListener listener)
    }
}

