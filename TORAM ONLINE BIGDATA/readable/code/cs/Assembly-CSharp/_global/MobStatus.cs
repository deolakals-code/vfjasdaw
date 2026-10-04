// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobStatus : IMobIdData // TypeDefIndex: 1028
{
	// Fields
	[SerializeField]
	private int serverHp; // 0x10
	[SerializeField]
	private int localHp; // 0x14
	private int localExpDefNormal; // 0x18
	private int localExpDefSkill; // 0x1C
	private int localExpDefMagic; // 0x20
	private int serverExpDefNormal; // 0x24
	private int serverExpDefSkill; // 0x28
	private int serverExpDefMagic; // 0x2C
	private List<MobStatus.HateData> hateList; // 0x30
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <IsLocalIdInit>k__BackingField; // 0x3D
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x40

	// Properties
	public int MobId { get; set; }
	public byte LocalId { get; set; }
	public bool IsLocalIdInit { get; set; }
	public int UniqueId { get; set; }
	public int Hp { get; }
	public int LocalHp { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public List<MobStatus.HateData> HateList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F36ED4 Offset: 0x1F32ED4 VA: 0x1F36ED4 Slot: 4
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x1F36EDC Offset: 0x1F32EDC VA: 0x1F36EDC
	private void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F36EE4 Offset: 0x1F32EE4 VA: 0x1F36EE4 Slot: 5
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x1F36EEC Offset: 0x1F32EEC VA: 0x1F36EEC
	private void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1F36EF4 Offset: 0x1F32EF4 VA: 0x1F36EF4
	public bool get_IsLocalIdInit() { }

	[CompilerGenerated]
	// RVA: 0x1F36EFC Offset: 0x1F32EFC VA: 0x1F36EFC
	private void set_IsLocalIdInit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F36F08 Offset: 0x1F32F08 VA: 0x1F36F08 Slot: 6
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x1F36F10 Offset: 0x1F32F10 VA: 0x1F36F10
	private void set_UniqueId(int value) { }

	// RVA: 0x1F36F18 Offset: 0x1F32F18 VA: 0x1F36F18
	public int get_Hp() { }

	// RVA: 0x1F36F20 Offset: 0x1F32F20 VA: 0x1F36F20
	public int get_LocalHp() { }

	// RVA: 0x1F36F28 Offset: 0x1F32F28 VA: 0x1F36F28
	public int get_ExpDefNormal() { }

	// RVA: 0x1F36F30 Offset: 0x1F32F30 VA: 0x1F36F30
	public int get_ExpDefSkill() { }

	// RVA: 0x1F36F38 Offset: 0x1F32F38 VA: 0x1F36F38
	public int get_ExpDefMagic() { }

	// RVA: 0x1F36F40 Offset: 0x1F32F40 VA: 0x1F36F40
	public List<MobStatus.HateData> get_HateList() { }

	// RVA: 0x1F36F48 Offset: 0x1F32F48 VA: 0x1F36F48
	public void .ctor(int mobid) { }

	// RVA: 0x1F36FF8 Offset: 0x1F32FF8 VA: 0x1F36FF8
	public void .ctor(int mobId, byte localId, int uniqueId) { }

	// RVA: 0x1F32CCC Offset: 0x1F2ECCC VA: 0x1F32CCC
	public bool IsMatch(IMobIdData mobId) { }

	// RVA: 0x1F30A20 Offset: 0x1F2CA20 VA: 0x1F30A20
	public bool IsFuzzyMatch(IMobIdData mobId) { }

	// RVA: 0x1F370BC Offset: 0x1F330BC VA: 0x1F370BC
	public void SetLocalID(int localid) { }

	// RVA: 0x1F370D8 Offset: 0x1F330D8 VA: 0x1F370D8
	public void SetUniqueID(int uniqueid) { }

	// RVA: 0x1F370EC Offset: 0x1F330EC VA: 0x1F370EC
	public void InitHp(int hp) { }

	// RVA: 0x1F370F4 Offset: 0x1F330F4 VA: 0x1F370F4
	public void ResetServerHp() { }

	// RVA: 0x1F37108 Offset: 0x1F33108 VA: 0x1F37108
	public void SetHp(int hp) { }

	// RVA: 0x1F37120 Offset: 0x1F33120 VA: 0x1F37120
	public void SetLocalHp(int hp) { }

	// RVA: 0x1F3712C Offset: 0x1F3312C VA: 0x1F3712C
	public void ResetServerExpDef() { }

	// RVA: 0x1F37140 Offset: 0x1F33140 VA: 0x1F37140
	public void SetExpDef(int normal, int skill, int magic) { }

	// RVA: 0x1F37150 Offset: 0x1F33150 VA: 0x1F37150
	public void CalcExpDef(MobStatus.AttackType type, int normal, int skill, int magic) { }

	// RVA: 0x1F371D0 Offset: 0x1F331D0 VA: 0x1F371D0
	public int GetExp(SkillAttackType type) { }

	// RVA: 0x1F37214 Offset: 0x1F33214 VA: 0x1F37214
	public void UpdateHate(MobHateData[] hate) { }

	// RVA: 0x1F373B8 Offset: 0x1F333B8 VA: 0x1F373B8
	public void UpdateHate(byte archetypeType, int archetypeId, int hateValue) { }

	// RVA: 0x1F3755C Offset: 0x1F3355C VA: 0x1F3755C Slot: 3
	public override string ToString() { }
}
