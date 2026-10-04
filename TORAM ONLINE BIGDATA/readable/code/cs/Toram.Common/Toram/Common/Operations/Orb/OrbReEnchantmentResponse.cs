// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbReEnchantmentResponse : OperationResponseBase // TypeDefIndex: 11803
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbEquipItemData <OrbEquipItemData>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; }
	[PacketClass(Code = 71)]
	public OrbEquipItemData OrbEquipItemData { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x374E9AC Offset: 0x374A9AC VA: 0x374E9AC
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x374E9B4 Offset: 0x374A9B4 VA: 0x374E9B4
	public OrbEquipItemData get_OrbEquipItemData() { }

	// RVA: 0x374E9BC Offset: 0x374A9BC VA: 0x374E9BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374E9C4 Offset: 0x374A9C4 VA: 0x374E9C4 Slot: 7
	public override byte get_SubCode() { }
}
