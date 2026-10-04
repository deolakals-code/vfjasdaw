// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class IPAddress // TypeDefIndex: 14359
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly ushort[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Properties
	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x34DC498 Offset: 0x34D8498 VA: 0x34DC498
	private bool get_IsIPv4() { }

	// RVA: 0x34DC4A8 Offset: 0x34D84A8 VA: 0x34DC4A8
	private bool get_IsIPv6() { }

	// RVA: 0x34DC4B8 Offset: 0x34D84B8 VA: 0x34DC4B8
	private uint get_PrivateAddress() { }

	// RVA: 0x34DC4C0 Offset: 0x34D84C0 VA: 0x34DC4C0
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x34DC4F4 Offset: 0x34D84F4 VA: 0x34DC4F4
	private uint get_PrivateScopeId() { }

	// RVA: 0x34DC4FC Offset: 0x34D84FC VA: 0x34DC4FC
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x34DC530 Offset: 0x34D8530 VA: 0x34DC530
	public void .ctor(long newAddress) { }

	// RVA: 0x34DC5BC Offset: 0x34D85BC VA: 0x34DC5BC
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x34DC684 Offset: 0x34D8684 VA: 0x34DC684
	public void .ctor(ReadOnlySpan<byte> address, long scopeid) { }

	// RVA: 0x34DC820 Offset: 0x34D8820 VA: 0x34DC820
	internal void .ctor(ushort* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x34DC8F4 Offset: 0x34D88F4 VA: 0x34DC8F4
	private void .ctor(ushort[] numbers, uint scopeid) { }

	// RVA: 0x34DC944 Offset: 0x34D8944 VA: 0x34DC944
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x34DCB94 Offset: 0x34D8B94 VA: 0x34DCB94
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x34DCC2C Offset: 0x34D8C2C VA: 0x34DCC2C
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x34DCD38 Offset: 0x34D8D38 VA: 0x34DCD38
	private void WriteIPv6Bytes(Span<byte> destination) { }

	// RVA: 0x34DCDC4 Offset: 0x34D8DC4 VA: 0x34DCDC4
	private void WriteIPv4Bytes(Span<byte> destination) { }

	// RVA: 0x34DCE10 Offset: 0x34D8E10 VA: 0x34DCE10
	public byte[] GetAddressBytes() { }

	// RVA: 0x34DCF58 Offset: 0x34D8F58 VA: 0x34DCF58
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x34DCF70 Offset: 0x34D8F70 VA: 0x34DCF70
	public long get_ScopeId() { }

	// RVA: 0x34DCFC0 Offset: 0x34D8FC0 VA: 0x34DCFC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34DD0E4 Offset: 0x34D90E4 VA: 0x34DD0E4
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x34DD1AC Offset: 0x34D91AC VA: 0x34DD1AC
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x34DD2E0 Offset: 0x34D92E0 VA: 0x34DD2E0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x34DD2E8 Offset: 0x34D92E8 VA: 0x34DD2E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34DD6D8 Offset: 0x34D96D8 VA: 0x34DD6D8
	public IPAddress MapToIPv6() { }

	// RVA: 0x34DC638 Offset: 0x34D8638 VA: 0x34DC638
	private static byte[] ThrowAddressNullException() { }

	// RVA: 0x34DD7B4 Offset: 0x34D97B4 VA: 0x34DD7B4
	private static void .cctor() { }
}
