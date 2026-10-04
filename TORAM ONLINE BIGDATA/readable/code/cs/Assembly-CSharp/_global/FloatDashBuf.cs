// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FloatDashBuf : SkillBufferDataBase // TypeDefIndex: 3168
{
	// Fields
	public const int BufferTakeId = 200701010;
	private readonly PlayerActionManagerBase playerAction; // 0x20
	private readonly TakeController takeController; // 0x28
	private readonly BufferEffectManager effectManager; // 0x30
	private readonly int moveSpeed; // 0x38
	private readonly int avoid; // 0x3C
	private readonly int flee; // 0x40
	private bool updateFloatDash; // 0x44
	private bool isBattleActive; // 0x45

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232EA08 Offset: 0x232AA08 VA: 0x232EA08
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x232EAA8 Offset: 0x232AAA8 VA: 0x232EAA8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232EAB0 Offset: 0x232AAB0 VA: 0x232EAB0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232EAB8 Offset: 0x232AAB8 VA: 0x232EAB8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232EAF8 Offset: 0x232AAF8 VA: 0x232EAF8 Slot: 11
	public override void Updata() { }

	// RVA: 0x232EE44 Offset: 0x232AE44 VA: 0x232EE44
	public void BufferEnd() { }

	// RVA: 0x232EF14 Offset: 0x232AF14 VA: 0x232EF14
	private bool CheckFloatDashTake() { }
}
