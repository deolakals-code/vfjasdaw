// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaMemberStatusData : BinaryBase // TypeDefIndex: 11221
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <HpRate>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public byte HpRate { get; set; }

	// Methods

	// RVA: 0x35DD1DC Offset: 0x35D91DC VA: 0x35DD1DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DD1E4 Offset: 0x35D91E4 VA: 0x35DD1E4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x35DD1EC Offset: 0x35D91EC VA: 0x35DD1EC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DD1F4 Offset: 0x35D91F4 VA: 0x35DD1F4
	public byte get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x35DD1FC Offset: 0x35D91FC VA: 0x35DD1FC
	public void set_HpRate(byte value) { }

	// RVA: 0x35DD204 Offset: 0x35D9204 VA: 0x35DD204 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DD240 Offset: 0x35D9240 VA: 0x35DD240 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
