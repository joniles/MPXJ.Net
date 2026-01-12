using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MsPlannerReader : IJavaObjectProxy<org.mpxj.msplanner.MsPlannerReader>
    {
        public org.mpxj.msplanner.MsPlannerReader JavaObject { get; }
        private readonly ProxyManager _proxyManager = new ProxyManager();
        
        public MsPlannerReader(string host, string token)
        {
            JavaObject = new org.mpxj.msplanner.MsPlannerReader(host, token);
        }
        
        public IList<MsPlannerProject> GetProjects() => _proxyManager.ProxyList<org.mpxj.msplanner.MsPlannerProject, MsPlannerProject>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjects());

        public ProjectFile ReadProject(Guid? id) => id == null ? null : _proxyManager.ProxyObject(JavaObject.readProject(id.ConvertType()));
    }
}