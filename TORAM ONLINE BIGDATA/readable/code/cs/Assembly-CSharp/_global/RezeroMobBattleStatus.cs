// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RezeroMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1125
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private int level; // 0x30

	// Properties
	public int AvoidProbability { get; }
	public int GuardProbability { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public float DamagePercent { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public ElementType Element { get; }
	public int ExpDefMagic { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int Level { get; }
	public int MaxHp { get; }
	public int MoveSpeed { get; }
	public float NecessaryFleePercent { get; }
	public int NecessaryHit { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float StablePercent { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1F4A554 Offset: 0x1F46554 VA: 0x1F4A554 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F4A55C Offset: 0x1F4655C VA: 0x1F4A55C Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F4A564 Offset: 0x1F46564 VA: 0x1F4A564 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F4A5A0 Offset: 0x1F465A0 VA: 0x1F4A5A0 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F4A5DC Offset: 0x1F465DC VA: 0x1F4A5DC Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F4A5E4 Offset: 0x1F465E4 VA: 0x1F4A5E4 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F4A690 Offset: 0x1F46690 VA: 0x1F4A690 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F4A73C Offset: 0x1F4673C VA: 0x1F4A73C Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F4A744 Offset: 0x1F46744 VA: 0x1F4A744 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F4A75C Offset: 0x1F4675C VA: 0x1F4A75C Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F4A774 Offset: 0x1F46774 VA: 0x1F4A774 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F4A78C Offset: 0x1F4678C VA: 0x1F4A78C Slot: 5
	public int get_Level() { }

	// RVA: 0x1F4A794 Offset: 0x1F46794 VA: 0x1F4A794 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F4A79C Offset: 0x1F4679C VA: 0x1F4A79C Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F4A7B8 Offset: 0x1F467B8 VA: 0x1F4A7B8 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F4A7F0 Offset: 0x1F467F0 VA: 0x1F4A7F0 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F4A7F8 Offset: 0x1F467F8 VA: 0x1F4A7F8 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F4A814 Offset: 0x1F46814 VA: 0x1F4A814 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F4A830 Offset: 0x1F46830 VA: 0x1F4A830 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F4A864 Offset: 0x1F46864 VA: 0x1F4A864 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F4A880 Offset: 0x1F46880 VA: 0x1F4A880
	public void .ctor(MobStatusMaster master, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1F4A8EC Offset: 0x1F468EC VA: 0x1F4A8EC Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F4A8F4 Offset: 0x1F468F4 VA: 0x1F4A8F4 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F4AA08 Offset: 0x1F46A08 VA: 0x1F4AA08 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
