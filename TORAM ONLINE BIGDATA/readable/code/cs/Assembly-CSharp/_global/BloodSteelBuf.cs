// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BloodSteelBuf : SkillBufferDataBase // TypeDefIndex: 3087
{
	// Fields
	private PlayerActionManagerBase playerAction; // 0x20
	private GameObject target; // 0x28
	private EnemyMobActionManagerBase mobAction; // 0x30
	private bool isEffectiveRange; // 0x38
	private BloodSteelBuf.LineEffect effect; // 0x40
	private float bufRange; // 0x48

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2320470 Offset: 0x231C470 VA: 0x2320470 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2320478 Offset: 0x231C478 VA: 0x2320478 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2320480 Offset: 0x231C480 VA: 0x2320480 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x232048C Offset: 0x231C48C VA: 0x232048C
	public void .ctor(byte lv, PlayerActionManagerBase playerAction, GameObject target) { }

	// RVA: 0x2320678 Offset: 0x231C678 VA: 0x2320678 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2320680 Offset: 0x231C680 VA: 0x2320680 Slot: 11
	public override void Updata() { }

	// RVA: 0x23207F0 Offset: 0x231C7F0 VA: 0x23207F0 Slot: 15
	public override void OnCall(int takeUid, int param) { }

	// RVA: 0x23206CC Offset: 0x231C6CC VA: 0x23206CC
	public void OnEnd() { }

	// RVA: 0x2320B50 Offset: 0x231CB50 VA: 0x2320B50
	public void ChangeHyperMode(GameObject target) { }

	// RVA: 0x2320570 Offset: 0x231C570 VA: 0x2320570
	private bool CheckLineConnect() { }

	// RVA: 0x2320CD8 Offset: 0x231CCD8 VA: 0x2320CD8 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }
}
