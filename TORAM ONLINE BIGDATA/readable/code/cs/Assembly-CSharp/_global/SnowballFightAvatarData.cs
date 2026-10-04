// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballFightAvatarData // TypeDefIndex: 4494
{
	// Fields
	private const float DefaultBuffTime = 30;
	private readonly string[] partsName; // 0x10
	private float loopTimer; // 0x18
	private TakeController controller; // 0x20
	private SnowballFightItemData item; // 0x28
	private SnowballFightAvatarData.ActionState actionState; // 0x30
	private int auraTakeUid; // 0x34
	private SnowballFightBarrier barrier; // 0x38
	private GameObject safeBarrier; // 0x40
	private Motion safeBarrierMotion; // 0x48
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x54
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x58

	// Properties
	public int ArchetypeId { get; set; }
	public TakeController Controller { get; }
	public bool IsAction { get; }
	public bool IsThrow { get; set; }
	public bool IsReloadStart { get; set; }
	public bool IsReload { get; set; }
	public bool IsReloadUp { get; set; }
	public bool IsDodge { get; set; }
	public bool IsDamage { get; set; }
	public bool IsDead { get; set; }
	public bool IsResurrection { get; set; }
	public bool IsDamageInvalidation { get; }
	public bool IsMine { get; set; }
	public string Name { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2504CB0 Offset: 0x2500CB0 VA: 0x2504CB0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x2504CB8 Offset: 0x2500CB8 VA: 0x2504CB8
	private void set_ArchetypeId(int value) { }

	// RVA: 0x2504CC0 Offset: 0x2500CC0 VA: 0x2504CC0
	public TakeController get_Controller() { }

	// RVA: 0x2504CC8 Offset: 0x2500CC8 VA: 0x2504CC8
	public bool get_IsAction() { }

	// RVA: 0x2504CD8 Offset: 0x2500CD8 VA: 0x2504CD8
	public bool get_IsThrow() { }

	// RVA: 0x2504CE4 Offset: 0x2500CE4 VA: 0x2504CE4
	public void set_IsThrow(bool value) { }

	// RVA: 0x2504D10 Offset: 0x2500D10 VA: 0x2504D10
	public bool get_IsReloadStart() { }

	// RVA: 0x2504D1C Offset: 0x2500D1C VA: 0x2504D1C
	public void set_IsReloadStart(bool value) { }

	// RVA: 0x2504D3C Offset: 0x2500D3C VA: 0x2504D3C
	public bool get_IsReload() { }

	// RVA: 0x2504D48 Offset: 0x2500D48 VA: 0x2504D48
	public void set_IsReload(bool value) { }

	// RVA: 0x2504D68 Offset: 0x2500D68 VA: 0x2504D68
	public bool get_IsReloadUp() { }

	// RVA: 0x2504D74 Offset: 0x2500D74 VA: 0x2504D74
	public void set_IsReloadUp(bool value) { }

	// RVA: 0x2504D94 Offset: 0x2500D94 VA: 0x2504D94
	public bool get_IsDodge() { }

	// RVA: 0x2504DA0 Offset: 0x2500DA0 VA: 0x2504DA0
	public void set_IsDodge(bool value) { }

	// RVA: 0x2504DC0 Offset: 0x2500DC0 VA: 0x2504DC0
	public bool get_IsDamage() { }

	// RVA: 0x2504DCC Offset: 0x2500DCC VA: 0x2504DCC
	public void set_IsDamage(bool value) { }

	// RVA: 0x2504DEC Offset: 0x2500DEC VA: 0x2504DEC
	public bool get_IsDead() { }

	// RVA: 0x2504DF8 Offset: 0x2500DF8 VA: 0x2504DF8
	public void set_IsDead(bool value) { }

	// RVA: 0x2504E18 Offset: 0x2500E18 VA: 0x2504E18
	public bool get_IsResurrection() { }

	// RVA: 0x2504E24 Offset: 0x2500E24 VA: 0x2504E24
	public void set_IsResurrection(bool value) { }

	// RVA: 0x2504E44 Offset: 0x2500E44 VA: 0x2504E44
	public bool get_IsDamageInvalidation() { }

	[CompilerGenerated]
	// RVA: 0x2504E54 Offset: 0x2500E54 VA: 0x2504E54
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x2504E5C Offset: 0x2500E5C VA: 0x2504E5C
	private void set_IsMine(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2504E68 Offset: 0x2500E68 VA: 0x2504E68
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x2504E70 Offset: 0x2500E70 VA: 0x2504E70
	private void set_Name(string value) { }

	// RVA: 0x2504E78 Offset: 0x2500E78 VA: 0x2504E78
	public void .ctor(int uuid, bool isMine, string name) { }

	// RVA: 0x2504FC0 Offset: 0x2500FC0 VA: 0x2504FC0
	public void SetLoopTimer(float timer) { }

	// RVA: 0x2504FC8 Offset: 0x2500FC8 VA: 0x2504FC8
	public bool Loop() { }

	// RVA: 0x2505014 Offset: 0x2501014 VA: 0x2505014
	public void SetTakeController(TakeController controller) { }

	// RVA: 0x250501C Offset: 0x250101C VA: 0x250501C
	public void PlayAura() { }

	// RVA: 0x250504C Offset: 0x250104C VA: 0x250504C
	public void PlayAura(int color) { }

	// RVA: 0x25051D0 Offset: 0x25011D0 VA: 0x25051D0
	public void RemoveAura() { }

	// RVA: 0x2505208 Offset: 0x2501208 VA: 0x2505208
	public void PlayBarrier() { }

	// RVA: 0x25054A8 Offset: 0x25014A8 VA: 0x25054A8
	public void PlaySafeBarrier() { }

	// RVA: 0x2505814 Offset: 0x2501814 VA: 0x2505814
	public bool CheckSafeBarrierPlay() { }

	// RVA: 0x2505910 Offset: 0x2501910 VA: 0x2505910
	public void RemoveBarrier() { }

	// RVA: 0x25059E0 Offset: 0x25019E0 VA: 0x25059E0
	public bool DamageBarrier() { }

	// RVA: 0x2505A5C Offset: 0x2501A5C VA: 0x2505A5C
	public void RemoveEffect() { }

	// RVA: 0x2505A74 Offset: 0x2501A74 VA: 0x2505A74
	public bool ItemUpdate() { }

	// RVA: 0x2505B34 Offset: 0x2501B34 VA: 0x2505B34
	public void AddItem(SnowballFightItemData item, float bufTime) { }

	// RVA: 0x2505B84 Offset: 0x2501B84 VA: 0x2505B84
	public void RemoveItem() { }

	// RVA: 0x2505B90 Offset: 0x2501B90 VA: 0x2505B90
	public byte GetItemType() { }

	// RVA: 0x2505BA8 Offset: 0x2501BA8 VA: 0x2505BA8
	public bool CheckValidItem(byte type) { }

	// RVA: 0x2505BD4 Offset: 0x2501BD4 VA: 0x2505BD4
	public bool CheckValidItem(SnowballFightItemType type) { }

	// RVA: 0x2505C00 Offset: 0x2501C00 VA: 0x2505C00
	public void InvalidItem(byte type) { }

	// RVA: 0x2505C24 Offset: 0x2501C24 VA: 0x2505C24
	public Vector3 GetThrowPos() { }

	// RVA: 0x2505DC8 Offset: 0x2501DC8 VA: 0x2505DC8
	public void ClearActionState() { }

	// RVA: 0x2505DD0 Offset: 0x2501DD0 VA: 0x2505DD0
	public void Dead() { }

	// RVA: 0x2505DF8 Offset: 0x2501DF8 VA: 0x2505DF8
	public void Resurrection() { }

	// RVA: 0x2504CF4 Offset: 0x2500CF4 VA: 0x2504CF4
	private void SetActionState(SnowballFightAvatarData.ActionState state, bool valid) { }
}
