// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryAITactical : AutoMemberAITactical // TypeDefIndex: 666
{
	// Fields
	[CompilerGenerated]
	private MercenarySkillDelayManager <delayManager>k__BackingField; // 0x48
	public PlayerActionManagerBase playerActionManager; // 0x50
	private PlayerActionManagerBase mercenaryActionManager; // 0x58
	[CompilerGenerated]
	private SkillActionManager <skillActionManager>k__BackingField; // 0x60

	// Properties
	private MercenarySkillDelayManager delayManager { get; set; }
	private SkillActionManager skillActionManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AB8B40 Offset: 0x1AB4B40 VA: 0x1AB8B40
	private MercenarySkillDelayManager get_delayManager() { }

	[CompilerGenerated]
	// RVA: 0x1AB8B48 Offset: 0x1AB4B48 VA: 0x1AB8B48
	public void set_delayManager(MercenarySkillDelayManager value) { }

	[CompilerGenerated]
	// RVA: 0x1AB8B50 Offset: 0x1AB4B50 VA: 0x1AB8B50
	private SkillActionManager get_skillActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1AB8B58 Offset: 0x1AB4B58 VA: 0x1AB8B58
	private void set_skillActionManager(SkillActionManager value) { }

	[IteratorStateMachine(typeof(MercenaryAITactical.<GetParam>d__10))]
	// RVA: 0x1AB8B60 Offset: 0x1AB4B60 VA: 0x1AB8B60
	public IEnumerable<string> GetParam() { }

	// RVA: 0x1AB8C10 Offset: 0x1AB4C10 VA: 0x1AB8C10
	public void .ctor(SkillActionManager skillActionManager, PlayerActionManagerBase mercenaryActionManager) { }

	// RVA: 0x1AB8C80 Offset: 0x1AB4C80 VA: 0x1AB8C80 Slot: 4
	public override void InitializePattern(SkillId firstSkillId, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1AB8D68 Offset: 0x1AB4D68 VA: 0x1AB8D68 Slot: 6
	public override void Reset() { }

	// RVA: 0x1AB90FC Offset: 0x1AB50FC VA: 0x1AB90FC Slot: 7
	public override SkillId GetSkillId(out byte lv) { }

	// RVA: 0x1AB96A0 Offset: 0x1AB56A0 VA: 0x1AB96A0
	protected bool CheckCanUseSkill(AIActionCondition condition, SkillId skillId, byte skillLv) { }

	// RVA: 0x1AB9994 Offset: 0x1AB5994 VA: 0x1AB9994
	private bool IsOutOfEquipmentChceck(SkillId skillId) { }

	// RVA: 0x1AB99B8 Offset: 0x1AB59B8 VA: 0x1AB99B8
	private bool CheckUseSkillMatchEquipment(SkillId skillId) { }

	// RVA: 0x1AB9B44 Offset: 0x1AB5B44 VA: 0x1AB9B44
	private bool CheckMatchAICondition(AIActionCondition condition) { }

	// RVA: 0x1AB9D8C Offset: 0x1AB5D8C VA: 0x1AB9D8C
	protected bool checkDeadInPartyMember(int people) { }

	// RVA: 0x1AB9E44 Offset: 0x1AB5E44 VA: 0x1AB9E44
	protected bool CheckProtectedLoad() { }

	// RVA: 0x1AB9E60 Offset: 0x1AB5E60 VA: 0x1AB9E60
	protected bool CheckProtectedOwner() { }

	// RVA: 0x1AB9E7C Offset: 0x1AB5E7C VA: 0x1AB9E7C
	protected bool HealLoad(int persenteHp) { }

	// RVA: 0x1ABA21C Offset: 0x1AB621C VA: 0x1ABA21C
	protected bool CheakHateTargetToOwner() { }

	// RVA: 0x1ABA18C Offset: 0x1AB618C VA: 0x1ABA18C
	private bool CheckLoadHpBelowForUseAutoItemRate() { }

	// RVA: 0x1ABA290 Offset: 0x1AB6290 VA: 0x1ABA290
	private bool CheckSpecialAttack() { }
}
