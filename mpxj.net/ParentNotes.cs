using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public class ParentNotes : Notes, IJavaObjectProxy<org.mpxj.ParentNotes>
    {
        private readonly ProxyManager _proxyManager;

        public new org.mpxj.ParentNotes JavaObject => (org.mpxj.ParentNotes)base.JavaObject;

        internal ParentNotes(ProxyManager proxyManager, org.mpxj.ParentNotes value) : base(value)
        { 
            _proxyManager = proxyManager;
        }

        public ParentNotes(ProjectFile file, IList<Notes> childNotes) : base(new org.mpxj.ParentNotes(childNotes.ConvertType())) 
        {
            _proxyManager = file._proxyManager;
        }

        public IList<Notes> ChildNotes => _proxyManager.ProxyList<org.mpxj.Notes, Notes>(m => _proxyManager.ProxyObject(m), _ => null, JavaObject.getChildNotes());
    }
}
