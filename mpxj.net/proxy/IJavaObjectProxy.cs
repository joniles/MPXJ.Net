namespace MPXJ.Net.Proxy
{
	public interface IJavaObjectProxy<out M> : IHasJavaObject
	{
		M JavaObject { get; }
	}
}
