// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CountBufferBase : SkillBufferDataBase // TypeDefIndex: 3105
{
	// Fields
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Max>k__BackingField; // 0x24

	// Properties
	public int Count { get; set; }
	public int Max { get; set; }
	public virtual bool Peak { get; }
	public abstract CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2322C30 Offset: 0x231EC30 VA: 0x2322C30
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x2322C38 Offset: 0x231EC38 VA: 0x2322C38
	protected void set_Count(int value) { }

	[CompilerGenerated]
	// RVA: 0x2322C40 Offset: 0x231EC40 VA: 0x2322C40
	public int get_Max() { }

	[CompilerGenerated]
	// RVA: 0x2322C48 Offset: 0x231EC48 VA: 0x2322C48
	protected void set_Max(int value) { }

	// RVA: 0x2322C50 Offset: 0x231EC50 VA: 0x2322C50 Slot: 21
	public virtual bool get_Peak() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract CountBufferBase.CountType get_BufferType();

	// RVA: 0x231F030 Offset: 0x231B030 VA: 0x231F030 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231EE54 Offset: 0x231AE54 VA: 0x231EE54
	public void .ctor(byte lv, bool self, int max) { }

	// RVA: 0x2322108 Offset: 0x231E108 VA: 0x2322108 Slot: 23
	public virtual void Next() { }

	// RVA: 0x2322C60 Offset: 0x231EC60 VA: 0x2322C60 Slot: 24
	public virtual void NextSkip(int count) { }

	// RVA: 0x231FFE8 Offset: 0x231BFE8 VA: 0x231FFE8 Slot: 25
	public virtual void Prev() { }

	// RVA: 0x2322CD4 Offset: 0x231ECD4 VA: 0x2322CD4 Slot: 26
	public virtual void PrevSkip(int count) { }

	// RVA: 0x231F694 Offset: 0x231B694 VA: 0x231F694 Slot: 12
	public override int GetParam(int id) { }
}
