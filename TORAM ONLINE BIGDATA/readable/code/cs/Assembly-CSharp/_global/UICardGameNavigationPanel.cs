// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameNavigationPanel : MonoBehaviour // TypeDefIndex: 5697
{
	// Fields
	[SerializeField]
	private UICardGamePlayerSpina playerSpina; // 0x20
	[SerializeField]
	private UICardGamePhaseTimer phaseTimer; // 0x28
	[SerializeField]
	private GameObject phaseEndButton; // 0x30
	private UIImageButton phaseEndImageButton; // 0x38
	[SerializeField]
	private GameObject marketButton; // 0x40
	private UIImageButton marketImageButton; // 0x48
	[SerializeField]
	private GameObject battleButton; // 0x50
	private UIImageButton battleImageButton; // 0x58
	private IUICardGameNavigationPanelClick clickManager; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	[CompilerGenerated]
	private int <HaveSpina>k__BackingField; // 0x70

	// Properties
	public int HaveSpina { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17C9CAC Offset: 0x17C5CAC VA: 0x17C9CAC
	public int get_HaveSpina() { }

	[CompilerGenerated]
	// RVA: 0x17C9CB4 Offset: 0x17C5CB4 VA: 0x17C9CB4
	private void set_HaveSpina(int value) { }

	// RVA: 0x17C9CBC Offset: 0x17C5CBC VA: 0x17C9CBC
	public void Awake() { }

	// RVA: 0x17BA9B8 Offset: 0x17B69B8 VA: 0x17BA9B8
	public void Initialize(UICardGameBattlePanelManager uiMainManager, IUICardGameNavigationPanelClick clickManager) { }

	// RVA: 0x17BF4C0 Offset: 0x17BB4C0 VA: 0x17BF4C0
	public void SetEnabledUI(bool enable) { }

	// RVA: 0x17BAFBC Offset: 0x17B6FBC VA: 0x17BAFBC
	public void SetActiveButton(bool isMarketButton, bool isBattleButton, bool isPhaseEndButton) { }

	// RVA: 0x17BCFF4 Offset: 0x17B8FF4 VA: 0x17BCFF4
	public void SetPhaseStartUI(UICardGameBattlePanelManager.CardGamePhase phase) { }

	// RVA: 0x17BC28C Offset: 0x17B828C VA: 0x17BC28C
	public void TimerStart(float timer) { }

	// RVA: 0x17C237C Offset: 0x17BE37C VA: 0x17C237C
	public void AddSpina(int spina) { }

	// RVA: 0x17BAA04 Offset: 0x17B6A04 VA: 0x17BAA04
	public void SetSpina(int spina) { }

	// RVA: 0x17BE268 Offset: 0x17BA268 VA: 0x17BE268
	public Vector3 GetRewardPos() { }

	// RVA: 0x17C9EB4 Offset: 0x17C5EB4 VA: 0x17C9EB4
	public void OnClickMarketButton() { }

	// RVA: 0x17C9F5C Offset: 0x17C5F5C VA: 0x17C9F5C
	public void OnClickBattleButton() { }

	// RVA: 0x17CA008 Offset: 0x17C6008 VA: 0x17CA008
	public void OnClickPhaseEndButton() { }

	// RVA: 0x17CA0B4 Offset: 0x17C60B4 VA: 0x17CA0B4
	public void .ctor() { }
}
