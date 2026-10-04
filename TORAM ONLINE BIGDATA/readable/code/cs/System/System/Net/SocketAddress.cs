// Assembly: System.dll
// Namespace: System.Net
[DefaultMember("Item")]
public class SocketAddress // TypeDefIndex: 14405
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x34DE5C4 Offset: 0x34DA5C4 VA: 0x34DE5C4
	public AddressFamily get_Family() { }

	// RVA: 0x34EEEA4 Offset: 0x34EAEA4 VA: 0x34EEEA4
	public int get_Size() { }

	// RVA: 0x34EEEAC Offset: 0x34EAEAC VA: 0x34EEEAC
	public byte get_Item(int offset) { }

	// RVA: 0x34EEF20 Offset: 0x34EAF20 VA: 0x34EEF20
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x34EF04C Offset: 0x34EB04C VA: 0x34EF04C
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x34DE384 Offset: 0x34DA384 VA: 0x34DE384
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x34EF2CC Offset: 0x34EB2CC VA: 0x34EF2CC
	internal IPAddress GetIPAddress() { }

	// RVA: 0x34DE5F4 Offset: 0x34DA5F4 VA: 0x34DE5F4
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x34EF4B8 Offset: 0x34EB4B8 VA: 0x34EF4B8 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x34EF5A4 Offset: 0x34EB5A4 VA: 0x34EF5A4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34EF6D4 Offset: 0x34EB6D4 VA: 0x34EF6D4 Slot: 3
	public override string ToString() { }
}
