namespace org.mpxj
{
	public class ViewContainer : ShallowProxyList<net.sf.mpxj.View>, IJavaObjectProxy<net.sf.mpxj.ViewContainer>
	{
        public new net.sf.mpxj.ViewContainer JavaObject { get => (net.sf.mpxj.ViewContainer)base.JavaObject; }

        internal ViewContainer(net.sf.mpxj.ViewContainer javaObject) : base(javaObject) { }

        public net.sf.mpxj.ViewState ViewState
        {
            get => JavaObject.getViewState();
            set => JavaObject.setViewState(value);
        }
    }
}

