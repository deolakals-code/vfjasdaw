// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedBurstSwordBuf : SkillBufferDataBase // TypeDefIndex: 3143
{
	// Fields
	public const int AuraTakeId = 300311001;
	private bool validBufferTake; // 0x1D

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x232B214 Offset: 0x2327214 VA: 0x232B214
	public void .ctor(byte lv, byte stack, bool validBufferEffectTake) { }

	// RVA: 0x232B274 Offset: 0x2327274 VA: 0x232B274 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232B27C Offset: 0x232727C VA: 0x232B27C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232B288 Offset: 0x2327288 VA: 0x232B288 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x232B2A0 Offset: 0x23272A0 VA: 0x232B2A0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232B2A8 Offset: 0x23272A8 VA: 0x232B2A8 Slot: 11
	public override void Updata() { }

	// RVA: 0x232B2F8 Offset: 0x23272F8 VA: 0x232B2F8 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x232B3C0 Offset: 0x23273C0 VA: 0x232B3C0
	public void UseUnionSword() { }
}
