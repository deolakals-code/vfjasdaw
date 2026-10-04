// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GoliathTakeShotBuf : CountBufferBase // TypeDefIndex: 3182
{
	// Fields
	private int chargeLevel; // 0x28
	private readonly int maxChargeLevel; // 0x2C
	private float chargeTime; // 0x30
	private bool isMaxChargeEnd; // 0x34
	private PlayerDataManager playerDataManager; // 0x38
	private SkillComboType comboType; // 0x40
	private int comboRate; // 0x44
	private byte archetypeType; // 0x48

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2330E5C Offset: 0x232CE5C VA: 0x2330E5C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2330E64 Offset: 0x232CE64 VA: 0x2330E64 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2330E6C Offset: 0x232CE6C VA: 0x2330E6C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2330E84 Offset: 0x232CE84 VA: 0x2330E84
	public void .ctor(byte lv, int archetypeType) { }

	// RVA: 0x2331170 Offset: 0x232D170 VA: 0x2331170 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2331190 Offset: 0x232D190 VA: 0x2331190 Slot: 11
	public override void Updata() { }

	// RVA: 0x23313B4 Offset: 0x232D3B4 VA: 0x23313B4
	public void SetComboParam(SkillComboType type, int rate) { }

	// RVA: 0x23313BC Offset: 0x232D3BC VA: 0x23313BC
	public void GetComboParam(out SkillComboType type, out int rate) { }

	// RVA: 0x23313D0 Offset: 0x232D3D0 VA: 0x23313D0
	public void RecieveIncapacitatedAbnormal(float add) { }

	// RVA: 0x23313EC Offset: 0x232D3EC VA: 0x23313EC
	public void RecieveWeakAbnormal() { }

	// RVA: 0x2331400 Offset: 0x232D400 VA: 0x2331400
	public void Charge() { }

	// RVA: 0x23311E8 Offset: 0x232D1E8 VA: 0x23311E8
	private void NextChargeLevel() { }

	// RVA: 0x2330FC4 Offset: 0x232CFC4 VA: 0x2330FC4
	private void ChargeAura() { }
}
