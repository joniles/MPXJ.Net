using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public class ParentNotes : Notes, IJavaObjectProxy<net.sf.mpxj.ParentNotes>
    {
        private readonly ProxyManager _proxyManager;

        public new net.sf.mpxj.ParentNotes JavaObject => (net.sf.mpxj.ParentNotes)base.JavaObject;

        internal ParentNotes(ProxyManager proxyManager, net.sf.mpxj.ParentNotes value) : base(value)
        { 
            _proxyManager = proxyManager;
        }

        public ParentNotes(ProjectFile file, IList<Notes> childNotes) : base(new net.sf.mpxj.ParentNotes(childNotes.ConvertType())) 
        {
            _proxyManager = file._proxyManager;
        }

        public IList<Notes> ChildNotes => _proxyManager.ProxyList<net.sf.mpxj.Notes, Notes>(m => _proxyManager.ProxyObject(m), _ => null, JavaObject.getChildNotes());
    }
}
