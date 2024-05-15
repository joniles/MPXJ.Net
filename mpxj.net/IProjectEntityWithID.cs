namespace MPXJ.Net
{
	public interface IProjectEntityWithID : IProjectEntityWithUniqueID
	{
        int? ID { get; set; }
	}
}
