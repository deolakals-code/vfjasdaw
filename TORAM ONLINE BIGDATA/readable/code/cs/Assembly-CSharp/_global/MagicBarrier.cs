// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBarrier : EquipBuffDataBase // TypeDefIndex: 1787
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

	// RVA: 0x20DF418 Offset: 0x20DB418 VA: 0x20DF418 Slot: 4
	public override BonusType get_BonusType() { }

	// RVA: 0x20DF420 Offset: 0x20DB420 VA: 0x20DF420 Slot: 5
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x20DF428 Offset: 0x20DB428 VA: 0x20DF428
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x20DF430 Offset: 0x20DB430 VA: 0x20DF430
	private void set_Timer(float value) { }

	// RVA: 0x20DF438 Offset: 0x20DB438 VA: 0x20DF438
	public void .ctor(short value) { }

	// RVA: 0x20DF470 Offset: 0x20DB470 VA: 0x20DF470 Slot: 6
	public override void Updata() { }

	// RVA: 0x20DF4B4 Offset: 0x20DB4B4 VA: 0x20DF4B4 Slot: 7
	public override void Reset() { }

	// RVA: 0x20DF4C0 Offset: 0x20DB4C0 VA: 0x20DF4C0 Slot: 9
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x20DF78C Offset: 0x20DB78C VA: 0x20DF78C Slot: 13
	public override void UpdateBufData(EquipBuffDataBase buf) { }
}
