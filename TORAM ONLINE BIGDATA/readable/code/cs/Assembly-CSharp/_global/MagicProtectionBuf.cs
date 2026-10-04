// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicProtectionBuf : CountBufferBase // TypeDefIndex: 3238
{
	// Fields
	private const int OutsideRingEffect = 300324003;
	private const int InsideRingEffect = 300324004;
	private readonly Transform actor; // 0x28
	private readonly BufferEffectManager bufferEffect; // 0x30
	private SkillBufferFlag flag; // 0x38
	private CountBufferBase.CountType countViewType; // 0x3C
	private Vector3 placePos; // 0x40
	private bool effective; // 0x4C
	private int barrierHp; // 0x50
	private int maxBarrierHp; // 0x54
	private int motionSpeed; // 0x58
	private int damageCut; // 0x5C
	private bool isBreak; // 0x60
	private bool isMaximuyzerShortenedActivation; // 0x61
	private float size; // 0x64
	private bool isFirstSend; // 0x68
	private int mpRecoveryStock; // 0x6C
	private int effectTakeId; // 0x70
	private int outsideEffectTakeUid; // 0x74
	private int insideEffectTakeUid; // 0x78

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x233AE60 Offset: 0x2336E60 VA: 0x233AE60 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233AE68 Offset: 0x2336E68 VA: 0x233AE68 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233AE70 Offset: 0x2336E70 VA: 0x233AE70 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233AE78 Offset: 0x2336E78 VA: 0x233AE78 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x233AE80 Offset: 0x2336E80 VA: 0x233AE80
	public void .ctor(byte lv, PlayerStatusBase status, Transform actor, BufferEffectManager bufferEffectManager) { }

	// RVA: 0x233B368 Offset: 0x2337368 VA: 0x233B368 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233B3B4 Offset: 0x23373B4 VA: 0x233B3B4 Slot: 11
	public override void Updata() { }

	// RVA: 0x233B678 Offset: 0x2337678 VA: 0x233B678 Slot: 23
	public override void Next() { }

	// RVA: 0x233B67C Offset: 0x233767C VA: 0x233B67C Slot: 24
	public override void NextSkip(int count) { }

	// RVA: 0x233B680 Offset: 0x2337680 VA: 0x233B680 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x233B8AC Offset: 0x23378AC VA: 0x233B8AC Slot: 16
	public override bool CheckTakeSkip(int takeUid, int param) { }

	// RVA: 0x233B8B4 Offset: 0x23378B4 VA: 0x233B8B4 Slot: 15
	public override void OnCall(int takeUid, int param) { }

	// RVA: 0x233B8BC Offset: 0x23378BC VA: 0x233B8BC
	public int DamageTransfer(int damage, bool longRange, out int transferValue) { }

	// RVA: 0x233B974 Offset: 0x2337974 VA: 0x233B974
	public void Reinstallation(Vector3 placePos) { }

	// RVA: 0x233B9D4 Offset: 0x23379D4 VA: 0x233B9D4
	public void KadarElexioDamage(int barrierHp) { }

	// RVA: 0x233B648 Offset: 0x2337648 VA: 0x233B648
	public void Active() { }

	// RVA: 0x233B668 Offset: 0x2337668 VA: 0x233B668
	public void Inactive() { }

	// RVA: 0x233B9DC Offset: 0x23379DC VA: 0x233B9DC
	public bool CheckActive() { }

	// RVA: 0x233B9E4 Offset: 0x23379E4 VA: 0x233B9E4
	public void ActiveNextMaximuyzershortening() { }

	// RVA: 0x233B9F0 Offset: 0x23379F0 VA: 0x233B9F0
	public void InactiveNextMaximuyzershortening() { }

	// RVA: 0x233B9F8 Offset: 0x23379F8 VA: 0x233B9F8
	public bool CheckNextMaximuyzershortening() { }

	// RVA: 0x233BA00 Offset: 0x2337A00 VA: 0x233BA00
	public bool CheckBreak() { }

	// RVA: 0x233BA08 Offset: 0x2337A08 VA: 0x233BA08
	public void BarrierHeal(int mpRecovery) { }

	// RVA: 0x233BA88 Offset: 0x2337A88 VA: 0x233BA88
	public void PlayEffect() { }

	// RVA: 0x233BB00 Offset: 0x2337B00 VA: 0x233BB00
	private void Break() { }

	// RVA: 0x233B5E4 Offset: 0x23375E4 VA: 0x233B5E4
	private bool CheckInArea() { }

	// RVA: 0x233B18C Offset: 0x233718C VA: 0x233B18C
	private void UpdateCount() { }

	// RVA: 0x233B930 Offset: 0x2337930 VA: 0x233B930
	private void CheckTransferDamage(ref int transferValue) { }
}
