// Assembly: mscorlib.dll
// Namespace: 
private struct Decimal.DecCalc.Buf24 // TypeDefIndex: 9849
{
	// Fields
	public uint U0; // 0x0
	public uint U1; // 0x4
	public uint U2; // 0x8
	public uint U3; // 0xC
	public uint U4; // 0x10
	public uint U5; // 0x14
	private ulong ulo64LE; // 0x0
	private ulong umid64LE; // 0x8
	private ulong uhigh64LE; // 0x10

	// Properties
	public ulong Low64 { get; set; }
	public ulong Mid64 { set; }
	public ulong High64 { set; }

	// Methods

	// RVA: 0x3046CC8 Offset: 0x3042CC8 VA: 0x3046CC8
	public ulong get_Low64() { }

	// RVA: 0x3046CB8 Offset: 0x3042CB8 VA: 0x3046CB8
	public void set_Low64(ulong value) { }

	// RVA: 0x3046CC0 Offset: 0x3042CC0 VA: 0x3046CC0
	public void set_Mid64(ulong value) { }

	// RVA: 0x3046E90 Offset: 0x3042E90 VA: 0x3046E90
	public void set_High64(ulong value) { }
}
