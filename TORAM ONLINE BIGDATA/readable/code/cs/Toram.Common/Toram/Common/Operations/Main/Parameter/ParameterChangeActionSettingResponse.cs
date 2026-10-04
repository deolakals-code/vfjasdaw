// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterChangeActionSettingResponse : OperationResponseBase // TypeDefIndex: 11981
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x28

	// Properties
	public int ArchetypeId { get; set; }
	public byte ArchetypeType { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37717E4 Offset: 0x376D7E4 VA: 0x37717E4
	public void .ctor() { }

	// RVA: 0x37717EC Offset: 0x376D7EC VA: 0x37717EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37717F4 Offset: 0x376D7F4 VA: 0x37717F4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x37717FC Offset: 0x376D7FC VA: 0x37717FC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3771804 Offset: 0x376D804 VA: 0x3771804
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x377180C Offset: 0x376D80C VA: 0x377180C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3771814 Offset: 0x376D814 VA: 0x3771814
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x377181C Offset: 0x376D81C VA: 0x377181C
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x3771824 Offset: 0x376D824 VA: 0x3771824 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377182C Offset: 0x376D82C VA: 0x377182C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3771834 Offset: 0x376D834 VA: 0x3771834 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3771928 Offset: 0x376D928 VA: 0x3771928 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
