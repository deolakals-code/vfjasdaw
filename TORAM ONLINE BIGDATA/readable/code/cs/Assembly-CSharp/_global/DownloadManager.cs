// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DownloadManager : Singleton<DownloadManager> // TypeDefIndex: 5482
{
	// Fields
	[SerializeField]
	private float timeout; // 0x20
	[SerializeField]
	private int maxRetry; // 0x24
	private readonly float retryWait; // 0x28
	private int concurrentCount; // 0x2C
	[SerializeField]
	private int maxConcurrent; // 0x30
	[SerializeField]
	private int minMaxConcurrent; // 0x34
	[SerializeField]
	private int failureBackoffThreshold; // 0x38
	private int recentFailures; // 0x3C
	private bool isCancel; // 0x40
	[CompilerGenerated]
	private bool <IsCacheLoading>k__BackingField; // 0x41
	[CompilerGenerated]
	private float <Progress>k__BackingField; // 0x44
	private bool isQuery; // 0x48

	// Properties
	public bool IsLoading { get; }
	public int MaxConcurrent { get; set; }
	public int ConcurrentCount { get; }
	public bool IsCacheLoading { get; set; }
	public float Progress { get; set; }

	// Methods

	// RVA: 0x1774064 Offset: 0x1770064 VA: 0x1774064
	public bool get_IsLoading() { }

	// RVA: 0x1774074 Offset: 0x1770074 VA: 0x1774074
	public int get_MaxConcurrent() { }

	// RVA: 0x177407C Offset: 0x177007C VA: 0x177407C
	public void set_MaxConcurrent(int value) { }

	// RVA: 0x1774098 Offset: 0x1770098 VA: 0x1774098
	public int get_ConcurrentCount() { }

	// RVA: 0x17740A0 Offset: 0x17700A0 VA: 0x17740A0
	private void onDownloadFailed() { }

	// RVA: 0x17740E0 Offset: 0x17700E0 VA: 0x17740E0
	private void onDownloadSucceeded() { }

	[CompilerGenerated]
	// RVA: 0x17740F4 Offset: 0x17700F4 VA: 0x17740F4
	public bool get_IsCacheLoading() { }

	[CompilerGenerated]
	// RVA: 0x17740FC Offset: 0x17700FC VA: 0x17740FC
	private void set_IsCacheLoading(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1774108 Offset: 0x1770108 VA: 0x1774108
	public float get_Progress() { }

	[CompilerGenerated]
	// RVA: 0x1774110 Offset: 0x1770110 VA: 0x1774110
	private void set_Progress(float value) { }

	// RVA: 0x1774118 Offset: 0x1770118 VA: 0x1774118
	public void Clear() { }

	// RVA: 0x1770C40 Offset: 0x176CC40 VA: 0x1770C40
	public void Reset() { }

	// RVA: 0x1774124 Offset: 0x1770124 VA: 0x1774124
	public void HitBreakCacheErrData() { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadBinary>d__31))]
	// RVA: 0x176E3A8 Offset: 0x176A3A8 VA: 0x176E3A8
	public IEnumerator DownloadBinary(string file, DownloadManager.DownloadResult<byte[]> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadText>d__32))]
	// RVA: 0x176D61C Offset: 0x176961C VA: 0x176D61C
	public IEnumerator DownloadText(string file, DownloadManager.DownloadResult<string> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadCacheTexture>d__33))]
	// RVA: 0x1774178 Offset: 0x1770178 VA: 0x1774178
	public IEnumerator DownloadCacheTexture(string path, string cacheFolder, string file, DownloadManager.DownloadResult<Texture2D> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadCacheAssetBundle>d__34))]
	// RVA: 0x176EAC4 Offset: 0x176AAC4 VA: 0x176EAC4
	public IEnumerator DownloadCacheAssetBundle(string file, int ver, DownloadManager.DownloadResult<AssetBundle> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadToLocalCacheAssetBundle>d__35))]
	// RVA: 0x1770464 Offset: 0x176C464 VA: 0x1770464
	public IEnumerator DownloadToLocalCacheAssetBundle(string file, int ver, DownloadManager.DownloadResult<bool> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<DownloadAssetBundle>d__36))]
	// RVA: 0x17742BC Offset: 0x17702BC VA: 0x17742BC
	public IEnumerator DownloadAssetBundle(string file, DownloadManager.DownloadResult<AssetBundle> result) { }

	[IteratorStateMachine(typeof(DownloadManager.<downloadCheckTimeOut>d__37))]
	// RVA: 0x1774380 Offset: 0x1770380 VA: 0x1774380
	private IEnumerator downloadCheckTimeOut(WWW www, float timeout, Action<string> timeoutCallback) { }

	[IteratorStateMachine(typeof(DownloadManager.<downloadCheckTimeOut>d__38))]
	// RVA: 0x1774454 Offset: 0x1770454 VA: 0x1774454
	private IEnumerator downloadCheckTimeOut(UnityWebRequest webRequest, float timeout, Action<string> timeoutCallback) { }

	// RVA: 0x1774528 Offset: 0x1770528 VA: 0x1774528
	public void .ctor() { }
}
