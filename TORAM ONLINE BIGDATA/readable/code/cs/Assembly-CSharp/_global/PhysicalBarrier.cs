// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhysicalBarrier : EquipBuffDataBase // TypeDefIndex: 1789
{
	// Fields
	private readonly float coolTime; // 0x14
	[CompilerGenerated]
	private float <Timer>k__BackingField; // 0x18

	// Properties
	public override BonusType BonusType { get; }
	public override bool IsDataStack { get; }
	public float Timer { get; set; }

	// Methods

	// RVA: 0x20DFDBC Offset: 0x20DBDBC VA: 0x20DFDBC Slot: 4
	public override BonusType get_BonusType() { }

	// RVA: 0x20DFDC4 Offset: 0x20DBDC4 VA: 0x20DFDC4 Slot: 5
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x20DFDCC Offset: 0x20DBDCC VA: 0x20DFDCC
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x20DFDD4 Offset: 0x20DBDD4 VA: 0x20DFDD4
	private void set_Timer(float value) { }

	// RVA: 0x20DFDDC Offset: 0x20DBDDC VA: 0x20DFDDC
	public void .ctor(short value) { }

	// RVA: 0x20DFE14 Offset: 0x20DBE14 VA: 0x20DFE14 Slot: 6
	public override void Updata() { }

	// RVA: 0x20DFE58 Offset: 0x20DBE58 VA: 0x20DFE58 Slot: 7
	public override void Reset() { }

	// RVA: 0x20DFE64 Offset: 0x20DBE64 VA: 0x20DFE64 Slot: 9
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x20E0030 Offset: 0x20DC030 VA: 0x20E0030 Slot: 13
	public override void UpdateBufData(EquipBuffDataBase buf) { }
}
