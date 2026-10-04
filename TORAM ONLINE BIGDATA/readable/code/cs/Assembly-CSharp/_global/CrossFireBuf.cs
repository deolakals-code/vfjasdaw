// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrossFireBuf : CountBufferBase // TypeDefIndex: 3117
{
	// Fields
	private int chargeLevel; // 0x28
	private readonly int maxChargeLevel; // 0x2C
	private bool isDamage; // 0x30
	private float chargeTime; // 0x34
	private PlayerDataManager player; // 0x38
	private SkillComboType comboType; // 0x40
	private int comboRate; // 0x44
	private readonly byte archetypeType; // 0x48

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	private bool IsPlayer { get; }

	// Methods

	// RVA: 0x2328A54 Offset: 0x2324A54 VA: 0x2328A54 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2328A5C Offset: 0x2324A5C VA: 0x2328A5C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2328A64 Offset: 0x2324A64 VA: 0x2328A64 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2328A6C Offset: 0x2324A6C VA: 0x2328A6C
	private bool get_IsPlayer() { }

	// RVA: 0x2328A88 Offset: 0x2324A88 VA: 0x2328A88
	public void .ctor(byte lv, int archetypeType) { }

	// RVA: 0x2328E04 Offset: 0x2324E04 VA: 0x2328E04 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2328E20 Offset: 0x2324E20 VA: 0x2328E20 Slot: 11
	public override void Updata() { }

	// RVA: 0x2328F0C Offset: 0x2324F0C VA: 0x2328F0C Slot: 13
	public override void OnDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23290B0 Offset: 0x23250B0 VA: 0x23290B0
	public void SetComboParam(SkillComboType type, int rate) { }

	// RVA: 0x23290B8 Offset: 0x23250B8 VA: 0x23290B8
	public void GetComboParam(out SkillComboType type, out int rate) { }

	// RVA: 0x2328E78 Offset: 0x2324E78 VA: 0x2328E78
	private void NextChargeLevel() { }

	// RVA: 0x2328C4C Offset: 0x2324C4C VA: 0x2328C4C
	private void ChargeAura() { }
}
