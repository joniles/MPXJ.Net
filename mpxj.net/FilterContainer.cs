using org.mpxj.proxy;

namespace org.mpxj
{
    public class FilterContainer : IJavaObjectProxy<net.sf.mpxj.FilterContainer>
    {
        public net.sf.mpxj.FilterContainer JavaObject { get; }

        internal FilterContainer(net.sf.mpxj.FilterContainer javaObject)
        {
            JavaObject = javaObject;
        }

        public void AddFilter(net.sf.mpxj.Filter filter)
        {
            JavaObject.addFilter(filter);
        }

        public void RemoveFilter(string filterName)
        {
            JavaObject.removeFilter(filterName);
        }

        public java.util.List ResourceFilters
        {
            get => JavaObject.getResourceFilters();
        }

        public java.util.List TaskFilters
        {
            get => JavaObject.getResourceFilters();
        }

        public net.sf.mpxj.Filter GetFilterByName(string name)
        {
            return JavaObject.getFilterByName(name);
        }

        public net.sf.mpxj.Filter GetFilterByID(java.lang.Integer id)
        {
            return JavaObject.getFilterByID(id);
        }
    }
}
