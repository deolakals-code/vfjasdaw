// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbEnchantScroll : UnityHashBase // TypeDefIndex: 11846
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbEquipItemData <OrbEquip>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[UnityHash(Code = 132)]
	public OrbEquipItemData OrbEquip { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3755F54 Offset: 0x3751F54 VA: 0x3755F54
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3755F5C Offset: 0x3751F5C VA: 0x3755F5C
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3755F64 Offset: 0x3751F64 VA: 0x3755F64
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3755F6C Offset: 0x3751F6C VA: 0x3755F6C
	public OrbEquipItemData get_OrbEquip() { }

	[CompilerGenerated]
	// RVA: 0x3755F74 Offset: 0x3751F74 VA: 0x3755F74
	public void set_OrbEquip(OrbEquipItemData value) { }

	// RVA: 0x3755F7C Offset: 0x3751F7C VA: 0x3755F7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3755F84 Offset: 0x3751F84 VA: 0x3755F84 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3756108 Offset: 0x3752108 VA: 0x3756108 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3756004 Offset: 0x3752004 VA: 0x3756004
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x37561A0 Offset: 0x37521A0 VA: 0x37561A0
	private void SetClass(Dictionary<object, object> parameters) { }
}
