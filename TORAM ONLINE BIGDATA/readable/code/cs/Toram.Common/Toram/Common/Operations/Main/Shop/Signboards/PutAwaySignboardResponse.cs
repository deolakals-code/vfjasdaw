// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class PutAwaySignboardResponse : OperationResponseBase // TypeDefIndex: 11965
{
	// Fields
	[CompilerGenerated]
	private SignboardInfo <Info>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public SignboardInfo Info { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376EF04 Offset: 0x376AF04 VA: 0x376EF04
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376EF0C Offset: 0x376AF0C VA: 0x376EF0C
	public SignboardInfo get_Info() { }

	[CompilerGenerated]
	// RVA: 0x376EF14 Offset: 0x376AF14 VA: 0x376EF14
	public void set_Info(SignboardInfo value) { }

	[CompilerGenerated]
	// RVA: 0x376EF1C Offset: 0x376AF1C VA: 0x376EF1C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x376EF24 Offset: 0x376AF24 VA: 0x376EF24
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x376EF2C Offset: 0x376AF2C VA: 0x376EF2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376EF34 Offset: 0x376AF34 VA: 0x376EF34 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376EF3C Offset: 0x376AF3C VA: 0x376EF3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376F1A8 Offset: 0x376B1A8 VA: 0x376F1A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
