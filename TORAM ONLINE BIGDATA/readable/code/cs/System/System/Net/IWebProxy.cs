// Assembly: System.dll
// Namespace: System.Net
public interface IWebProxy // TypeDefIndex: 14455
{
	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();
}
