using System.Collections.Generic;
using System.IO;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class OpcReader : IJavaObjectProxy<org.mpxj.opc.OpcReader>
    {
        public org.mpxj.opc.OpcReader JavaObject { get; }
        private readonly ProxyManager _proxyManager = new ProxyManager();

        public OpcReader(string host, string user, string password)
        {
            JavaObject = new org.mpxj.opc.OpcReader(host, user, password);
        }
        
        public IList<OpcProject> GetProjects() => _proxyManager.ProxyList<org.mpxj.opc.OpcProject, OpcProject>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjects());
        
        public IList<OpcProjectBaseline> GetProjectBaselines(OpcProject project) => _proxyManager.ProxyList<org.mpxj.opc.OpcProjectBaseline, OpcProjectBaseline>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjectBaselines(project.JavaObject));

        public void ExportProject(OpcProject project, string filename, OpcExportType type, bool compressed) => JavaObject.exportProject(project.JavaObject, filename, type.ConvertType(), compressed);
        
        public void ExportProject(OpcProject project, IList<OpcProjectBaseline> baselines, string filename, OpcExportType type, bool compressed) => JavaObject.exportProject(project.JavaObject, baselines.ConvertType(), filename, type.ConvertType(), compressed);
        
        public void ExportProject(OpcProject project, Stream stream, OpcExportType type, bool compressed) => JavaObject.exportProject(project.JavaObject, new ProxyOutputStream(stream), type.ConvertType(), compressed);
        
        public void ExportProject(OpcProject project, IList<OpcProjectBaseline> baselines, Stream stream, OpcExportType type, bool compressed) => JavaObject.exportProject(project.JavaObject, baselines.ConvertType(), new ProxyOutputStream(stream), type.ConvertType(), compressed);
        
        public ProjectFile ReadProject(OpcProject project)
        {
            var result = JavaObject.readProject(project.JavaObject);
            return result == null ? null : new ProjectFile(result);
        }

        public ProjectFile ReadProject(OpcProject project, List<OpcProjectBaseline> baselines)
        {
            var result = JavaObject.readProject(project.JavaObject, baselines.ConvertType());
            return result == null ? null : new ProjectFile(result);
        }
    }
}