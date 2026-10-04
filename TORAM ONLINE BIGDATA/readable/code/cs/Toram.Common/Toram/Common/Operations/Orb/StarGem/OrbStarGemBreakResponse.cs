// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemBreakResponse : OperationResponseBase // TypeDefIndex: 11830
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x20
	[CompilerGenerated]
	private StarGemData <StarGem>k__BackingField; // 0x28

	// Properties
	public RewardResponseDatav2 Reward { get; set; }
	public StarGemData StarGem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3752C3C Offset: 0x374EC3C VA: 0x3752C3C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3752C44 Offset: 0x374EC44 VA: 0x3752C44
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3752C4C Offset: 0x374EC4C VA: 0x3752C4C
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3752C54 Offset: 0x374EC54 VA: 0x3752C54
	public StarGemData get_StarGem() { }

	[CompilerGenerated]
	// RVA: 0x3752C5C Offset: 0x374EC5C VA: 0x3752C5C
	public void set_StarGem(StarGemData value) { }

	// RVA: 0x3752C64 Offset: 0x374EC64 VA: 0x3752C64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3752C6C Offset: 0x374EC6C VA: 0x3752C6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3752C74 Offset: 0x374EC74 VA: 0x3752C74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3752ED0 Offset: 0x374EED0 VA: 0x3752ED0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
