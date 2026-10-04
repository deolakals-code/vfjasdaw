// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RushAidBuf : SkillBufferDataBase // TypeDefIndex: 3290
{
	// Fields
	private BattleManagerBase battleManager; // 0x20
	private CharacterMove charaMove; // 0x28
	private int resistCount; // 0x30
	private Action endAction; // 0x38
	private GameObject target; // 0x40
	private float timer; // 0x48
	private const float stackTime = 1;

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x234334C Offset: 0x233F34C VA: 0x234334C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2343354 Offset: 0x233F354 VA: 0x2343354 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x234337C Offset: 0x233F37C VA: 0x234337C
	public void .ctor(byte lv, BattleManagerBase battleManager, CharacterMove move, Action callBack, GameObject target) { }

	// RVA: 0x2343430 Offset: 0x233F430 VA: 0x2343430 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x234345C Offset: 0x233F45C VA: 0x234345C Slot: 11
	public override void Updata() { }

	// RVA: 0x23437E4 Offset: 0x233F7E4 VA: 0x23437E4 Slot: 13
	public override void OnDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2343794 Offset: 0x233F794 VA: 0x2343794
	private void EndFunction() { }
}
