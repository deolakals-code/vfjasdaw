// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSRecruitmentSearch : OperationRequestBase // TypeDefIndex: 12461
{
	// Fields
	[CompilerGenerated]
	private byte <JoinType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ConditionsType>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <StringSearchType>k__BackingField; // 0x22
	[CompilerGenerated]
	private string <SearchString>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Page>k__BackingField; // 0x30

	// Properties
	public byte JoinType { get; set; }
	public byte ConditionsType { get; set; }
	public byte StringSearchType { get; set; }
	public string SearchString { get; set; }
	public byte Page { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360BA84 Offset: 0x3607A84 VA: 0x360BA84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360BA8C Offset: 0x3607A8C VA: 0x360BA8C
	public byte get_JoinType() { }

	[CompilerGenerated]
	// RVA: 0x360BA94 Offset: 0x3607A94 VA: 0x360BA94
	public void set_JoinType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360BA9C Offset: 0x3607A9C VA: 0x360BA9C
	public byte get_ConditionsType() { }

	[CompilerGenerated]
	// RVA: 0x360BAA4 Offset: 0x3607AA4 VA: 0x360BAA4
	public void set_ConditionsType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360BAAC Offset: 0x3607AAC VA: 0x360BAAC
	public byte get_StringSearchType() { }

	[CompilerGenerated]
	// RVA: 0x360BAB4 Offset: 0x3607AB4 VA: 0x360BAB4
	public void set_StringSearchType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360BABC Offset: 0x3607ABC VA: 0x360BABC
	public string get_SearchString() { }

	[CompilerGenerated]
	// RVA: 0x360BAC4 Offset: 0x3607AC4 VA: 0x360BAC4
	public void set_SearchString(string value) { }

	[CompilerGenerated]
	// RVA: 0x360BACC Offset: 0x3607ACC VA: 0x360BACC
	public byte get_Page() { }

	[CompilerGenerated]
	// RVA: 0x360BAD4 Offset: 0x3607AD4 VA: 0x360BAD4
	public void set_Page(byte value) { }

	// RVA: 0x360BADC Offset: 0x3607ADC VA: 0x360BADC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360BAE4 Offset: 0x3607AE4 VA: 0x360BAE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360BAEC Offset: 0x3607AEC VA: 0x360BAEC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360BD90 Offset: 0x3607D90 VA: 0x360BD90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
