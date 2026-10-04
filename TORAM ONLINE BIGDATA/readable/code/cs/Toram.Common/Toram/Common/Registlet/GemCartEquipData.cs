// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Registlet
public class GemCartEquipData : BinaryBase // TypeDefIndex: 11098
{
	// Fields
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20

	// Properties
	public byte EquipNo { get; set; }
	public long Uuid { get; set; }

	// Methods

	// RVA: 0x35B99BC Offset: 0x35B59BC VA: 0x35B99BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35B99C4 Offset: 0x35B59C4 VA: 0x35B99C4
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x35B99CC Offset: 0x35B59CC VA: 0x35B99CC
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B99D4 Offset: 0x35B59D4 VA: 0x35B99D4
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x35B99DC Offset: 0x35B59DC VA: 0x35B99DC
	public void set_Uuid(long value) { }

	// RVA: 0x35B99E4 Offset: 0x35B59E4 VA: 0x35B99E4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B9A20 Offset: 0x35B5A20 VA: 0x35B9A20 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
