// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSAllowRequest : OperationRequestBase // TypeDefIndex: 12444
{
	// Fields
	public int TargetId; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36093CC Offset: 0x36053CC VA: 0x36093CC
	public void .ctor() { }

	// RVA: 0x36093D4 Offset: 0x36053D4 VA: 0x36093D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36093DC Offset: 0x36053DC VA: 0x36093DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36093E4 Offset: 0x36053E4 VA: 0x36093E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3609504 Offset: 0x3605504 VA: 0x3609504 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
