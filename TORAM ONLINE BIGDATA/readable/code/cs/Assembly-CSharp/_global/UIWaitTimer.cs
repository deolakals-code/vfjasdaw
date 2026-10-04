// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaitTimer : MonoBehaviour // TypeDefIndex: 6587
{
	// Fields
	[SerializeField]
	private UISprite castTimeBar; // 0x20
	[SerializeField]
	private UISprite castTimeBackBar; // 0x28
	[SerializeField]
	private UILabel castTimeLabel; // 0x30
	[SerializeField]
	private UISprite chatBackSprite; // 0x38
	[SerializeField]
	private UIGLWidget[] uiWidget; // 0x40
	private UIGLSpriteSliced barSprite; // 0x48
	private UIGLSpriteSliced barBackSprite; // 0x50
	private UIGLLabel messageLabel; // 0x58
	private float waitTimer; // 0x60
	private float waitTime; // 0x64
	private float enabledTimer; // 0x68
	private UIWaitTimer.WaitTimeType activeType; // 0x6C
	private readonly Color[] barColor; // 0x70
	private string waitTimeText; // 0x78
	private string houseText; // 0x80
	private SystemTextManager systemTextManager; // 0x88

	// Properties
	private bool IsNGUIDraw { get; }

	// Methods

	// RVA: 0x199206C Offset: 0x198E06C VA: 0x199206C
	private bool get_IsNGUIDraw() { }

	// RVA: 0x1992110 Offset: 0x198E110 VA: 0x1992110
	private void Start() { }

	// RVA: 0x1992558 Offset: 0x198E558 VA: 0x1992558
	public void SetWaitTime(UIWaitTimer.WaitTimeType type, float timer) { }

	// RVA: 0x19928E8 Offset: 0x198E8E8 VA: 0x19928E8
	public void SetWaitTime(UIWaitTimer.WaitTimeType type, float timer, float elapsedTime) { }

	// RVA: 0x1992C80 Offset: 0x198EC80 VA: 0x1992C80
	public void ClearWaitTime() { }

	// RVA: 0x1992F9C Offset: 0x198EF9C VA: 0x1992F9C
	private void Update() { }

	// RVA: 0x199355C Offset: 0x198F55C VA: 0x199355C
	public void .ctor() { }
}
