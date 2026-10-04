// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobPartsStatus // TypeDefIndex: 1011
{
	// Fields
	private readonly short difficulty; // 0x10
	private readonly MobPropertyCut partsCut; // 0x18
	private readonly MobPropertyCut bodyCut; // 0x20
	[CompilerGenerated]
	private MobStatusMaster <statusMaster>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <LocalHp>k__BackingField; // 0x34

	// Properties
	public MobStatusMaster statusMaster { get; set; }
	public int Hp { get; set; }
	public int LocalHp { get; set; }
	public bool IsDead { get; }
	public virtual int NecessaryHit { get; }
	public virtual int Def { get; }
	public virtual int MagicDef { get; }
	public MobPropertyCut PartsCut { get; }
	public MobPropertyCut BodyCut { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F33CB4 Offset: 0x1F2FCB4 VA: 0x1F33CB4
	public MobStatusMaster get_statusMaster() { }

	[CompilerGenerated]
	// RVA: 0x1F33CBC Offset: 0x1F2FCBC VA: 0x1F33CBC
	private void set_statusMaster(MobStatusMaster value) { }

	[CompilerGenerated]
	// RVA: 0x1F33CC4 Offset: 0x1F2FCC4 VA: 0x1F33CC4
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x1F33CCC Offset: 0x1F2FCCC VA: 0x1F33CCC
	private void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F33CD4 Offset: 0x1F2FCD4 VA: 0x1F33CD4
	public int get_LocalHp() { }

	[CompilerGenerated]
	// RVA: 0x1F33CDC Offset: 0x1F2FCDC VA: 0x1F33CDC
	private void set_LocalHp(int value) { }

	// RVA: 0x1F33CE4 Offset: 0x1F2FCE4 VA: 0x1F33CE4
	public bool get_IsDead() { }

	// RVA: 0x1F33CF4 Offset: 0x1F2FCF4 VA: 0x1F33CF4 Slot: 4
	public virtual int get_NecessaryHit() { }

	// RVA: 0x1F33D64 Offset: 0x1F2FD64 VA: 0x1F33D64 Slot: 5
	public virtual int get_Def() { }

	// RVA: 0x1F33DD4 Offset: 0x1F2FDD4 VA: 0x1F33DD4 Slot: 6
	public virtual int get_MagicDef() { }

	// RVA: 0x1F33E44 Offset: 0x1F2FE44 VA: 0x1F33E44
	public MobPropertyCut get_PartsCut() { }

	// RVA: 0x1F33E4C Offset: 0x1F2FE4C VA: 0x1F33E4C
	public MobPropertyCut get_BodyCut() { }

	// RVA: 0x1F33E54 Offset: 0x1F2FE54 VA: 0x1F33E54
	public void .ctor(MobStatusMaster statusMaster, int hp, short difficulty) { }

	// RVA: 0x1F33F14 Offset: 0x1F2FF14 VA: 0x1F33F14
	public void ResetHp() { }

	// RVA: 0x1F33F30 Offset: 0x1F2FF30 VA: 0x1F33F30
	public void SetLocalHp(int hp) { }

	// RVA: 0x1F33F24 Offset: 0x1F2FF24 VA: 0x1F33F24
	public void SetHp(int hp) { }
}
