// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCandidacyMasterPost : OperationRequestBase // TypeDefIndex: 12379
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	public int TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FE208 Offset: 0x35FA208 VA: 0x35FE208
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FE210 Offset: 0x35FA210 VA: 0x35FE210
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x35FE218 Offset: 0x35FA218 VA: 0x35FE218
	public void set_TargetId(int value) { }

	// RVA: 0x35FE220 Offset: 0x35FA220 VA: 0x35FE220 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FE228 Offset: 0x35FA228 VA: 0x35FE228 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FE230 Offset: 0x35FA230 VA: 0x35FE230 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FE350 Offset: 0x35FA350 VA: 0x35FE350 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
