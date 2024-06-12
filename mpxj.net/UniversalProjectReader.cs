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

        private class ProjectReaderProxy : IProjectReaderProxy, IJavaObjectProxy<net.sf.mpxj.reader.UniversalProjectReader.ProjectReaderProxy>
        {
            public net.sf.mpxj.reader.UniversalProjectReader.ProjectReaderProxy JavaObject { get; }

            internal ProjectReaderProxy(net.sf.mpxj.reader.UniversalProjectReader.ProjectReaderProxy javaObject)
            {
                JavaObject = javaObject;
            }

            IProjectReader IProjectReaderProxy.ProjectReader => throw new NotImplementedException();

            void IDisposable.Dispose()
            {
                JavaObject.Dispose();
            }

            ProjectFile IProjectReaderProxy.Read()
            {
                return new ProjectFile(JavaObject.read());
            }

            IList<ProjectFile> IProjectReaderProxy.ReadAll()
            {
                return JavaObject.readAll().toArray().Select(p => new ProjectFile((net.sf.mpxj.ProjectFile)p)).ToList();
            }
        }

        public UniversalProjectReader()
        {
            base.JavaObject = new net.sf.mpxj.reader.UniversalProjectReader();
        }

        public new net.sf.mpxj.reader.UniversalProjectReader JavaObject => (net.sf.mpxj.reader.UniversalProjectReader)base.JavaObject;

        public IProjectReaderProxy GetProjectReaderProxy(string name)
        {
            return new ProjectReaderProxy(JavaObject.getProjectReaderProxy(name));
        }

        public IProjectReaderProxy GetProjectReaderProxy(Stream stream)
        {
            return new ProjectReaderProxy(JavaObject.getProjectReaderProxy(new ProxyInputStream(stream)));
        }
    }
}

