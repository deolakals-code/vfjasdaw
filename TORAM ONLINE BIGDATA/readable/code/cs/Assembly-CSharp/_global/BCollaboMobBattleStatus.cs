// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BCollaboMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 846
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	private readonly MobStatusMaster statusMaster; // 0x18
	private readonly AbnormalStateManager abnormalState; // 0x20
	private readonly MobBuffManager buffManager; // 0x28
	private MobStatus mobStatus; // 0x30

	// Properties
	public int MaxHp { get; }
	public int Level { get; set; }
	public int NecessaryHit { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public int GuardProbability { get; }
	public int AvoidProbability { get; }
	public ElementType Element { get; }
	public int MoveSpeed { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float DamagePercent { get; }
	public float NecessaryFleePercent { get; }
	public float StablePercent { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1EC9014 Offset: 0x1EC5014 VA: 0x1EC9014
	public void .ctor(MobStatusMaster master, AbnormalStateManager abnormal, MobBuffManager buff, int level) { }

	// RVA: 0x1EC9CC0 Offset: 0x1EC5CC0 VA: 0x1EC9CC0 Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1EC9D48 Offset: 0x1EC5D48 VA: 0x1EC9D48 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1EC9D50 Offset: 0x1EC5D50 VA: 0x1EC9D50
	private void set_Level(int value) { }

	// RVA: 0x1EC9D58 Offset: 0x1EC5D58 VA: 0x1EC9D58 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EC9DB0 Offset: 0x1EC5DB0 VA: 0x1EC9DB0 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EC9E80 Offset: 0x1EC5E80 VA: 0x1EC9E80 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EC9F50 Offset: 0x1EC5F50 VA: 0x1EC9F50 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EC9FA8 Offset: 0x1EC5FA8 VA: 0x1EC9FA8 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1ECA000 Offset: 0x1EC6000 VA: 0x1ECA000 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1ECA0DC Offset: 0x1EC60DC VA: 0x1ECA0DC Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1ECA140 Offset: 0x1EC6140 VA: 0x1ECA140 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EC8F34 Offset: 0x1EC4F34 VA: 0x1EC8F34 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1ECA15C Offset: 0x1EC615C VA: 0x1ECA15C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1ECA178 Offset: 0x1EC6178 VA: 0x1ECA178 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1ECA194 Offset: 0x1EC6194 VA: 0x1ECA194 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1ECA248 Offset: 0x1EC6248 VA: 0x1ECA248 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1ECA2A8 Offset: 0x1EC62A8 VA: 0x1ECA2A8 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1ECA2DC Offset: 0x1EC62DC VA: 0x1ECA2DC Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1ECA2F4 Offset: 0x1EC62F4 VA: 0x1ECA2F4 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1ECA30C Offset: 0x1EC630C VA: 0x1ECA30C Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1ECA324 Offset: 0x1EC6324 VA: 0x1ECA324 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1ECA340 Offset: 0x1EC6340 VA: 0x1ECA340 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1ECA454 Offset: 0x1EC6454 VA: 0x1ECA454 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1ECA568 Offset: 0x1EC6568 VA: 0x1ECA568 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }
}
