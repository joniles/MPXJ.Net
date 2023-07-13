using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO implement baseline strategy hierarchy
	public interface IBaselineStrategy : IJavaObjectProxy<net.sf.mpxj.BaselineStrategy>
	{
        void ClearBaseline(ProjectFile project, int index);

        void PopulateBaseline(ProjectFile project, ProjectFile baseline, int index);
    }
}
