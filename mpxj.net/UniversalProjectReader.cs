﻿using System.Collections.Generic;
using System.IO;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement more reader classes as required
    public class UniversalProjectReader : IJavaObjectProxy<net.sf.mpxj.reader.UniversalProjectReader>
    {
        public net.sf.mpxj.reader.UniversalProjectReader JavaObject { get; } = new net.sf.mpxj.reader.UniversalProjectReader();

        public ProjectFile Read(string name) => Read(JavaObject.read(name));

        public ProjectFile Read(Stream stream) => Read(JavaObject.read(new ProxyInputStream(stream)));

        public List<ProjectFile> ReadAll(string name) => ReadAll(JavaObject.readAll(name));

        public List<ProjectFile> ReadAll(Stream stream) => ReadAll(JavaObject.readAll(new ProxyInputStream(stream)));

        private ProjectFile Read(net.sf.mpxj.ProjectFile file)
        {
            return file == null ? null : new ProjectFile(file);
        }

        private List<ProjectFile> ReadAll(java.util.List projects)
        {
            var list = new List<ProjectFile>();
            foreach (var file in projects.toArray())
            {
                list.Add(new ProjectFile((net.sf.mpxj.ProjectFile)file));
            }
            return list;
        }
    }
}
