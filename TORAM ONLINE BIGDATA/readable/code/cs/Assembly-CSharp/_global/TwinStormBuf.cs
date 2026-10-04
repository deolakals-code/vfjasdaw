// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TwinStormBuf : CountBufferBase // TypeDefIndex: 3339
{
	// Fields
	private int BufferTakeId; // 0x28
	private readonly PlayerActionManagerBase actionManager; // 0x30
	private readonly TakeController takeController; // 0x38
	private readonly BufferEffectManager effectManager; // 0x40
	private bool isTwinStorm; // 0x48
	private int normalAttackRate; // 0x4C
	private int normalAttackConstant; // 0x50
	private int stable; // 0x54
	private int effectiveStable; // 0x58
	private int aspd; // 0x5C
	private int lastDamageRate; // 0x60
	private int effectiveLastDamageRate; // 0x64
	private int moveSpeed; // 0x68
	private bool isBattleActive; // 0x6C
	private bool isUpdateWeapon; // 0x6D
	private short updateNextAttackCount; // 0x6E
	private short maxUpdateNextAttackCount; // 0x70

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2348784 Offset: 0x2344784 VA: 0x2348784
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2348A80 Offset: 0x2344A80 VA: 0x2348A80 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2348A88 Offset: 0x2344A88 VA: 0x2348A88 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2348AA0 Offset: 0x2344AA0 VA: 0x2348AA0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2348AA8 Offset: 0x2344AA8 VA: 0x2348AA8 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2348AB4 Offset: 0x2344AB4 VA: 0x2348AB4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2348B68 Offset: 0x2344B68 VA: 0x2348B68 Slot: 11
	public override void Updata() { }

	// RVA: 0x234911C Offset: 0x234511C VA: 0x234911C Slot: 23
	public override void Next() { }

	// RVA: 0x2349190 Offset: 0x2345190 VA: 0x2349190
	public void BufferEnd() { }

	// RVA: 0x2349064 Offset: 0x2345064 VA: 0x2349064
	public void TakeStop() { }

	// RVA: 0x2349254 Offset: 0x2345254 VA: 0x2349254
	public void ChangeTwinStorm(bool active) { }

	// RVA: 0x2349274 Offset: 0x2345274 VA: 0x2349274
	public bool CheckTwinStorm() { }

	// RVA: 0x2348F20 Offset: 0x2344F20 VA: 0x2348F20
	private bool IsBattleActive() { }

	// RVA: 0x234927C Offset: 0x234527C VA: 0x234927C
	public void UseConquester() { }

	// RVA: 0x2349290 Offset: 0x2345290 VA: 0x2349290
	public void UseTwinStorm() { }

	// RVA: 0x23492AC Offset: 0x23452AC VA: 0x23492AC
	public void EffectiveAbnormal(AbnormalType abnormal) { }

	// RVA: 0x2348FB0 Offset: 0x2344FB0 VA: 0x2348FB0
	private bool CheckTake() { }

	// RVA: 0x2348DB8 Offset: 0x2344DB8 VA: 0x2348DB8
	private bool CheckTiwnTake() { }

	// RVA: 0x2348878 Offset: 0x2344878 VA: 0x2348878
	private void UpdateParam() { }

	// RVA: 0x2349330 Offset: 0x2345330 VA: 0x2349330 Slot: 19
	public override bool CheckChangeEquipRemove() { }

	// RVA: 0x234938C Offset: 0x234538C VA: 0x234938C
	public void ValidDamageUp() { }

	// RVA: 0x2349398 Offset: 0x2345398 VA: 0x2349398
	public void InvalidDamageUp() { }

	// RVA: 0x23493A0 Offset: 0x23453A0 VA: 0x23493A0
	public void ValidStable() { }

	// RVA: 0x23493AC Offset: 0x23453AC VA: 0x23493AC
	public void InvalidStable() { }
}
