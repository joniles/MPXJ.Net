using System.Collections.Generic;
using System.IO;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class WebServicesReader: IJavaObjectProxy<org.mpxj.primavera.webservices.WebServicesReader>
    {
        public org.mpxj.primavera.webservices.WebServicesReader JavaObject { get; }
        private readonly ProxyManager _proxyManager = new ProxyManager();

        public WebServicesReader(string url, string databaseName, string user, string password)
        {
            JavaObject = new org.mpxj.primavera.webservices.WebServicesReader(url, databaseName, user, password);
        }

        public WebServicesReader(string url, string bearerToken)
        {
            JavaObject = new org.mpxj.primavera.webservices.WebServicesReader(url, bearerToken);
        }

        public IList<WebServicesProject> GetProjects() => _proxyManager.ProxyList<org.mpxj.primavera.webservices.WebServicesProject, WebServicesProject>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjects());

        public void ExportProject(WebServicesProject project, string filename, WebServicesExportType type, bool includeBaseline, bool compressed) => JavaObject.exportProject(project.JavaObject, filename, type.ConvertType(), includeBaseline, compressed);

        public void ExportProject(WebServicesProject project, Stream stream, WebServicesExportType type, bool includeBaseline, bool compressed) => JavaObject.exportProject(project.JavaObject, new ProxyOutputStream(stream), type.ConvertType(), includeBaseline, compressed);

        public ProjectFile ReadProject(WebServicesProject project) => _proxyManager.ProxyObject(JavaObject.readProject(project.JavaObject));

        public ProjectFile ReadProject(WebServicesProject project, bool includeBaseline) => _proxyManager.ProxyObject(JavaObject.readProject(project.JavaObject, includeBaseline));
    }
}