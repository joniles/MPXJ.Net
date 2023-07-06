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

        public void AddProjectListener(net.sf.mpxj.listener.ProjectListener listener)
        {
            JavaObject.addProjectListener(listener);
        }

        public void AddProjectListeners(java.util.List listeners)
        {
            JavaObject.addProjectListeners(listeners);
        }

        public void RemoveProjectListener(net.sf.mpxj.listener.ProjectListener listener)
        {
            JavaObject.removeProjectListener(listener);
        }
    }
}

