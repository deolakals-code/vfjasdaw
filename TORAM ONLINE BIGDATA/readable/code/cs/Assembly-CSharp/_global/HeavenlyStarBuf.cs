// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HeavenlyStarBuf : CountBufferBase // TypeDefIndex: 3191
{
	// Fields
	private bool isExpDefFluctuate; // 0x28
	private int prevSkillId; // 0x2C

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2333128 Offset: 0x232F128 VA: 0x2333128 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2333130 Offset: 0x232F130 VA: 0x2333130 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2333138 Offset: 0x232F138 VA: 0x2333138 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2333150 Offset: 0x232F150 VA: 0x2333150
	public void .ctor(byte lv) { }

	// RVA: 0x2333180 Offset: 0x232F180 VA: 0x2333180 Slot: 11
	public override void Updata() { }

	// RVA: 0x23331D4 Offset: 0x232F1D4 VA: 0x23331D4
	public void Reset() { }

	// RVA: 0x23331E8 Offset: 0x232F1E8 VA: 0x23331E8
	public void IllusionarySceneReset(PlayerStatusBase status, int count, bool illusionarySceneParry) { }

	// RVA: 0x233332C Offset: 0x232F32C VA: 0x233332C
	public void SetAttackSkillId(int skillId) { }

	// RVA: 0x2333350 Offset: 0x232F350 VA: 0x2333350
	public bool CheckExpDefFluctuate() { }
}
