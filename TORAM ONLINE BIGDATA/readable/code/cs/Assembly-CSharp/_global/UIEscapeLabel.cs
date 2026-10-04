// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEscapeLabel : MonoBehaviour // TypeDefIndex: 6508
{
	// Fields
	private UIEscapeLabel.FadeType fadeType; // 0x20
	[SerializeField]
	private UIGLWidget[] uiWidget; // 0x28
	[SerializeField]
	private UIGLLabel timerLabel; // 0x30
	[SerializeField]
	private GameObject panel; // 0x38
	private UIGLSpriteSliced barSprite; // 0x40
	private UIGLSpriteSliced barBackSprite; // 0x48
	private UIGLLabel messageLabel; // 0x50
	private string waitTimeText; // 0x58
	private const float escapeTime = 10;
	private float oldEscapeTime; // 0x60
	private TweenColor tweenColor; // 0x68
	private PlayerDataManager playerDataManager; // 0x70

	// Methods

	// RVA: 0x19644DC Offset: 0x19604DC VA: 0x19644DC
	private void Start() { }

	// RVA: 0x1964854 Offset: 0x1960854 VA: 0x1964854
	private void Update() { }

	// RVA: 0x1964DAC Offset: 0x1960DAC VA: 0x1964DAC
	public void .ctor() { }
}
