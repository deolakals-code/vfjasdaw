// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class KadarElexioBuf : CountBufferBase // TypeDefIndex: 3217
{
	// Fields
	private SkillBufferFlag bufFlag; // 0x28
	private readonly EffectPlayer effectPlayer; // 0x30
	private int bufferEffectState; // 0x38
	private bool isStack; // 0x3C
	private List<KadarElexioBuf.SkillIdData> effectiveSkillList; // 0x40
	private bool effectiveKadarElexio; // 0x48
	private bool activeOverloadBonus; // 0x49
	private int overloadValue; // 0x4C
	private float overloadTimer; // 0x50
	private bool validOverloadBonus; // 0x54
	private bool createBodyAura; // 0x55
	private ElementType element; // 0x58

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2336B1C Offset: 0x2332B1C VA: 0x2336B1C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2336B24 Offset: 0x2332B24 VA: 0x2336B24 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2336B2C Offset: 0x2332B2C VA: 0x2336B2C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2336B34 Offset: 0x2332B34 VA: 0x2336B34 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2336B54 Offset: 0x2332B54 VA: 0x2336B54
	public void .ctor(byte lv, ElementType elementType, EffectPlayer effectPlayer) { }

	// RVA: 0x2336C1C Offset: 0x2332C1C VA: 0x2336C1C
	public static KadarElexioBuf CreateOverloadStart(byte lv, ElementType elementType, EffectPlayer effectPlayer) { }

	// RVA: 0x2336C98 Offset: 0x2332C98 VA: 0x2336C98
	public static KadarElexioBuf CreateFailure() { }

	// RVA: 0x2336D04 Offset: 0x2332D04 VA: 0x2336D04 Slot: 11
	public override void Updata() { }

	// RVA: 0x2336F9C Offset: 0x2332F9C VA: 0x2336F9C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2336F54 Offset: 0x2332F54 VA: 0x2336F54
	private bool CheckEnd() { }

	// RVA: 0x2337014 Offset: 0x2333014 VA: 0x2337014
	public void ActiveKadarElexio(int maxHpRate) { }

	// RVA: 0x2336DB0 Offset: 0x2332DB0 VA: 0x2336DB0
	public void InactiveKadarElexio() { }

	// RVA: 0x2337108 Offset: 0x2333108 VA: 0x2337108
	public void FailureKadarElexio(int maxHpRate) { }

	// RVA: 0x2337118 Offset: 0x2333118 VA: 0x2337118
	public bool CheckCritical(int skillId, byte localId) { }

	// RVA: 0x2337228 Offset: 0x2333228 VA: 0x2337228
	public bool CheckMpHalving(PlayerAttackBase skill) { }

	// RVA: 0x2337230 Offset: 0x2333230 VA: 0x2337230
	public bool SetNextUseSkill(int skillId, byte localId) { }

	// RVA: 0x2337360 Offset: 0x2333360 VA: 0x2337360
	public void EndNextSkill(int skillId, byte localId) { }

	// RVA: 0x2337500 Offset: 0x2333500 VA: 0x2337500
	public void BattleActive() { }

	// RVA: 0x2337048 Offset: 0x2333048 VA: 0x2337048
	public void BattleEnd() { }

	// RVA: 0x2337510 Offset: 0x2333510 VA: 0x2337510
	private void ChargeAura() { }

	// RVA: 0x2337720 Offset: 0x2333720 VA: 0x2337720
	public void ActiveOverload() { }

	// RVA: 0x2337768 Offset: 0x2333768 VA: 0x2337768
	public void InactiveOverload() { }

	// RVA: 0x2337824 Offset: 0x2333824 VA: 0x2337824
	public void ResetOverload() { }

	// RVA: 0x23378D0 Offset: 0x23338D0 VA: 0x23378D0
	public void EndEffectTime() { }

	// RVA: 0x23379A0 Offset: 0x23339A0 VA: 0x23379A0
	public void ValidOverloadLastDamageRate() { }

	// RVA: 0x23379AC Offset: 0x23339AC VA: 0x23379AC
	public void InvalidOverloadLastDamageRate() { }

	// RVA: 0x2336DEC Offset: 0x2332DEC VA: 0x2336DEC
	private void ChargeOverloadValue() { }
}
