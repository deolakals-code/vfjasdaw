// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AvatarRenameManager : MonoBehaviour // TypeDefIndex: 5126
{
	// Fields
	[SerializeField]
	private GameObject uiAvatarRename; // 0x20
	[SerializeField]
	private UILoadingBar loadingBar; // 0x28
	private string[] downloadKeys; // 0x30
	private SystemTextManager systemTextManager; // 0x38
	private bool isError; // 0x40
	private bool isStarted; // 0x41

	// Methods

	// RVA: 0x25F5B7C Offset: 0x25F1B7C VA: 0x25F5B7C
	private void Start() { }

	// RVA: 0x25F5CF0 Offset: 0x25F1CF0 VA: 0x25F5CF0
	private void Update() { }

	// RVA: 0x25F5D50 Offset: 0x25F1D50 VA: 0x25F5D50
	public void StartBackgroundDownloader() { }

	[IteratorStateMachine(typeof(AvatarRenameManager.<Initialize>d__9))]
	// RVA: 0x25F5C84 Offset: 0x25F1C84 VA: 0x25F5C84
	private IEnumerator Initialize() { }

	[IteratorStateMachine(typeof(AvatarRenameManager.<StartDownload>d__10))]
	// RVA: 0x25F5DDC Offset: 0x25F1DDC VA: 0x25F5DDC
	private IEnumerator StartDownload() { }

	[IteratorStateMachine(typeof(AvatarRenameManager.<InitLocalize>d__11))]
	// RVA: 0x25F5E70 Offset: 0x25F1E70 VA: 0x25F5E70
	private IEnumerator InitLocalize() { }

	[IteratorStateMachine(typeof(AvatarRenameManager.<InitUI>d__12))]
	// RVA: 0x25F5F04 Offset: 0x25F1F04 VA: 0x25F5F04
	private IEnumerator InitUI() { }

	// RVA: 0x25F5F98 Offset: 0x25F1F98 VA: 0x25F5F98
	public void .ctor() { }
}
