namespace MPXJ.Net
{
	public interface IProjectEntityContainer<out N>
	{
        N GetByUniqueID(int? id);
    }
}
