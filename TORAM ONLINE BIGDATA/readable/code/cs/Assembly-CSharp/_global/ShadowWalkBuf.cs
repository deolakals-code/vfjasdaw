// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShadowWalkBuf : CountBufferBase // TypeDefIndex: 3301
{
	// Fields
	[CompilerGenerated]
	private bool <IsInvalidDamage>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsInRange>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsManual>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <InvincibilityLocalId>k__BackingField; // 0x2B
	private PlayerActionManagerBase playerAction; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public bool IsInvalidDamage { get; set; }
	public bool IsInRange { get; set; }
	public bool IsManual { get; set; }
	public byte InvincibilityLocalId { get; set; }

	// Methods

	// RVA: 0x2344A64 Offset: 0x2340A64 VA: 0x2344A64 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2344A6C Offset: 0x2340A6C VA: 0x2344A6C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2344A74 Offset: 0x2340A74 VA: 0x2344A74 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2344A8C Offset: 0x2340A8C VA: 0x2344A8C
	public bool get_IsInvalidDamage() { }

	[CompilerGenerated]
	// RVA: 0x2344A94 Offset: 0x2340A94 VA: 0x2344A94
	private void set_IsInvalidDamage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2344AA0 Offset: 0x2340AA0 VA: 0x2344AA0
	public bool get_IsInRange() { }

	[CompilerGenerated]
	// RVA: 0x2344AA8 Offset: 0x2340AA8 VA: 0x2344AA8
	private void set_IsInRange(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2344AB4 Offset: 0x2340AB4 VA: 0x2344AB4
	public bool get_IsManual() { }

	[CompilerGenerated]
	// RVA: 0x2344ABC Offset: 0x2340ABC VA: 0x2344ABC
	private void set_IsManual(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2344AC8 Offset: 0x2340AC8 VA: 0x2344AC8
	public byte get_InvincibilityLocalId() { }

	[CompilerGenerated]
	// RVA: 0x2344AD0 Offset: 0x2340AD0 VA: 0x2344AD0
	private void set_InvincibilityLocalId(byte value) { }

	// RVA: 0x2344AD8 Offset: 0x2340AD8 VA: 0x2344AD8
	public void .ctor(byte lv, PlayerActionManagerBase player) { }

	// RVA: 0x2344B24 Offset: 0x2340B24 VA: 0x2344B24 Slot: 11
	public override void Updata() { }

	// RVA: 0x2344B6C Offset: 0x2340B6C VA: 0x2344B6C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2344B74 Offset: 0x2340B74 VA: 0x2344B74
	public void SyncStackCount(int stack) { }

	// RVA: 0x2344B90 Offset: 0x2340B90 VA: 0x2344B90
	public void StartAvoid() { }

	// RVA: 0x2344B98 Offset: 0x2340B98 VA: 0x2344B98
	public void SetInRange() { }

	// RVA: 0x2344BA4 Offset: 0x2340BA4 VA: 0x2344BA4
	public bool CheckInvalidDamage() { }

	// RVA: 0x2344BB4 Offset: 0x2340BB4 VA: 0x2344BB4
	public void InvalidDamage(bool isManual) { }

	// RVA: 0x2344C04 Offset: 0x2340C04 VA: 0x2344C04
	public void StartShadowWalkAttack() { }
}
