// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class EquipSkillBufferBase : SkillBufferDataBase // TypeDefIndex: 3153
{
	// Fields
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x20

	// Properties
	public int Value { get; set; }
	public virtual bool IsDataStack { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x232CF10 Offset: 0x2328F10 VA: 0x232CF10
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x232CF18 Offset: 0x2328F18 VA: 0x232CF18
	protected void set_Value(int value) { }

	// RVA: 0x232CF20 Offset: 0x2328F20 VA: 0x232CF20 Slot: 21
	public virtual bool get_IsDataStack() { }

	// RVA: 0x232C374 Offset: 0x2328374 VA: 0x232C374
	public void .ctor() { }

	// RVA: 0x232CF28 Offset: 0x2328F28 VA: 0x232CF28 Slot: 22
	public virtual int Calc(int value) { }

	// RVA: 0x232CF30 Offset: 0x2328F30 VA: 0x232CF30 Slot: 23
	public virtual int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x232CF38 Offset: 0x2328F38 VA: 0x232CF38 Slot: 24
	public virtual void UpdateBufData(SkillBufferDataBase buf) { }

	// RVA: 0x232CF3C Offset: 0x2328F3C VA: 0x232CF3C Slot: 25
	public virtual void SumValue(int val) { }

	// RVA: 0x232CF4C Offset: 0x2328F4C VA: 0x232CF4C Slot: 26
	public virtual bool CheckTakeOver(PlayerStatusBase playerStatus) { }
}
