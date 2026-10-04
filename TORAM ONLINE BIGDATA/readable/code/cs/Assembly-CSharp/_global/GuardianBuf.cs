// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardianBuf : CircleBufferBase // TypeDefIndex: 3183
{
	// Fields
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Refine>k__BackingField; // 0x38
	private PlayerStatusBase status; // 0x40

	// Properties
	public override SkillId SkillId { get; }
	private int Num { get; set; }
	private int Refine { get; set; }

	// Methods

	// RVA: 0x23314AC Offset: 0x232D4AC VA: 0x23314AC Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x23314B4 Offset: 0x232D4B4 VA: 0x23314B4
	private int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x23314BC Offset: 0x232D4BC VA: 0x23314BC
	public void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x23314C4 Offset: 0x232D4C4 VA: 0x23314C4
	private int get_Refine() { }

	[CompilerGenerated]
	// RVA: 0x23314CC Offset: 0x232D4CC VA: 0x23314CC
	public void set_Refine(int value) { }

	// RVA: 0x23314D4 Offset: 0x232D4D4 VA: 0x23314D4
	public void .ctor(byte lv, bool self, float time, int val) { }

	// RVA: 0x2331618 Offset: 0x232D618 VA: 0x2331618 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23318F4 Offset: 0x232D8F4 VA: 0x23318F4
	public void SetStatus(PlayerStatusBase status) { }
}
