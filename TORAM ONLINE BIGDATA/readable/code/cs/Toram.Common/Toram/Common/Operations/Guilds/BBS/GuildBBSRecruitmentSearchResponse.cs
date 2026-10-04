// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSRecruitmentSearchResponse : OperationResponseBase // TypeDefIndex: 12463
{
	// Fields
	[CompilerGenerated]
	private bool <IsCompress>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildBBSSendData[] <DataList>k__BackingField; // 0x28

	// Properties
	public bool IsCompress { get; set; }
	public GuildBBSSendData[] DataList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360BEFC Offset: 0x3607EFC VA: 0x360BEFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360BF04 Offset: 0x3607F04 VA: 0x360BF04
	public bool get_IsCompress() { }

	[CompilerGenerated]
	// RVA: 0x360BF0C Offset: 0x3607F0C VA: 0x360BF0C
	public void set_IsCompress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x360BF18 Offset: 0x3607F18 VA: 0x360BF18
	public GuildBBSSendData[] get_DataList() { }

	[CompilerGenerated]
	// RVA: 0x360BF20 Offset: 0x3607F20 VA: 0x360BF20
	public void set_DataList(GuildBBSSendData[] value) { }

	// RVA: 0x360BF28 Offset: 0x3607F28 VA: 0x360BF28
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360C0BC Offset: 0x36080BC VA: 0x360C0BC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360C20C Offset: 0x360820C VA: 0x360C20C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360C214 Offset: 0x3608214 VA: 0x360C214 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360C21C Offset: 0x360821C VA: 0x360C21C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360C250 Offset: 0x3608250 VA: 0x360C250 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
