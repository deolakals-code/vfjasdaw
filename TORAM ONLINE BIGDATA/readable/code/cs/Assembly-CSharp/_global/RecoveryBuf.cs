// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecoveryBuf : SkillBufferDataBase // TypeDefIndex: 3282
{
	// Fields
	private readonly RecoveryBuf.EffectType effectType; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public bool IsMpHeal { get; }
	public RecoveryBuf.EffectType Effect { get; }

	// Methods

	// RVA: 0x2342854 Offset: 0x233E854 VA: 0x2342854
	public static RecoveryBuf CreateDefaultBuf(byte lv, bool isSelf) { }

	// RVA: 0x2342940 Offset: 0x233E940 VA: 0x2342940
	public static RecoveryBuf CreateVenomSnatchBuf(byte poisonLevel) { }

	// RVA: 0x23429D4 Offset: 0x233E9D4 VA: 0x23429D4
	public static RecoveryBuf CreateAspisSeoulBuf(byte aspisSeoulLv, bool battleStartBonus) { }

	// RVA: 0x23428EC Offset: 0x233E8EC VA: 0x23428EC
	private void .ctor(byte lv, bool isSelf, RecoveryBuf.EffectType effectType) { }

	// RVA: 0x2342AD4 Offset: 0x233EAD4 VA: 0x2342AD4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2342ADC Offset: 0x233EADC VA: 0x2342ADC
	public bool get_IsMpHeal() { }

	// RVA: 0x2342B00 Offset: 0x233EB00 VA: 0x2342B00
	public RecoveryBuf.EffectType get_Effect() { }

	// RVA: 0x2342B08 Offset: 0x233EB08 VA: 0x2342B08 Slot: 11
	public override void Updata() { }

	// RVA: 0x2342B50 Offset: 0x233EB50 VA: 0x2342B50 Slot: 12
	public override int GetParam(int id) { }
}
