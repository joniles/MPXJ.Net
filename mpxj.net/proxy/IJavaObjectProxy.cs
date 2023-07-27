namespace org.mpxj.proxy
{
	public interface IJavaObjectProxy<M> : IHasJavaObject
	{
		M JavaObject { get; }
	}
}
