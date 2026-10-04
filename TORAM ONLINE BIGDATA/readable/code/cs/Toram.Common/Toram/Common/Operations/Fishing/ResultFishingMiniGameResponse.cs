// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ResultFishingMiniGameResponse : OperationResponseBase // TypeDefIndex: 11658
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 2)]
	public RewardResponseDatav2 RewardData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372C9A8 Offset: 0x37289A8 VA: 0x372C9A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372C9B0 Offset: 0x37289B0 VA: 0x372C9B0
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x372C9B8 Offset: 0x37289B8 VA: 0x372C9B8
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x372C9C0 Offset: 0x37289C0 VA: 0x372C9C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372C9C8 Offset: 0x37289C8 VA: 0x372C9C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372C9D0 Offset: 0x37289D0 VA: 0x372C9D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372CA58 Offset: 0x3728A58 VA: 0x372CA58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
