// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RateBarrier : EquipBuffDataBase // TypeDefIndex: 1791
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

	// RVA: 0x20E06D0 Offset: 0x20DC6D0 VA: 0x20E06D0 Slot: 4
	public override BonusType get_BonusType() { }

	// RVA: 0x20E06D8 Offset: 0x20DC6D8 VA: 0x20E06D8 Slot: 5
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x20E06E0 Offset: 0x20DC6E0 VA: 0x20E06E0
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x20E06E8 Offset: 0x20DC6E8 VA: 0x20E06E8
	private void set_Timer(float value) { }

	// RVA: 0x20E06F0 Offset: 0x20DC6F0 VA: 0x20E06F0
	public void .ctor(short value) { }

	// RVA: 0x20E0728 Offset: 0x20DC728 VA: 0x20E0728 Slot: 6
	public override void Updata() { }

	// RVA: 0x20E076C Offset: 0x20DC76C VA: 0x20E076C Slot: 7
	public override void Reset() { }

	// RVA: 0x20E0778 Offset: 0x20DC778 VA: 0x20E0778 Slot: 9
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x20E09C0 Offset: 0x20DC9C0 VA: 0x20E09C0 Slot: 13
	public override void UpdateBufData(EquipBuffDataBase buf) { }
}
