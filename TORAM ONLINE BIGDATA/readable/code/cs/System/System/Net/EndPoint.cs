// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public abstract class EndPoint // TypeDefIndex: 14388
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x34EDFC0 Offset: 0x34E9FC0 VA: 0x34EDFC0 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x34EE064 Offset: 0x34EA064 VA: 0x34EE064 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x34EE108 Offset: 0x34EA108 VA: 0x34EE108 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x34DE23C Offset: 0x34DA23C VA: 0x34DE23C
	protected void .ctor() { }
}
