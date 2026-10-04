// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongChangeMemberSettingResponse : OperationResponseBase // TypeDefIndex: 12344
{
	// Fields
	[CompilerGenerated]
	private MahjongMemberData <MemberData>k__BackingField; // 0x20

	// Properties
	public MahjongMemberData MemberData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F7ED8 Offset: 0x35F3ED8 VA: 0x35F7ED8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F7EE0 Offset: 0x35F3EE0 VA: 0x35F7EE0
	public MahjongMemberData get_MemberData() { }

	[CompilerGenerated]
	// RVA: 0x35F7EE8 Offset: 0x35F3EE8 VA: 0x35F7EE8
	public void set_MemberData(MahjongMemberData value) { }

	// RVA: 0x35F7EF0 Offset: 0x35F3EF0 VA: 0x35F7EF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F7EF8 Offset: 0x35F3EF8 VA: 0x35F7EF8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F7F00 Offset: 0x35F3F00 VA: 0x35F7F00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F7F88 Offset: 0x35F3F88 VA: 0x35F7F88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
