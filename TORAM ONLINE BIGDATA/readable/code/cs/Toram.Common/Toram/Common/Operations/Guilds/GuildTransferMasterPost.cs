// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildTransferMasterPost : OperationRequestBase // TypeDefIndex: 12406
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	public int TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36026E4 Offset: 0x35FE6E4 VA: 0x36026E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36026EC Offset: 0x35FE6EC VA: 0x36026EC
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x36026F4 Offset: 0x35FE6F4 VA: 0x36026F4
	public void set_TargetId(int value) { }

	// RVA: 0x36026FC Offset: 0x35FE6FC VA: 0x36026FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3602704 Offset: 0x35FE704 VA: 0x3602704 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360270C Offset: 0x35FE70C VA: 0x360270C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360282C Offset: 0x35FE82C VA: 0x360282C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
