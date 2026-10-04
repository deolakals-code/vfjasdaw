// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbRecyclingResponse : OperationResponseBase // TypeDefIndex: 11815
{
	// Fields
	[CompilerGenerated]
	private OrbEquipItemData <OrbEquip>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public OrbEquipItemData OrbEquip { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37507AC Offset: 0x374C7AC VA: 0x37507AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37507B4 Offset: 0x374C7B4 VA: 0x37507B4
	public OrbEquipItemData get_OrbEquip() { }

	[CompilerGenerated]
	// RVA: 0x37507BC Offset: 0x374C7BC VA: 0x37507BC
	public void set_OrbEquip(OrbEquipItemData value) { }

	[CompilerGenerated]
	// RVA: 0x37507C4 Offset: 0x374C7C4 VA: 0x37507C4
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x37507CC Offset: 0x374C7CC VA: 0x37507CC
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x37507D4 Offset: 0x374C7D4 VA: 0x37507D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37507DC Offset: 0x374C7DC VA: 0x37507DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37507E4 Offset: 0x374C7E4 VA: 0x37507E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3750A48 Offset: 0x374CA48 VA: 0x3750A48 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
