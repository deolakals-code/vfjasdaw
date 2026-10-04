// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicEgelBuf : CountBufferBase // TypeDefIndex: 3236
{
	// Fields
	[CompilerGenerated]
	private bool <EnableCounter>k__BackingField; // 0x28
	private PlayerActionManagerBase playerAction; // 0x30
	private PlayerBattleManager battleManager; // 0x38
	private float counterInterval; // 0x40
	private Dictionary<int, MagicEgelBuf.TargetData> active; // 0x48

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool EnableCounter { get; set; }

	// Methods

	// RVA: 0x233A620 Offset: 0x2336620 VA: 0x233A620 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233A628 Offset: 0x2336628 VA: 0x233A628 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233A630 Offset: 0x2336630 VA: 0x233A630 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x233A638 Offset: 0x2336638 VA: 0x233A638
	public bool get_EnableCounter() { }

	[CompilerGenerated]
	// RVA: 0x233A640 Offset: 0x2336640 VA: 0x233A640
	private void set_EnableCounter(bool value) { }

	// RVA: 0x233A64C Offset: 0x233664C VA: 0x233A64C
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x233A7D8 Offset: 0x23367D8 VA: 0x233A7D8 Slot: 11
	public override void Updata() { }

	// RVA: 0x233A818 Offset: 0x2336818 VA: 0x233A818
	public void Active(SkillIdData skillIdData, GameObject target) { }

	// RVA: 0x233AABC Offset: 0x2336ABC VA: 0x233AABC
	public bool IsActive(SkillIdData skillIdData) { }

	// RVA: 0x233AB94 Offset: 0x2336B94 VA: 0x233AB94
	public void Reset(SkillId skillId) { }

	// RVA: 0x233ABEC Offset: 0x2336BEC VA: 0x233ABEC
	internal void Damaged(GameObject enemy) { }
}
