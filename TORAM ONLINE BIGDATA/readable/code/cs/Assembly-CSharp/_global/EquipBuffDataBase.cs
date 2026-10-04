// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class EquipBuffDataBase // TypeDefIndex: 1779
{
	// Fields
	[CompilerGenerated]
	private short <Value>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x12

	// Properties
	public short Value { get; set; }
	public bool IsValid { get; set; }
	public abstract BonusType BonusType { get; }
	public virtual bool IsDataStack { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20DEFA8 Offset: 0x20DAFA8 VA: 0x20DEFA8
	public short get_Value() { }

	[CompilerGenerated]
	// RVA: 0x20DEFB0 Offset: 0x20DAFB0 VA: 0x20DEFB0
	protected void set_Value(short value) { }

	[CompilerGenerated]
	// RVA: 0x20DEFB8 Offset: 0x20DAFB8 VA: 0x20DEFB8
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x20DEFC0 Offset: 0x20DAFC0 VA: 0x20DEFC0
	protected void set_IsValid(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BonusType get_BonusType();

	// RVA: 0x20DEFCC Offset: 0x20DAFCC VA: 0x20DEFCC Slot: 5
	public virtual bool get_IsDataStack() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Updata();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Reset();

	// RVA: 0x20DEFD4 Offset: 0x20DAFD4 VA: 0x20DEFD4 Slot: 8
	public virtual int Calc(int value) { }

	// RVA: 0x20DEFDC Offset: 0x20DAFDC VA: 0x20DEFDC Slot: 9
	public virtual int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x20DEFE4 Offset: 0x20DAFE4 VA: 0x20DEFE4 Slot: 10
	public virtual bool Function() { }

	// RVA: 0x20DEFEC Offset: 0x20DAFEC VA: 0x20DEFEC Slot: 11
	public virtual bool Function(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20DEFF4 Offset: 0x20DAFF4 VA: 0x20DEFF4 Slot: 12
	public virtual int GetParam() { }

	// RVA: 0x20DEFFC Offset: 0x20DAFFC VA: 0x20DEFFC Slot: 13
	public virtual void UpdateBufData(EquipBuffDataBase buf) { }

	// RVA: 0x20DF000 Offset: 0x20DB000 VA: 0x20DF000 Slot: 14
	public virtual void SumValue(short val) { }

	// RVA: 0x20DE730 Offset: 0x20DA730 VA: 0x20DE730
	protected void .ctor() { }
}
