// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseJukeboxLabel : UINameLabel // TypeDefIndex: 8925
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

	// RVA: 0x1E57FEC Offset: 0x1E53FEC VA: 0x1E57FEC Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E57FF4 Offset: 0x1E53FF4 VA: 0x1E57FF4 Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E57FFC Offset: 0x1E53FFC VA: 0x1E57FFC Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E58248 Offset: 0x1E54248 VA: 0x1E58248
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E58468 Offset: 0x1E54468 VA: 0x1E58468 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E583B8 Offset: 0x1E543B8 VA: 0x1E583B8
	private void UpdateIcon() { }

	// RVA: 0x1E5846C Offset: 0x1E5446C VA: 0x1E5846C Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E58548 Offset: 0x1E54548 VA: 0x1E58548
	public void .ctor() { }
}
