// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CharacterCreateManager : MonoBehaviour // TypeDefIndex: 5140
{
	// Fields
	private string[] downloadKeys; // 0x20
	[SerializeField]
	private GameObject characterCreateUI; // 0x28
	[SerializeField]
	private UILoadingBar loading; // 0x30
	[SerializeField]
	private GameObject buttons; // 0x38
	private bool isStarted; // 0x40
	private bool isError; // 0x41
	private int retryCount; // 0x44
	private readonly int maxRetryCount; // 0x48
	private SystemTextManager systemTextManager; // 0x50

	// Methods

	// RVA: 0x25F6CD8 Offset: 0x25F2CD8 VA: 0x25F6CD8
	private void Start() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<Initialize>d__10))]
	// RVA: 0x25F6DE0 Offset: 0x25F2DE0 VA: 0x25F6DE0
	private IEnumerator Initialize() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<StartDownload>d__11))]
	// RVA: 0x25F6E74 Offset: 0x25F2E74 VA: 0x25F6E74
	private IEnumerator StartDownload() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<InitLocalize>d__12))]
	// RVA: 0x25F6F08 Offset: 0x25F2F08 VA: 0x25F6F08
	private IEnumerator InitLocalize() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<InitCharacter>d__13))]
	// RVA: 0x25F6F9C Offset: 0x25F2F9C VA: 0x25F6F9C
	private IEnumerator InitCharacter() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<InitUI>d__14))]
	// RVA: 0x25F7030 Offset: 0x25F3030 VA: 0x25F7030
	private IEnumerator InitUI() { }

	// RVA: 0x25F70C4 Offset: 0x25F30C4 VA: 0x25F70C4
	public void StartBackgroundDownloader() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<showDownloadError>d__16))]
	// RVA: 0x25F7128 Offset: 0x25F3128 VA: 0x25F7128
	private IEnumerator showDownloadError(string errorCode) { }

	// RVA: 0x25F71D8 Offset: 0x25F31D8 VA: 0x25F71D8
	public void OnCacheClear() { }

	[IteratorStateMachine(typeof(CharacterCreateManager.<cacheClear>d__18))]
	// RVA: 0x25F71F8 Offset: 0x25F31F8 VA: 0x25F71F8
	private IEnumerator cacheClear() { }

	// RVA: 0x25F728C Offset: 0x25F328C VA: 0x25F728C
	private void OnAppQuit() { }

	// RVA: 0x25F72FC Offset: 0x25F32FC VA: 0x25F72FC
	public void .ctor() { }
}
