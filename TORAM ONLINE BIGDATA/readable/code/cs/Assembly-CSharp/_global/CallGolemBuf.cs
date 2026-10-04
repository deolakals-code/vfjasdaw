// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemBuf : SkillBufferDataBase // TypeDefIndex: 3092
{
	// Fields
	[CompilerGenerated]
	private bool <GolemBonus>k__BackingField; // 0x1D
	private int damageCut; // 0x20
	private CallGolemType golemType; // 0x24
	private int aspdRate; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool GolemBonus { get; set; }

	// Methods

	// RVA: 0x2321520 Offset: 0x231D520 VA: 0x2321520 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2321528 Offset: 0x231D528 VA: 0x2321528 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2321540 Offset: 0x231D540 VA: 0x2321540
	public bool get_GolemBonus() { }

	[CompilerGenerated]
	// RVA: 0x2321548 Offset: 0x231D548 VA: 0x2321548
	public void set_GolemBonus(bool value) { }

	// RVA: 0x2321554 Offset: 0x231D554 VA: 0x2321554
	public void .ctor(byte lv) { }

	// RVA: 0x2321778 Offset: 0x231D778 VA: 0x2321778 Slot: 11
	public override void Updata() { }

	// RVA: 0x23218F8 Offset: 0x231D8F8 VA: 0x23218F8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23217C8 Offset: 0x231D7C8 VA: 0x23217C8
	public void BufferEnd() { }

	// RVA: 0x2321938 Offset: 0x231D938 VA: 0x2321938
	public static int GetDamageResistRate(PlayerStatusBase playerStatus) { }
}
