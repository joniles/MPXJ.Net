namespace MPXJ.Net
{
	public interface IProjectEntityContainer<N>
	{
        N GetByUniqueID(int? id);
    }
}
