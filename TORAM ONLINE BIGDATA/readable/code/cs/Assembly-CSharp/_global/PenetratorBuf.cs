// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PenetratorBuf : CountBufferBase // TypeDefIndex: 3267
{
	// Fields
	private readonly bool isBow; // 0x28
	private readonly MobActionManagerBase targetMobAction; // 0x30
	private const int BowEffectTake = 300429003;
	private const int BowgunEffectTake = 300429004;
	private SkillBufferFlag flag; // 0x38
	private bool activeCharge; // 0x3C

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x23410DC Offset: 0x233D0DC VA: 0x23410DC
	public void .ctor(byte lv, bool isBow, MobActionManagerBase mobActionManager) { }

	// RVA: 0x2341264 Offset: 0x233D264 VA: 0x2341264 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x234126C Offset: 0x233D26C VA: 0x234126C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2341274 Offset: 0x233D274 VA: 0x2341274 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2341280 Offset: 0x233D280 VA: 0x2341280 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2341298 Offset: 0x233D298 VA: 0x2341298 Slot: 11
	public override void Updata() { }

	// RVA: 0x2341314 Offset: 0x233D314 VA: 0x2341314 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x23413C0 Offset: 0x233D3C0 VA: 0x23413C0
	public void ActiveCharge() { }

	// RVA: 0x23413CC Offset: 0x233D3CC VA: 0x23413CC
	public void InactiveCharge() { }

	// RVA: 0x23413D4 Offset: 0x233D3D4 VA: 0x23413D4
	public void Avoid() { }

	// RVA: 0x234112C Offset: 0x233D12C VA: 0x234112C
	private void UpdateIntervalTime() { }
}
