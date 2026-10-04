// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcSettingData : BinaryBase // TypeDefIndex: 11158
{
	// Fields
	[CompilerGenerated]
	private int <SpecialFlag>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Persona>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Avoid>k__BackingField; // 0x24

	// Properties
	[BinaryParameter]
	public int SpecialFlag { get; set; }
	[BinaryParameter]
	public byte Persona { get; set; }
	[BinaryParameter]
	public int Avoid { get; set; }

	// Methods

	// RVA: 0x35CA998 Offset: 0x35C6998 VA: 0x35CA998
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35CBD10 Offset: 0x35C7D10 VA: 0x35CBD10
	public int get_SpecialFlag() { }

	[CompilerGenerated]
	// RVA: 0x35CBD18 Offset: 0x35C7D18 VA: 0x35CBD18
	protected void set_SpecialFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CBD20 Offset: 0x35C7D20 VA: 0x35CBD20
	public byte get_Persona() { }

	[CompilerGenerated]
	// RVA: 0x35CBD28 Offset: 0x35C7D28 VA: 0x35CBD28
	protected void set_Persona(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CBD30 Offset: 0x35C7D30 VA: 0x35CBD30
	public int get_Avoid() { }

	[CompilerGenerated]
	// RVA: 0x35CBD38 Offset: 0x35C7D38 VA: 0x35CBD38
	protected void set_Avoid(int value) { }

	// RVA: 0x35CBD40 Offset: 0x35C7D40 VA: 0x35CBD40 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CBE60 Offset: 0x35C7E60 VA: 0x35CBE60 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
