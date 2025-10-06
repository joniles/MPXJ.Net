using MPXJ.Net.Proxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MPXJ.Net
{
    public class UniversalProjectReader : AbstractProjectReader
    {
        public interface IProjectReaderProxy : IDisposable
        {
            IProjectReader ProjectReader { get; }

            ProjectFile Read();

            IList<ProjectFile> ReadAll();
        }

        private class ProjectReaderProxy : IProjectReaderProxy, IJavaObjectProxy<org.mpxj.reader.UniversalProjectReader.ProjectReaderProxy>
        {
            private readonly ProjectListenerAdapter _listenerAdapter;
            private readonly ReaderProxyManager _proxyManager = new ReaderProxyManager();

            public org.mpxj.reader.UniversalProjectReader.ProjectReaderProxy JavaObject { get; }

            internal ProjectReaderProxy(ProjectListenerAdapter listenerAdapter, org.mpxj.reader.UniversalProjectReader.ProjectReaderProxy javaObject)
            {
                _listenerAdapter = listenerAdapter;
                JavaObject = javaObject;
            }

            IProjectReader IProjectReaderProxy.ProjectReader => (IProjectReader)_proxyManager.GenericProxyObject(JavaObject.getProjectReader());

            void IDisposable.Dispose()
            {
                JavaObject.Dispose();
            }

            ProjectFile IProjectReaderProxy.Read()
            {
                var proxyManager = new ProxyManager();
                if (_listenerAdapter != null)
                {
                    _listenerAdapter.ProxyManager = proxyManager;
                }
                return new ProjectFile(proxyManager, JavaObject.read());
            }

            IList<ProjectFile> IProjectReaderProxy.ReadAll()
            {
                var proxyManager = new ProxyManager();
                if (_listenerAdapter != null)
                {
                    _listenerAdapter.ProxyManager = proxyManager;
                }
                return JavaObject.readAll().toArray().Select(p => new ProjectFile(proxyManager, (org.mpxj.ProjectFile)p)).ToList();
            }
        }

        public UniversalProjectReader() : base(new org.mpxj.reader.UniversalProjectReader()) { }

        public new org.mpxj.reader.UniversalProjectReader JavaObject => (org.mpxj.reader.UniversalProjectReader)base.JavaObject;

        public IProjectReaderProxy GetProjectReaderProxy(string name)
        {
            return new ProjectReaderProxy(_listenerAdapter, JavaObject.getProjectReaderProxy(name));
        }

        public IProjectReaderProxy GetProjectReaderProxy(Stream stream)
        {
            return new ProjectReaderProxy(_listenerAdapter, JavaObject.getProjectReaderProxy(stream.ConvertType()));
        }
    }
}

