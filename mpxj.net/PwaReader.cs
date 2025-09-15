using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PwaReader : IJavaObjectProxy<org.mpxj.pwa.PwaReader>
    {
        public org.mpxj.pwa.PwaReader JavaObject { get; }
        private readonly ProxyManager _proxyManager = new ProxyManager();
        
        public PwaReader(string host, string token)
        {
            JavaObject = new org.mpxj.pwa.PwaReader(host, token);
        }
        
        public IList<PwaProject> GetProjects() => _proxyManager.ProxyList<org.mpxj.pwa.PwaProject, PwaProject>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjects());

        public ProjectFile ReadProject(Guid? id) => id == null ? null : _proxyManager.ProxyObject(JavaObject.readProject(id.ConvertType()));
    }
}