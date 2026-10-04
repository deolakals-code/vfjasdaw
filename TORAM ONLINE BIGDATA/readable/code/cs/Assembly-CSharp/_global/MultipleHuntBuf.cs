// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MultipleHuntBuf : NextAttackBufferBase // TypeDefIndex: 3255
{
	// Fields
	private int skillMode; // 0x2C
	private CountBufferBase.CountType bufferType; // 0x30
	private SkillBufferFlag flag; // 0x34
	private int critical; // 0x38
	private int shortRangeRate; // 0x3C
	private int damageCut; // 0x40
	private int damageResist; // 0x44
	private int hpHealRate; // 0x48
	private bool isDamaged; // 0x4C
	private bool isSkillEnd; // 0x4D
	private PlayerActionManagerBase actionManager; // 0x50
	private TakeController takeController; // 0x58
	private int guardEffectId; // 0x60
	private Dictionary<PlayerAttackBase, int> healCheckList; // 0x68

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x233E5FC Offset: 0x233A5FC VA: 0x233E5FC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233E604 Offset: 0x233A604 VA: 0x233E604 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233E60C Offset: 0x233A60C VA: 0x233E60C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233E614 Offset: 0x233A614 VA: 0x233E614
	public void .ctor(byte lv, int mode) { }

	// RVA: 0x233E824 Offset: 0x233A824 VA: 0x233E824
	public void StartSkill() { }

	// RVA: 0x233E82C Offset: 0x233A82C VA: 0x233E82C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233E8A0 Offset: 0x233A8A0 VA: 0x233E8A0 Slot: 11
	public override void Updata() { }

	// RVA: 0x233E920 Offset: 0x233A920 VA: 0x233E920
	public bool CheckMode(MultipleHuntAction.SkillMode mode) { }

	// RVA: 0x233E930 Offset: 0x233A930 VA: 0x233E930
	public void SkillEnd(bool cancel) { }

	// RVA: 0x233E9B4 Offset: 0x233A9B4 VA: 0x233E9B4
	public void ApplyDamageCut(PlayerActionManagerBase playerAction) { }

	// RVA: 0x233E9C0 Offset: 0x233A9C0 VA: 0x233E9C0
	public void DamageFunction(SkillDamageData damageData) { }

	// RVA: 0x233EA88 Offset: 0x233AA88 VA: 0x233EA88
	public int GetHealValue(PlayerAttackBase skill, PlayerStatusBase status) { }

	// RVA: 0x233ED4C Offset: 0x233AD4C VA: 0x233ED4C
	public void AttackSkillEnd(PlayerAttackBase skill) { }
}
