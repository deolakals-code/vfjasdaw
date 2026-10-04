// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ManaCrystalBuf : SkillBufferDataBase // TypeDefIndex: 3248
{
	// Fields
	public const float SIZE = 2;
	private const int TakeId = 300315000;
	private readonly float range; // 0x20
	private PlayerDataManager player; // 0x28
	private Dictionary<int, ManaCrystalBuf.Invoker> invokers; // 0x30
	private ManaCrystalBuf.Invoker currentInvoker; // 0x38

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x233C048 Offset: 0x2338048 VA: 0x233C048 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233C050 Offset: 0x2338050 VA: 0x233C050
	public void .ctor(byte lv) { }

	// RVA: 0x233C108 Offset: 0x2338108 VA: 0x233C108 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233C17C Offset: 0x233817C VA: 0x233C17C Slot: 11
	public override void Updata() { }

	// RVA: 0x233CCA0 Offset: 0x2338CA0 VA: 0x233CCA0 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x233CE2C Offset: 0x2338E2C VA: 0x233CE2C Slot: 15
	public override void OnCall(int takeUid, int param) { }

	// RVA: 0x233D018 Offset: 0x2339018 VA: 0x233D018
	public void TakenManaCrystal(int otherArchetypeId, out int invoker) { }

	// RVA: 0x233D0D8 Offset: 0x23390D8 VA: 0x233D0D8
	public int GetBufferEffectTakeId() { }

	// RVA: 0x233D0E4 Offset: 0x23390E4 VA: 0x233D0E4
	public void Registration(int archetypeId, Vector3 effectPos, float rotation, bool hit) { }

	// RVA: 0x233D224 Offset: 0x2339224 VA: 0x233D224
	public void ReRegistration(int archetypeId, Vector3 effectPos, float rotation, bool hit) { }

	// RVA: 0x233D36C Offset: 0x233936C VA: 0x233D36C
	public void RemoveOverPlace(int archetypeId) { }

	// RVA: 0x233D284 Offset: 0x2339284 VA: 0x233D284
	public void Remove(int archetypeId) { }

	// RVA: 0x233D9A0 Offset: 0x23399A0 VA: 0x233D9A0
	public void Clear() { }

	// RVA: 0x233DB60 Offset: 0x2339B60 VA: 0x233DB60
	public bool StartCrystalLaser(out Vector3 pos) { }

	// RVA: 0x233DC68 Offset: 0x2339C68 VA: 0x233DC68
	public void HitCrystalLaser() { }

	// RVA: 0x233DE40 Offset: 0x2339E40 VA: 0x233DE40
	public Vector3 GetCrystalPos(int archetypeId) { }

	// RVA: 0x233D394 Offset: 0x2339394 VA: 0x233D394
	private void SendRemoveCrystal(int archetypeId) { }

	[CompilerGenerated]
	// RVA: 0x233DF14 Offset: 0x2339F14 VA: 0x233DF14
	private bool <Updata>b__11_0(SkillActionBase s) { }

	[CompilerGenerated]
	// RVA: 0x233DF64 Offset: 0x2339F64 VA: 0x233DF64
	private bool <HitCrystalLaser>b__22_0(SkillActionBase s) { }
}
