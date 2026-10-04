// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IchijhinnokazeBuf : CountBufferBase // TypeDefIndex: 3202
{
	// Fields
	[CompilerGenerated]
	private IchijhinnokazeBuf.AttackMode <NowAttackMode>k__BackingField; // 0x28
	public const int MotionTakeId = 201222000;
	private int atk; // 0x2C
	private int atkRate; // 0x30
	private int baseEqAtk; // 0x34
	private readonly PlayerActionManagerBase actionManager; // 0x38
	private readonly TakeController takeController; // 0x40
	private readonly BufferEffectManager effectManager; // 0x48
	private bool equipMainKatana; // 0x50
	private bool isUpdateWeapon; // 0x51
	private bool isBattleActive; // 0x52
	private bool isPutUpWeapon; // 0x53
	private bool isFieldLeave; // 0x54
	private IchijhinnokazeAttackAction.ActiveSkill activeSkill; // 0x58

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }
	public override bool IsPutUpWeapon { get; }
	public IchijhinnokazeBuf.AttackMode NowAttackMode { get; set; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x2334184 Offset: 0x2330184 VA: 0x2334184
	public void .ctor(byte lv, PlayerActionManagerBase actionManager) { }

	// RVA: 0x2334254 Offset: 0x2330254 VA: 0x2334254 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233425C Offset: 0x233025C VA: 0x233425C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2334268 Offset: 0x2330268 VA: 0x2334268 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2334284 Offset: 0x2330284 VA: 0x2334284 Slot: 10
	public override bool get_IsPutUpWeapon() { }

	[CompilerGenerated]
	// RVA: 0x233428C Offset: 0x233028C VA: 0x233428C
	public IchijhinnokazeBuf.AttackMode get_NowAttackMode() { }

	[CompilerGenerated]
	// RVA: 0x2334294 Offset: 0x2330294 VA: 0x2334294
	private void set_NowAttackMode(IchijhinnokazeBuf.AttackMode value) { }

	// RVA: 0x233429C Offset: 0x233029C VA: 0x233429C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23342A4 Offset: 0x23302A4 VA: 0x23342A4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233435C Offset: 0x233035C VA: 0x233435C Slot: 11
	public override void Updata() { }

	// RVA: 0x2334930 Offset: 0x2330930 VA: 0x2334930 Slot: 17
	public override void OnLeave() { }

	// RVA: 0x233493C Offset: 0x233093C VA: 0x233493C
	public void BufferEnd() { }

	// RVA: 0x2334A0C Offset: 0x2330A0C VA: 0x2334A0C
	public void UpdateParameter(int firstAttack, int firstAttackRate) { }

	// RVA: 0x2334AC8 Offset: 0x2330AC8 VA: 0x2334AC8
	public void Active(int firstAttack, int firstAttackRate) { }

	// RVA: 0x2334B08 Offset: 0x2330B08 VA: 0x2334B08
	public void Inactive() { }

	// RVA: 0x2334B1C Offset: 0x2330B1C VA: 0x2334B1C
	public void NextAttackMode() { }

	// RVA: 0x2334B38 Offset: 0x2330B38 VA: 0x2334B38
	public void ResetAttackMode() { }

	// RVA: 0x2334B48 Offset: 0x2330B48 VA: 0x2334B48
	public bool CheckActiveSetsunakenran() { }

	// RVA: 0x2334B58 Offset: 0x2330B58 VA: 0x2334B58
	public bool CheckConnectSetsunakenran(IchijhinnokazeAttackAction.ActiveSkill activeSkill) { }

	// RVA: 0x2334BB8 Offset: 0x2330BB8 VA: 0x2334BB8
	public void ResetSetsunakenranSkill() { }

	// RVA: 0x2334BC0 Offset: 0x2330BC0 VA: 0x2334BC0
	public void ActiveSkill(IchijhinnokazeAttackAction.ActiveSkill activeSkill) { }

	// RVA: 0x23345A0 Offset: 0x23305A0 VA: 0x23345A0
	private bool CheckBattleActive() { }

	// RVA: 0x2334798 Offset: 0x2330798 VA: 0x2334798
	private bool CheckPlayMotion() { }

	// RVA: 0x2334628 Offset: 0x2330628 VA: 0x2334628
	private bool CheckPlayLoopMotion() { }

	// RVA: 0x23346E0 Offset: 0x23306E0 VA: 0x23346E0
	public void TakeStop() { }

	// RVA: 0x2334C20 Offset: 0x2330C20 VA: 0x2334C20
	public static float GetSkillRate(byte lv, IchijhinnokazeBuf.AttackMode mode) { }

	// RVA: 0x2334C74 Offset: 0x2330C74 VA: 0x2334C74
	public static float GetNormalAttackSkillRate(PlayerStatusBase status) { }

	// RVA: 0x2334D38 Offset: 0x2330D38 VA: 0x2334D38
	public static int GetConstantDamage(byte lv, IchijhinnokazeBuf.AttackMode mode) { }

	// RVA: 0x2334D54 Offset: 0x2330D54 VA: 0x2334D54
	public static int GetNormalAttackConstantDamage(PlayerStatusBase status) { }

	// RVA: 0x2334DF4 Offset: 0x2330DF4 VA: 0x2334DF4
	public static bool CheckNormalAttackIchijhinnokaze(PlayerStatusBase status, out IchijhinnokazeBuf.AttackMode mode, out byte skillLevel) { }

	// RVA: 0x2334F5C Offset: 0x2330F5C VA: 0x2334F5C
	public static float GetNagiBonus(PlayerStatusBase status) { }

	// RVA: 0x2334F64 Offset: 0x2330F64 VA: 0x2334F64
	public static float GetKariwatashiBonus(PlayerStatusBase status) { }

	// RVA: 0x2334FFC Offset: 0x2330FFC VA: 0x2334FFC
	public static float GetHibariBonus(PlayerStatusBase status) { }

	// RVA: 0x233508C Offset: 0x233108C VA: 0x233508C
	public static float GetIbukiBonus(PlayerStatusBase status) { }

	// RVA: 0x233511C Offset: 0x233111C VA: 0x233511C
	public static float GetArahaeBonus(PlayerStatusBase status) { }
}
