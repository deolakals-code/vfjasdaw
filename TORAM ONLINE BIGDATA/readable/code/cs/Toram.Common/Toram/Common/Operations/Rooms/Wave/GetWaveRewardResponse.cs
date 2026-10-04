// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class GetWaveRewardResponse : OperationRequestBase // TypeDefIndex: 11794
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public RewardResponseDatav2 RewardData { get; set; }

	// Methods

	// RVA: 0x374CE60 Offset: 0x3748E60 VA: 0x374CE60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374CE68 Offset: 0x3748E68 VA: 0x374CE68 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374CE70 Offset: 0x3748E70 VA: 0x374CE70
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x374CE78 Offset: 0x3748E78 VA: 0x374CE78
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x374CE80 Offset: 0x3748E80 VA: 0x374CE80
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x374CE88 Offset: 0x3748E88 VA: 0x374CE88
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374CFA8 Offset: 0x3748FA8 VA: 0x374CFA8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374D024 Offset: 0x3749024 VA: 0x374D024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374D0BC Offset: 0x37490BC VA: 0x374D0BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
