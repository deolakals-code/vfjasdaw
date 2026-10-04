// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SaberAuraBuf : CountBufferBase // TypeDefIndex: 3293
{
	// Fields
	private int strengthenInterval; // 0x28
	private int payHp; // 0x2C
	private int increase; // 0x30
	private int moveSpeed; // 0x34
	private int hitUp; // 0x38
	private int critical; // 0x3C
	private int aspdRate; // 0x40
	private int atkMpHeal; // 0x44
	private float timer; // 0x48
	private float inquireTime; // 0x4C
	private bool bufferEnd; // 0x50
	private bool inquire; // 0x51
	private PlayerDataManager player; // 0x58
	private const int bufferTakeId = 201000002;
	private bool isBattleActive; // 0x60

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public bool IsBufferEnd { get; }
	public override int BufEffectTakeId { get; }
	public override SkillBufferFlag Flag { get; }
	public override bool IsPutUpWeapon { get; }

	// Methods

	// RVA: 0x2343924 Offset: 0x233F924 VA: 0x2343924 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x234392C Offset: 0x233F92C VA: 0x234392C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2343934 Offset: 0x233F934 VA: 0x2343934
	public bool get_IsBufferEnd() { }

	// RVA: 0x234393C Offset: 0x233F93C VA: 0x234393C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2343948 Offset: 0x233F948 VA: 0x2343948 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2343968 Offset: 0x233F968 VA: 0x2343968 Slot: 10
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2343A28 Offset: 0x233FA28 VA: 0x2343A28
	public void .ctor(byte lv) { }

	// RVA: 0x2343C18 Offset: 0x233FC18 VA: 0x2343C18 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2343CA8 Offset: 0x233FCA8 VA: 0x2343CA8 Slot: 11
	public override void Updata() { }

	// RVA: 0x2344270 Offset: 0x2340270 VA: 0x2344270
	public void Inquire() { }

	// RVA: 0x2344168 Offset: 0x2340168 VA: 0x2344168
	public void BufferEnd() { }

	// RVA: 0x234429C Offset: 0x234029C VA: 0x234429C Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x23439DC Offset: 0x233F9DC VA: 0x23439DC
	private bool CheckTake() { }

	// RVA: 0x2344388 Offset: 0x2340388 VA: 0x2344388 Slot: 18
	public override bool CheckUnableEquipChange() { }
}
