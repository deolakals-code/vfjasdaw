// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 873
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private readonly int mobLevel; // 0x30
	private readonly int areaLevel; // 0x34

	// Properties
	public int MaxHp { get; }
	public int Level { get; }
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

	// RVA: 0x1EE76D0 Offset: 0x1EE36D0 VA: 0x1EE76D0
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int playerLevel, int area, int day) { }

	// RVA: 0x1EE785C Offset: 0x1EE385C VA: 0x1EE785C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EE7864 Offset: 0x1EE3864 VA: 0x1EE7864 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EE7A64 Offset: 0x1EE3A64 VA: 0x1EE7A64 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EE7C64 Offset: 0x1EE3C64 VA: 0x1EE7C64 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1EE7CD0 Offset: 0x1EE3CD0 VA: 0x1EE7CD0 Slot: 5
	public int get_Level() { }

	// RVA: 0x1EE7CD8 Offset: 0x1EE3CD8 VA: 0x1EE7CD8 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EE7978 Offset: 0x1EE3978 VA: 0x1EE7978 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EE7B78 Offset: 0x1EE3B78 VA: 0x1EE7B78 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EE7D30 Offset: 0x1EE3D30 VA: 0x1EE7D30 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EE7D78 Offset: 0x1EE3D78 VA: 0x1EE7D78 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EE7DC0 Offset: 0x1EE3DC0 VA: 0x1EE7DC0 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EE7EAC Offset: 0x1EE3EAC VA: 0x1EE7EAC Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EE7F18 Offset: 0x1EE3F18 VA: 0x1EE7F18 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EE7F34 Offset: 0x1EE3F34 VA: 0x1EE7F34 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EE7F50 Offset: 0x1EE3F50 VA: 0x1EE7F50 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EE7F6C Offset: 0x1EE3F6C VA: 0x1EE7F6C Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EE7F88 Offset: 0x1EE3F88 VA: 0x1EE7F88 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EE803C Offset: 0x1EE403C VA: 0x1EE803C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EE809C Offset: 0x1EE409C VA: 0x1EE809C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EE80D0 Offset: 0x1EE40D0 VA: 0x1EE80D0 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EE80E8 Offset: 0x1EE40E8 VA: 0x1EE80E8 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EE8100 Offset: 0x1EE4100 VA: 0x1EE8100 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EE8118 Offset: 0x1EE4118 VA: 0x1EE8118 Slot: 23
	public MobPropertyManager get_Property() { }
}
