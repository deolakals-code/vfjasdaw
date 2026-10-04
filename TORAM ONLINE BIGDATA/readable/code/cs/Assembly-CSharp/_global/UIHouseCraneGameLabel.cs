// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCraneGameLabel : UINameLabel // TypeDefIndex: 8924
{
	// Fields
	[SerializeField]
	private GameObject activeIcon; // 0x88
	[SerializeField]
	private GameObject[] frame; // 0x90
	private UIGLSprite[] frameSprite; // 0x98
	private int itemUid; // 0xA0
	private UI3DNameManager nameManager; // 0xA8

	// Properties
	protected override bool ActiveFlag { get; }
	protected override bool IsCorrectPosInView { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E579C4 Offset: 0x1E539C4 VA: 0x1E579C4 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E579CC Offset: 0x1E539CC VA: 0x1E579CC Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E579D4 Offset: 0x1E539D4 VA: 0x1E579D4 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E57C08 Offset: 0x1E53C08 VA: 0x1E57C08
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E57E28 Offset: 0x1E53E28 VA: 0x1E57E28 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E57D78 Offset: 0x1E53D78 VA: 0x1E57D78
	private void UpdateIcon() { }

	// RVA: 0x1E57E2C Offset: 0x1E53E2C VA: 0x1E57E2C Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E57F50 Offset: 0x1E53F50 VA: 0x1E57F50
	public void .ctor() { }
}
