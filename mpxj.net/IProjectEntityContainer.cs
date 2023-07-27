namespace org.mpxj
{
	public interface IProjectEntityContainer<N>
	{
        N GetByUniqueID(int id);
    }
}
