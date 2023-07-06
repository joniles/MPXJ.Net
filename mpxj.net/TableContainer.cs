using org.mpxj.proxy;

namespace org.mpxj
{
    public class TableContainer : ShallowProxyList<net.sf.mpxj.Table>, IJavaObjectProxy<net.sf.mpxj.TableContainer>
    {
        public new net.sf.mpxj.TableContainer JavaObject { get => (net.sf.mpxj.TableContainer)base.JavaObject; }

        internal TableContainer(net.sf.mpxj.TableContainer javaObject) : base(javaObject) { }

        public net.sf.mpxj.Table GetTaskTableByName(string name)
        {
            return JavaObject.getTaskTableByName(name);
        }

        public net.sf.mpxj.Table GetResourceTableByName(string name)
        {
            return JavaObject.getResourceTableByName(name);
        }
    }
}
