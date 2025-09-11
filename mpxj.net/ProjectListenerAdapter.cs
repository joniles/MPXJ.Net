using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    internal class ProjectListenerAdapter : org.mpxj.listener.ProjectListener
    {
        private readonly List<IProjectListener> _listeners;

        public ProxyManager ProxyManager { get; set; }
        
        public ProjectListenerAdapter(List<IProjectListener> listeners)
        {
            _listeners = listeners;
        }

        public void taskRead(org.mpxj.Task t) => _listeners.ForEach(l => l.TaskRead(ProxyManager.ProxyObject(t)));
        
        public void taskWritten(org.mpxj.Task t) => _listeners.ForEach(l => l.TaskWritten(ProxyManager.ProxyObject(t)));

        public void resourceRead(org.mpxj.Resource r)  => _listeners.ForEach(l => l.ResourceRead(ProxyManager.ProxyObject(r)));

        public void resourceWritten(org.mpxj.Resource r)  => _listeners.ForEach(l => l.ResourceWritten(ProxyManager.ProxyObject(r)));

        public void calendarRead(org.mpxj.ProjectCalendar pc)  => _listeners.ForEach(l => l.CalendarRead(ProxyManager.ProxyObject(pc)));

        public void calendarWritten(org.mpxj.ProjectCalendar pc)  => _listeners.ForEach(l => l.CalendarWritten(ProxyManager.ProxyObject(pc)));

        public void assignmentRead(org.mpxj.ResourceAssignment ra)  => _listeners.ForEach(l => l.AssignmentRead(ProxyManager.ProxyObject(ra)));

        public void assignmentWritten(org.mpxj.ResourceAssignment ra)  => _listeners.ForEach(l => l.AssignmentWritten(ProxyManager.ProxyObject(ra)));

        public void relationRead(org.mpxj.Relation r)  => _listeners.ForEach(l => l.RelationRead(ProxyManager.ProxyObject(r)));

        public void relationWritten(org.mpxj.Relation r)  => _listeners.ForEach(l => l.RelationWritten(ProxyManager.ProxyObject(r)));
    }
}