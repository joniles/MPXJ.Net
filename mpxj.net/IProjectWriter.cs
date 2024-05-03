﻿using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public interface IProjectWriter<M> : IJavaObjectProxy<M> where M : net.sf.mpxj.writer.ProjectWriter
    {
        void Write(ProjectFile projectFile, string fileName);

        void Write(ProjectFile projectFile, Stream outputStream);
    }
}
