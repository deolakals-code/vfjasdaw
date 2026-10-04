// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILeftTopButton : UITopButtonBase // TypeDefIndex: 6537
{
	// Fields
	[SerializeField]
	private GameObject buttonObject; // 0x58
	private UIIruna2Anchor buttonAnchor; // 0x60
	[SerializeField]
	private GameObject iconEffect; // 0x68
	private TweenScale tweenScaleIconEffect; // 0x70
	private TweenRotation tweenRotationIconEffect; // 0x78
	private TweenPosition tweenPositionIconEffect; // 0x80
	private TargetManager targetManager; // 0x88
	[SerializeField]
	private GameObject leftTopEffect; // 0x90
	private float ligthTimer; // 0x98

	// Properties
	private UIIruna2Anchor ButtonAnchor { get; }

	// Methods

	// RVA: 0x197112C Offset: 0x196D12C VA: 0x197112C
	private UIIruna2Anchor get_ButtonAnchor() { }

	// RVA: 0x19711DC Offset: 0x196D1DC VA: 0x19711DC
	private void Awake() { }

	// RVA: 0x1971320 Offset: 0x196D320 VA: 0x1971320
	private void Update() { }

	// RVA: 0x1971388 Offset: 0x196D388 VA: 0x1971388 Slot: 4
	public override void SetLabel(string text, string iconSprite) { }

	// RVA: 0x19715F0 Offset: 0x196D5F0 VA: 0x19715F0
	public void PlayEffect() { }

	// RVA: 0x19716E4 Offset: 0x196D6E4 VA: 0x19716E4
	public void Fade(bool flag) { }

	// RVA: 0x1971778 Offset: 0x196D778 VA: 0x1971778
	private void OnClick() { }

	// RVA: 0x19717C8 Offset: 0x196D7C8 VA: 0x19717C8
	public void .ctor() { }
}
