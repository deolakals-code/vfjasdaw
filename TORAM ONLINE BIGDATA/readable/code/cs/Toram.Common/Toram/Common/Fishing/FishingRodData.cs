// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Fishing
public class FishingRodData : BinaryBase // TypeDefIndex: 11194
{
	// Fields
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Durability>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SuccessionFlag>k__BackingField; // 0x1B
	[CompilerGenerated]
	private byte[] <Properties>k__BackingField; // 0x20

	// Properties
	public byte Index { get; set; }
	public byte Durability { get; set; }
	public byte SuccessionFlag { get; set; }
	public byte[] Properties { get; set; }

	// Methods

	// RVA: 0x35D6158 Offset: 0x35D2158 VA: 0x35D6158
	public void .ctor() { }

	// RVA: 0x35D61BC Offset: 0x35D21BC VA: 0x35D61BC
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35D61C4 Offset: 0x35D21C4 VA: 0x35D61C4
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35D61CC Offset: 0x35D21CC VA: 0x35D61CC
	public void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D61D4 Offset: 0x35D21D4 VA: 0x35D61D4
	public byte get_Durability() { }

	[CompilerGenerated]
	// RVA: 0x35D61DC Offset: 0x35D21DC VA: 0x35D61DC
	public void set_Durability(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D61E4 Offset: 0x35D21E4 VA: 0x35D61E4
	public byte get_SuccessionFlag() { }

	[CompilerGenerated]
	// RVA: 0x35D61EC Offset: 0x35D21EC VA: 0x35D61EC
	public void set_SuccessionFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D61F4 Offset: 0x35D21F4 VA: 0x35D61F4
	public byte[] get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x35D61FC Offset: 0x35D21FC VA: 0x35D61FC
	public void set_Properties(byte[] value) { }

	// RVA: 0x35D6204 Offset: 0x35D2204 VA: 0x35D6204 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D6474 Offset: 0x35D2474 VA: 0x35D6474 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D64D0 Offset: 0x35D24D0 VA: 0x35D64D0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
