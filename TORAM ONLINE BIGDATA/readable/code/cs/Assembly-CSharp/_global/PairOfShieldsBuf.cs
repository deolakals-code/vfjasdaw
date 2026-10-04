// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PairOfShieldsBuf : SkillBufferDataBase // TypeDefIndex: 3263
{
	// Fields
	public const int BufferTakeId = 202092000;
	private readonly PlayerActionManagerBase playerAction; // 0x20
	private readonly PlayerStatusBase status; // 0x28
	private readonly TakeController takeController; // 0x30
	private readonly BufferEffectManager effectManager; // 0x38
	private int normalAttackRate; // 0x40
	private int aspdRate; // 0x44
	private int hit; // 0x48
	private bool updateShield; // 0x4C
	private bool isBattleActive; // 0x4D

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x23404E0 Offset: 0x233C4E0 VA: 0x23404E0
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x234068C Offset: 0x233C68C VA: 0x234068C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2340694 Offset: 0x233C694 VA: 0x2340694 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23406A0 Offset: 0x233C6A0 VA: 0x23406A0 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x23406AC Offset: 0x233C6AC VA: 0x23406AC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23406EC Offset: 0x233C6EC VA: 0x23406EC Slot: 11
	public override void Updata() { }

	// RVA: 0x23409E0 Offset: 0x233C9E0 VA: 0x23409E0
	public void BufferEnd() { }

	// RVA: 0x2340B88 Offset: 0x233CB88 VA: 0x2340B88
	public void TakeStop() { }

	// RVA: 0x2340AAC Offset: 0x233CAAC VA: 0x2340AAC
	private bool CheckPairOfShieldsTake() { }
}
