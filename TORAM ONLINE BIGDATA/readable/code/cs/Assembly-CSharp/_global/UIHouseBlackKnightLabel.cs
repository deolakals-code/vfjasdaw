// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseBlackKnightLabel : UINameLabel // TypeDefIndex: 8921
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

	// RVA: 0x1E56314 Offset: 0x1E52314 VA: 0x1E56314 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E5631C Offset: 0x1E5231C VA: 0x1E5631C Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E56324 Offset: 0x1E52324 VA: 0x1E56324 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E56558 Offset: 0x1E52558 VA: 0x1E56558
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E56778 Offset: 0x1E52778 VA: 0x1E56778 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E566C8 Offset: 0x1E526C8 VA: 0x1E566C8
	private void UpdateIcon() { }

	// RVA: 0x1E5677C Offset: 0x1E5277C VA: 0x1E5677C Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E568A0 Offset: 0x1E528A0 VA: 0x1E568A0
	public void .ctor() { }
}
