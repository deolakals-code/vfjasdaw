// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BufferEffectManager // TypeDefIndex: 526
{
	// Fields
	private Dictionary<BufferEffectManager.BufferType, List<BufferEffectManager.BufferEffectData>> manager; // 0x10
	private Dictionary<int, Action> notLoadStopTake; // 0x18
	private readonly GameObject baseObject; // 0x20
	private TakeController controller; // 0x28

	// Properties
	private TakeController takeController { get; }

	// Methods

	// RVA: 0x182C854 Offset: 0x1828854 VA: 0x182C854
	private TakeController get_takeController() { }

	// RVA: 0x182C8F4 Offset: 0x18288F4 VA: 0x182C8F4
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x182CAC0 Offset: 0x1828AC0 VA: 0x182CAC0
	public void AbnormalEffectPlay(AbnormalType type, float lenght) { }

	// RVA: 0x182CF48 Offset: 0x1828F48 VA: 0x182CF48
	public int SkillBufferEffectPlay(SkillBufferDataBase buffer, bool sameCheck = True) { }

	// RVA: 0x182D378 Offset: 0x1829378 VA: 0x182D378
	public int SkillBufferEffectReplay(SkillBufferDataBase buffer, bool delete) { }

	// RVA: 0x182D790 Offset: 0x1829790 VA: 0x182D790
	public int MobDebuffEffectPlay(MobBuffBase mobBuff, float mobSize) { }

	// RVA: 0x182DC30 Offset: 0x1829C30 VA: 0x182DC30
	public bool AbnormalEffectStop(AbnormalType type) { }

	// RVA: 0x182DDA8 Offset: 0x1829DA8 VA: 0x182DDA8
	public bool SkillBufferEffectStop(SkillId skillId) { }

	// RVA: 0x182DFD4 Offset: 0x1829FD4 VA: 0x182DFD4
	public bool MobDebuffEffectStop(MobBuffId mobBuffId) { }

	// RVA: 0x182E000 Offset: 0x182A000 VA: 0x182E000
	public bool SkillBufferEffectStop(int takeUid) { }

	// RVA: 0x182DDB4 Offset: 0x1829DB4 VA: 0x182DDB4
	private bool BufferEffectStop(BufferEffectManager.BufferType type, SkillId skillId) { }

	// RVA: 0x182E00C Offset: 0x182A00C VA: 0x182E00C
	private bool BufferEffectStop(BufferEffectManager.BufferType type, int takeUid) { }

	// RVA: 0x182DC3C Offset: 0x1829C3C VA: 0x182DC3C
	private bool BufferEffectStop(BufferEffectManager.BufferType type, AbnormalType abnormalType) { }

	// RVA: 0x182E190 Offset: 0x182A190 VA: 0x182E190
	public void SkillBufferEffectNext(int takeUid) { }

	// RVA: 0x182E2E8 Offset: 0x182A2E8 VA: 0x182E2E8
	public void SkillBufferEffectNext(SkillId skillId) { }

	// RVA: 0x182E724 Offset: 0x182A724 VA: 0x182E724
	public void AbnormalEffectAllStop() { }

	// RVA: 0x182ECA4 Offset: 0x182ACA4 VA: 0x182ECA4
	public void SkillBufferEffectAllStop() { }

	// RVA: 0x182ECAC Offset: 0x182ACAC VA: 0x182ECAC
	public void EventCircleAllStop() { }

	// RVA: 0x182ECB4 Offset: 0x182ACB4 VA: 0x182ECB4
	public void MobDebuffEffectAllStop() { }

	// RVA: 0x182E72C Offset: 0x182A72C VA: 0x182E72C
	private void BufferEffectStop(BufferEffectManager.BufferType type) { }

	// RVA: 0x182EF5C Offset: 0x182AF5C VA: 0x182EF5C
	public void OnAbnormalEffectEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x182F3F0 Offset: 0x182B3F0 VA: 0x182F3F0
	public void OnSkillBufferEffectEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x182F70C Offset: 0x182B70C VA: 0x182F70C
	public void OnMobDebuffEffectEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x182F0DC Offset: 0x182B0DC VA: 0x182F0DC
	private void BufferEffectTakeDelete(BufferEffectManager.BufferType type, int takePlayerUid) { }

	// RVA: 0x182F238 Offset: 0x182B238 VA: 0x182F238
	private void EffectTakeLoad(BufferEffectManager.BufferType type, int takePlayerUid) { }

	// RVA: 0x182F89C Offset: 0x182B89C VA: 0x182F89C
	public int AddEventCircle(int id, int color, float size) { }

	// RVA: 0x182FCFC Offset: 0x182BCFC VA: 0x182FCFC
	public void RemoveEventCircle(int id) { }

	// RVA: 0x182FF04 Offset: 0x182BF04 VA: 0x182FF04
	private void OnEventCircleEffectEvent(int takeUid, TakeEventType eventType, int param) { }
}
