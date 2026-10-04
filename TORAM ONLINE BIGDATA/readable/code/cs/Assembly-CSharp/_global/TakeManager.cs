// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TakeManager : Singleton<TakeManager> // TypeDefIndex: 4629
{
	// Fields
	[SerializeField]
	private TakeController masterController; // 0x20
	private Dictionary<int, TakeClip> cacheTakeClipList; // 0x28

	// Properties
	public TakeController Controller { get; }

	// Methods

	// RVA: 0x25832DC Offset: 0x257F2DC VA: 0x25832DC
	public TakeController get_Controller() { }

	// RVA: 0x25832E4 Offset: 0x257F2E4 VA: 0x25832E4
	public void TakeClipCacheClear() { }

	// RVA: 0x2583334 Offset: 0x257F334 VA: 0x2583334
	public TakeClip TakeClipLaod(int takeId) { }

	// RVA: 0x25835DC Offset: 0x257F5DC VA: 0x25835DC
	public void CacheTakeModel(int takeId) { }

	// RVA: 0x25835E8 Offset: 0x257F5E8 VA: 0x25835E8
	public void CacheTakeModel(List<int> takeListId) { }

	// RVA: 0x2583340 Offset: 0x257F340 VA: 0x2583340
	private TakeClip TakeClipLaod(int takeId, bool cacheModel, bool updateTag) { }

	// RVA: 0x25837D0 Offset: 0x257F7D0 VA: 0x25837D0
	private bool CacheCheck(TakeEventType type) { }

	[IteratorStateMachine(typeof(TakeManager.<ModelLoad>d__10))]
	// RVA: 0x258373C Offset: 0x257F73C VA: 0x258373C
	private IEnumerator ModelLoad(TakeClip takeClip, bool updateTag) { }

	// RVA: 0x2583820 Offset: 0x257F820 VA: 0x2583820
	public void .ctor() { }
}
