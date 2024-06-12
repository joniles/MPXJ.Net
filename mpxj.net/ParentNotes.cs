using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public class ParentNotes : Notes, IJavaObjectProxy<net.sf.mpxj.ParentNotes>
    {
        internal readonly ProxyManager _proxyManager;

        public new net.sf.mpxj.ParentNotes JavaObject => (net.sf.mpxj.ParentNotes)base.JavaObject;

        internal ParentNotes(net.sf.mpxj.ParentNotes value) : base(value) { }

        public ParentNotes(IList<Notes> childNotes) : base(new net.sf.mpxj.ParentNotes(childNotes.ConvertType())) { }

        public IList<Notes> ChildNotes => _proxyManager.ProxyList<net.sf.mpxj.Notes, Notes>(m => _proxyManager.ProxyObject(m), n => null, JavaObject.getChildNotes());
    }
}
