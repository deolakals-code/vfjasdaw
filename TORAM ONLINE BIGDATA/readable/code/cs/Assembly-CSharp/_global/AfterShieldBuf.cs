// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AfterShieldBuf : SkillBufferDataBase // TypeDefIndex: 3062
{
	// Fields
	[CompilerGenerated]
	private bool <IsCooltime>k__BackingField; // 0x1D

	// Properties
	public override SkillId SkillId { get; }
	public bool IsCooltime { get; set; }

	// Methods

	// RVA: 0x231CCB0 Offset: 0x2318CB0 VA: 0x231CCB0
	public static AfterShieldBuf CreateDefaultBuf(byte lv) { }

	// RVA: 0x231CD30 Offset: 0x2318D30 VA: 0x231CD30
	public static AfterShieldBuf CreateCooltimeBuf(byte lv) { }

	// RVA: 0x231CD24 Offset: 0x2318D24 VA: 0x231CD24
	private void .ctor(byte lv) { }

	// RVA: 0x231CDA8 Offset: 0x2318DA8 VA: 0x231CDA8 Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x231CDB0 Offset: 0x2318DB0 VA: 0x231CDB0
	public bool get_IsCooltime() { }

	[CompilerGenerated]
	// RVA: 0x231CDB8 Offset: 0x2318DB8 VA: 0x231CDB8
	private void set_IsCooltime(bool value) { }

	// RVA: 0x231CDC4 Offset: 0x2318DC4 VA: 0x231CDC4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231CE54 Offset: 0x2318E54 VA: 0x231CE54 Slot: 11
	public override void Updata() { }
}
