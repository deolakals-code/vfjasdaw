// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGamePhaseTimer : MonoBehaviour // TypeDefIndex: 5698
{
	// Fields
	[SerializeField]
	private UILabel timerLabel; // 0x20
	[SerializeField]
	private UILabel phaseLabel; // 0x28
	[SerializeField]
	private UIGLSpriteSliced timeLimit; // 0x30
	[SerializeField]
	private UIGLSpriteSliced baseBar; // 0x38
	private float timer; // 0x40
	private float maxTime; // 0x44
	private UICardGameBattlePanelManager uiManager; // 0x48
	[CompilerGenerated]
	private bool <IsLock>k__BackingField; // 0x50

	// Properties
	public bool IsLock { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17CA0BC Offset: 0x17C60BC VA: 0x17CA0BC
	public bool get_IsLock() { }

	[CompilerGenerated]
	// RVA: 0x17CA0C4 Offset: 0x17C60C4 VA: 0x17CA0C4
	public void set_IsLock(bool value) { }

	// RVA: 0x17CA0D0 Offset: 0x17C60D0 VA: 0x17CA0D0
	private void Awake() { }

	// RVA: 0x17CA23C Offset: 0x17C623C VA: 0x17CA23C
	private void Update() { }

	// RVA: 0x17C9E88 Offset: 0x17C5E88 VA: 0x17C9E88
	public void Initialize(UICardGameBattlePanelManager manager) { }

	// RVA: 0x17CA2BC Offset: 0x17C62BC VA: 0x17CA2BC
	private void ViewTimer(float seconds) { }

	// RVA: 0x17C9E6C Offset: 0x17C5E6C VA: 0x17C9E6C
	public void SetPhaseLabel(string str) { }

	// RVA: 0x17C9EA8 Offset: 0x17C5EA8 VA: 0x17C9EA8
	public void StartTimer(float time) { }

	// RVA: 0x17CA36C Offset: 0x17C636C VA: 0x17CA36C
	public void .ctor() { }
}
