// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbsoluteFreeRate : EquipBuffDataBase // TypeDefIndex: 1773
{
	// Fields
	private const short MAX = 30;
	[CompilerGenerated]
	private short <CalcValue>k__BackingField; // 0x14

	// Properties
	public override BonusType BonusType { get; }
	public short CalcValue { get; set; }

	// Methods

	// RVA: 0x20DE690 Offset: 0x20DA690 VA: 0x20DE690 Slot: 4
	public override BonusType get_BonusType() { }

	[CompilerGenerated]
	// RVA: 0x20DE698 Offset: 0x20DA698 VA: 0x20DE698
	public short get_CalcValue() { }

	[CompilerGenerated]
	// RVA: 0x20DE6A0 Offset: 0x20DA6A0 VA: 0x20DE6A0
	private void set_CalcValue(short value) { }

	// RVA: 0x20DE6A8 Offset: 0x20DA6A8 VA: 0x20DE6A8
	public void .ctor(short value) { }

	// RVA: 0x20DE738 Offset: 0x20DA738 VA: 0x20DE738 Slot: 7
	public override void Reset() { }

	// RVA: 0x20DE73C Offset: 0x20DA73C VA: 0x20DE73C Slot: 6
	public override void Updata() { }

	// RVA: 0x20DE740 Offset: 0x20DA740 VA: 0x20DE740 Slot: 8
	public override int Calc(int value) { }

	// RVA: 0x20DE768 Offset: 0x20DA768 VA: 0x20DE768 Slot: 14
	public override void SumValue(short val) { }
}
