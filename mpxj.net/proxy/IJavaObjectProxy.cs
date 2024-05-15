namespace MPXJ.Net.Proxy
{
	public interface IJavaObjectProxy<M> : IHasJavaObject
	{
		M JavaObject { get; }
	}
}
