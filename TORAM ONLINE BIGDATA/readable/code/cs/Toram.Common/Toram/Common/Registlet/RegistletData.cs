// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Registlet
public class RegistletData : BinaryBase // TypeDefIndex: 11102
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <GemPowder>k__BackingField; // 0x1C

	// Properties
	public byte Flag { get; set; }
	public byte Slot { get; set; }
	public int GemPowder { get; set; }

	// Methods

	// RVA: 0x35B9F8C Offset: 0x35B5F8C VA: 0x35B9F8C
	public void .ctor() { }

	// RVA: 0x35B9F94 Offset: 0x35B5F94 VA: 0x35B9F94
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B9F9C Offset: 0x35B5F9C VA: 0x35B9F9C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35B9FA4 Offset: 0x35B5FA4 VA: 0x35B9FA4
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B9FAC Offset: 0x35B5FAC VA: 0x35B9FAC
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x35B9FB4 Offset: 0x35B5FB4 VA: 0x35B9FB4
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B9FBC Offset: 0x35B5FBC VA: 0x35B9FBC
	public int get_GemPowder() { }

	[CompilerGenerated]
	// RVA: 0x35B9FC4 Offset: 0x35B5FC4 VA: 0x35B9FC4
	public void set_GemPowder(int value) { }

	// RVA: 0x35B9FCC Offset: 0x35B5FCC VA: 0x35B9FCC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35BA018 Offset: 0x35B6018 VA: 0x35BA018 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
