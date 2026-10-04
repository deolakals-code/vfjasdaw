// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighRaidMobPartsStatus : MobPartsStatus // TypeDefIndex: 894
{
	// Fields
	private int mobLevel; // 0x38

	// Properties
	public override int NecessaryHit { get; }
	public override int Def { get; }
	public override int MagicDef { get; }

	// Methods

	// RVA: 0x1EFB490 Offset: 0x1EF7490 VA: 0x1EFB490
	public void .ctor(MobStatusMaster statusMaster, int hp, short difficulty, int level) { }

	// RVA: 0x1EFEB74 Offset: 0x1EFAB74 VA: 0x1EFEB74 Slot: 4
	public override int get_NecessaryHit() { }

	// RVA: 0x1EFEC4C Offset: 0x1EFAC4C VA: 0x1EFEC4C Slot: 5
	public override int get_Def() { }

	// RVA: 0x1EFED1C Offset: 0x1EFAD1C VA: 0x1EFED1C Slot: 6
	public override int get_MagicDef() { }
}
