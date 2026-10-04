// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseRodLabel : UINameLabel // TypeDefIndex: 8932
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
	protected override bool IsCorrectPosInView { get; }
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E5A398 Offset: 0x1E56398 VA: 0x1E5A398 Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E5A3A0 Offset: 0x1E563A0 VA: 0x1E5A3A0 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E5A3A8 Offset: 0x1E563A8 VA: 0x1E5A3A8 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E5A5F4 Offset: 0x1E565F4 VA: 0x1E5A5F4
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E5A814 Offset: 0x1E56814 VA: 0x1E5A814 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E5A764 Offset: 0x1E56764 VA: 0x1E5A764
	private void UpdateIcon() { }

	// RVA: 0x1E5A818 Offset: 0x1E56818 VA: 0x1E5A818 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E5A8F4 Offset: 0x1E568F4 VA: 0x1E5A8F4
	public void .ctor() { }
}
