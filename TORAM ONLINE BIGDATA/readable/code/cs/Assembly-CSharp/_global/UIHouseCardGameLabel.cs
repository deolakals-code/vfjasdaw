// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCardGameLabel : UINameLabel // TypeDefIndex: 8922
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

	// RVA: 0x1E5693C Offset: 0x1E5293C VA: 0x1E5693C Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E56944 Offset: 0x1E52944 VA: 0x1E56944 Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E5694C Offset: 0x1E5294C VA: 0x1E5694C Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E56B80 Offset: 0x1E52B80 VA: 0x1E56B80
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E56DA0 Offset: 0x1E52DA0 VA: 0x1E56DA0 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E56CF0 Offset: 0x1E52CF0 VA: 0x1E56CF0
	private void UpdateIcon() { }

	// RVA: 0x1E56DA4 Offset: 0x1E52DA4 VA: 0x1E56DA4 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E56EC8 Offset: 0x1E52EC8 VA: 0x1E56EC8
	public void .ctor() { }
}
