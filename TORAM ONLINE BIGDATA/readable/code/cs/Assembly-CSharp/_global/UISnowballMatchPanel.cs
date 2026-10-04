// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballMatchPanel : MonoBehaviour // TypeDefIndex: 6022
{
	// Fields
	[SerializeField]
	private GameObject attentionObj; // 0x20
	[SerializeField]
	private UIImageButton readyButton; // 0x28
	[SerializeField]
	private UILabel readyButtonLabel; // 0x30
	[SerializeField]
	private GameObject matchObj; // 0x38
	[SerializeField]
	private UILabel matchTimeLabel; // 0x40
	[CompilerGenerated]
	private bool <IsStartWait>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsStartTimer>k__BackingField; // 0x49
	private UIIruna2Anchor anchor; // 0x50
	private UISprite attentionIcon; // 0x58
	private UILabel attentionLabel; // 0x60
	private Action readyAction; // 0x68
	private float configuredTime; // 0x70
	private float oldTime; // 0x74
	private float startTime; // 0x78
	private SystemTextManager systemTextManager; // 0x80

	// Properties
	public bool IsStartWait { get; set; }
	public bool IsStartTimer { get; set; }
	public bool IsMatchButtonEnable { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x186D114 Offset: 0x1869114 VA: 0x186D114
	public bool get_IsStartWait() { }

	[CompilerGenerated]
	// RVA: 0x186D11C Offset: 0x186911C VA: 0x186D11C
	private void set_IsStartWait(bool value) { }

	[CompilerGenerated]
	// RVA: 0x186D128 Offset: 0x1869128 VA: 0x186D128
	public bool get_IsStartTimer() { }

	[CompilerGenerated]
	// RVA: 0x186D130 Offset: 0x1869130 VA: 0x186D130
	private void set_IsStartTimer(bool value) { }

	// RVA: 0x186D13C Offset: 0x186913C VA: 0x186D13C
	public bool get_IsMatchButtonEnable() { }

	// RVA: 0x186D158 Offset: 0x1869158 VA: 0x186D158
	private void Start() { }

	// RVA: 0x186D240 Offset: 0x1869240 VA: 0x186D240
	private void Update() { }

	// RVA: 0x1869080 Offset: 0x1865080 VA: 0x1869080
	public void Initalize(Action readyAction) { }

	// RVA: 0x18678B8 Offset: 0x18638B8 VA: 0x18678B8
	public void SetEnable(bool isEnable) { }

	// RVA: 0x186A704 Offset: 0x1866704 VA: 0x186A704
	public void StartMatchingTimer() { }

	// RVA: 0x186D56C Offset: 0x186956C VA: 0x186D56C
	public void StopMatchingTimer() { }

	// RVA: 0x186A85C Offset: 0x186685C VA: 0x186A85C
	public void EndMatchingTimer() { }

	// RVA: 0x186D314 Offset: 0x1869314 VA: 0x186D314
	public void ResetReady() { }

	// RVA: 0x186A5E4 Offset: 0x18665E4 VA: 0x186A5E4
	public void UpdateButton(bool isStartWait) { }

	// RVA: 0x186D42C Offset: 0x186942C VA: 0x186D42C
	private void SetAttentionText(string spriteName, string text) { }

	// RVA: 0x186D574 Offset: 0x1869574 VA: 0x186D574
	public void OnReady() { }

	[IteratorStateMachine(typeof(UISnowballMatchPanel.<DelayReadyButtonEnable>d__34))]
	// RVA: 0x186D6FC Offset: 0x18696FC VA: 0x186D6FC
	private IEnumerator DelayReadyButtonEnable(bool isEnable) { }

	// RVA: 0x186D7A4 Offset: 0x18697A4 VA: 0x186D7A4
	public void .ctor() { }
}
