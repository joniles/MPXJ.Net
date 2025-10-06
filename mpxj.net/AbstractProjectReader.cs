using MPXJ.Net.Proxy;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MPXJ.Net
{
    public abstract class AbstractProjectReader : IProjectReader
    {
        private readonly List<IProjectListener> _listeners = new List<IProjectListener>();
        internal ProjectListenerAdapter _listenerAdapter;
        
        protected delegate org.mpxj.ProjectFile ReadDelegate();

        protected delegate java.util.List ReadAllDelegate();
        
        protected org.mpxj.reader.AbstractProjectReader JavaObject { get; }

        protected AbstractProjectReader(org.mpxj.reader.AbstractProjectReader javaObject)
        {
            JavaObject = javaObject;
        }

        public void AddProjectListener(IProjectListener listener)
        {
            if (_listeners.Count == 0)
            {
                _listenerAdapter = new ProjectListenerAdapter(_listeners);
                JavaObject.addProjectListener(_listenerAdapter);
            }
            _listeners.Add(listener);    
        }
        
        public ProjectFile Read(string name) => Read(() => JavaObject.read(name));

        public ProjectFile Read(Stream stream) => Read(() => JavaObject.read(stream.ConvertType()));

        public IList<ProjectFile> ReadAll(string name) => ReadAll(() => JavaObject.readAll(name));

        public IList<ProjectFile> ReadAll(Stream stream) => ReadAll(() => JavaObject.readAll(stream.ConvertType()));

        protected ProjectFile Read(ReadDelegate d)
        {
            var proxyManager = new ProxyManager();
            if (_listenerAdapter != null)
            {
                _listenerAdapter.ProxyManager = proxyManager;
            }
            var file = d.Invoke();
            return file == null ? null : new ProjectFile(proxyManager, file);
        }

        protected IList<ProjectFile> ReadAll(ReadAllDelegate d)
        {
            var proxyManager = new ProxyManager();
            if (_listenerAdapter != null)
            {
                _listenerAdapter.ProxyManager = proxyManager;
            }
            var projects = d.Invoke();
            return projects.toArray().Select(file => new ProjectFile(proxyManager, (org.mpxj.ProjectFile)file)).ToList();
        }
    }
}
