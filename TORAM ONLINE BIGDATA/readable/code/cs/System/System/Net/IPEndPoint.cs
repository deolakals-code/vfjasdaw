// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint // TypeDefIndex: 14361
{
	// Fields
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x34DE158 Offset: 0x34DA158 VA: 0x34DE158 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x34DE174 Offset: 0x34DA174 VA: 0x34DE174
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x34DE244 Offset: 0x34DA244 VA: 0x34DE244
	public IPAddress get_Address() { }

	// RVA: 0x34DE24C Offset: 0x34DA24C VA: 0x34DE24C
	public int get_Port() { }

	// RVA: 0x34DE254 Offset: 0x34DA254 VA: 0x34DE254 Slot: 3
	public override string ToString() { }

	// RVA: 0x34DE320 Offset: 0x34DA320 VA: 0x34DE320 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x34DE3E0 Offset: 0x34DA3E0 VA: 0x34DE3E0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x34DE68C Offset: 0x34DA68C VA: 0x34DE68C Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x34DE740 Offset: 0x34DA740 VA: 0x34DE740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34DE770 Offset: 0x34DA770 VA: 0x34DE770
	private static void .cctor() { }
}
