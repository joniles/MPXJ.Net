namespace org.mpxj
{
	public interface IProjectEntityWithID : IProjectEntityWithUniqueID
	{
        int? ID { get; set; }
	}
}
