// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaPropertiesData : BinaryBase // TypeDefIndex: 11227
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private MobaFixedPropertiesData <FixedProperties>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public MobaFixedPropertiesData FixedProperties { get; set; }

	// Methods

	// RVA: 0x36CB50C Offset: 0x36C750C VA: 0x36CB50C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36CB514 Offset: 0x36C7514 VA: 0x36CB514
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36CB51C Offset: 0x36C751C VA: 0x36CB51C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CB524 Offset: 0x36C7524 VA: 0x36CB524
	public MobaFixedPropertiesData get_FixedProperties() { }

	[CompilerGenerated]
	// RVA: 0x36CB52C Offset: 0x36C752C VA: 0x36CB52C
	public void set_FixedProperties(MobaFixedPropertiesData value) { }

	// RVA: 0x36CB534 Offset: 0x36C7534 VA: 0x36CB534 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CB59C Offset: 0x36C759C VA: 0x36CB59C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CB720 Offset: 0x36C7720 VA: 0x36CB720
	public static MobaPropertiesData[] CreateMemberFixedProperties(byte[] compressBinary) { }
}
