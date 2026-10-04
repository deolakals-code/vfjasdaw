// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StageLoginDownloader : MonoBehaviour // TypeDefIndex: 5186
{
	// Fields
	[SerializeField]
	private UILoadingBar loading; // 0x20
	[SerializeField]
	private GameObject[] onErrorButtons; // 0x28
	private bool isError; // 0x30
	private int retryCount; // 0x34
	private readonly int maxRetryCount; // 0x38
	private LocalizeManager localizeManager; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private ResourceManager resourceManager; // 0x50
	private GameManager gameManager; // 0x58
	private string[] downloadKeys; // 0x60
	private string localizeCode; // 0x68

	// Methods

	// RVA: 0x2601B0C Offset: 0x25FDB0C VA: 0x2601B0C
	private void Awake() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<Start>d__12))]
	// RVA: 0x2601B70 Offset: 0x25FDB70 VA: 0x2601B70
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<StartDownload>d__13))]
	// RVA: 0x2601C04 Offset: 0x25FDC04 VA: 0x2601C04
	private IEnumerator StartDownload() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<initResourceDownload>d__14))]
	// RVA: 0x2601C98 Offset: 0x25FDC98 VA: 0x2601C98
	private IEnumerator initResourceDownload() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<initBinaryData>d__15))]
	// RVA: 0x2601D0C Offset: 0x25FDD0C VA: 0x2601D0C
	private IEnumerator initBinaryData() { }

	// RVA: 0x2601DA0 Offset: 0x25FDDA0 VA: 0x2601DA0
	private byte[] GetAssetDecryptData(TextAsset asset, int key) { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<initLocalizeData>d__17))]
	// RVA: 0x2601DE0 Offset: 0x25FDDE0 VA: 0x2601DE0
	private IEnumerator initLocalizeData() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<initCacheData>d__18))]
	// RVA: 0x2601E54 Offset: 0x25FDE54 VA: 0x2601E54
	private IEnumerator initCacheData() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<initOrbShopNewsData>d__19))]
	// RVA: 0x2601EC8 Offset: 0x25FDEC8 VA: 0x2601EC8
	private IEnumerator initOrbShopNewsData() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<showDownloadError>d__20))]
	// RVA: 0x2601F3C Offset: 0x25FDF3C VA: 0x2601F3C
	private IEnumerator showDownloadError(string errorCode) { }

	// RVA: 0x2601FCC Offset: 0x25FDFCC VA: 0x2601FCC
	public void OnCacheClear() { }

	[IteratorStateMachine(typeof(StageLoginDownloader.<cacheClear>d__22))]
	// RVA: 0x2601FEC Offset: 0x25FDFEC VA: 0x2601FEC
	private IEnumerator cacheClear() { }

	// RVA: 0x2602080 Offset: 0x25FE080 VA: 0x2602080
	private void OnAppQuit() { }

	// RVA: 0x26020DC Offset: 0x25FE0DC VA: 0x26020DC
	public void .ctor() { }
}
