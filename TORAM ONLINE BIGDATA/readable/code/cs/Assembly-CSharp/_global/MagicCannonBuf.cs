// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicCannonBuf : CountBufferBase // TypeDefIndex: 3234
{
	// Fields
	private const float CountUpTime = 1;
	private const int MaxChargeValue = 10000;
	private const int MaxOverChargeValue = 20000;
	private const int KadarElexioChargeValue = 10000;
	private int bonus; // 0x28
	private float chargeTimer; // 0x2C
	private int chargeValue; // 0x30
	private SkillComboType comboType; // 0x34
	private int comboRate; // 0x38
	private SkillBufferFlag flag; // 0x3C

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x233A0F0 Offset: 0x23360F0 VA: 0x233A0F0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233A0F8 Offset: 0x23360F8 VA: 0x233A0F8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233A108 Offset: 0x2336108 VA: 0x233A108 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233A110 Offset: 0x2336110 VA: 0x233A110
	public void .ctor(byte lv) { }

	// RVA: 0x233A170 Offset: 0x2336170 VA: 0x233A170 Slot: 11
	public override void Updata() { }

	// RVA: 0x233A1C8 Offset: 0x23361C8 VA: 0x233A1C8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233A1F8 Offset: 0x23361F8 VA: 0x233A1F8 Slot: 23
	public override void Next() { }

	// RVA: 0x233A294 Offset: 0x2336294 VA: 0x233A294
	public void SetComboParam(SkillComboType type, int rate) { }

	// RVA: 0x233A29C Offset: 0x233629C VA: 0x233A29C
	public void GetComboParam(out SkillComboType type, out int rate) { }

	// RVA: 0x233A2B0 Offset: 0x23362B0 VA: 0x233A2B0
	public void Charge(PlayerStatusBase status, float castTime) { }

	// RVA: 0x233A494 Offset: 0x2336494 VA: 0x233A494
	public void MagicBalkanCharge(PlayerStatusBase status, bool isFirst) { }

	// RVA: 0x233A5F8 Offset: 0x23365F8 VA: 0x233A5F8
	public void Start() { }

	// RVA: 0x233A254 Offset: 0x2336254 VA: 0x233A254
	private void UpdateChargeValue() { }
}
