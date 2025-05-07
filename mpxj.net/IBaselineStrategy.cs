using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public interface IBaselineStrategy : IJavaObjectProxy<org.mpxj.BaselineStrategy>
	{
        void ClearBaseline(ProjectFile project, int index);

        void PopulateBaseline(ProjectFile project, ProjectFile baseline, int index);
    }
}
