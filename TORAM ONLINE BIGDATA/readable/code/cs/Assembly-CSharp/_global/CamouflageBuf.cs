// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CamouflageBuf : SkillBufferDataBase // TypeDefIndex: 3093
{
	// Fields
	[CompilerGenerated]
	private bool <IsEndChangeHate>k__BackingField; // 0x1D
	private PlayerStatusBase playerStatus; // 0x20
	private int criticalUp; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public bool IsEndChangeHate { get; set; }

	// Methods

	// RVA: 0x2321C98 Offset: 0x231DC98 VA: 0x2321C98 Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x2321CA0 Offset: 0x231DCA0 VA: 0x2321CA0
	public bool get_IsEndChangeHate() { }

	[CompilerGenerated]
	// RVA: 0x2321CA8 Offset: 0x231DCA8 VA: 0x2321CA8
	private void set_IsEndChangeHate(bool value) { }

	// RVA: 0x2321CB4 Offset: 0x231DCB4 VA: 0x2321CB4
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x2321D08 Offset: 0x231DD08 VA: 0x2321D08 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2321E9C Offset: 0x231DE9C VA: 0x2321E9C Slot: 11
	public override void Updata() { }

	// RVA: 0x2321EEC Offset: 0x231DEEC VA: 0x2321EEC
	public void ChangeHateManaged() { }
}
