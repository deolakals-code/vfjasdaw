// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class DragonicChargeBuf : CountBufferBase // TypeDefIndex: 3129
{
	// Fields
	[CompilerGenerated]
	private bool <IsWarnDetection>k__BackingField; // 0x28
	private float chargeValue; // 0x2C
	private bool isCharge; // 0x30
	private float time; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public bool IsAttackPermission { get; }
	public bool IsWarnDetection { get; set; }
	public bool IsCharge { get; }

	// Methods

	// RVA: 0x232998C Offset: 0x232598C VA: 0x232998C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2329994 Offset: 0x2325994 VA: 0x2329994 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232999C Offset: 0x232599C VA: 0x232999C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23299A4 Offset: 0x23259A4 VA: 0x23299A4
	public bool get_IsAttackPermission() { }

	[CompilerGenerated]
	// RVA: 0x23299B8 Offset: 0x23259B8 VA: 0x23299B8
	public bool get_IsWarnDetection() { }

	[CompilerGenerated]
	// RVA: 0x23299C0 Offset: 0x23259C0 VA: 0x23299C0
	private void set_IsWarnDetection(bool value) { }

	// RVA: 0x23299CC Offset: 0x23259CC VA: 0x23299CC
	public bool get_IsCharge() { }

	// RVA: 0x23299D4 Offset: 0x23259D4 VA: 0x23299D4
	public void .ctor(byte lv) { }

	// RVA: 0x2329A18 Offset: 0x2325A18 VA: 0x2329A18 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2329A48 Offset: 0x2325A48 VA: 0x2329A48 Slot: 11
	public override void Updata() { }

	// RVA: 0x2329AC8 Offset: 0x2325AC8 VA: 0x2329AC8
	public void StopCharge() { }

	// RVA: 0x2329AD0 Offset: 0x2325AD0 VA: 0x2329AD0
	public void WarnMobAttack() { }
}
