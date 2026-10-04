// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseRhythmGameLabel : UINameLabel // TypeDefIndex: 8931
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

	// RVA: 0x1E59D70 Offset: 0x1E55D70 VA: 0x1E59D70 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E59D78 Offset: 0x1E55D78 VA: 0x1E59D78 Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E59D80 Offset: 0x1E55D80 VA: 0x1E59D80 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E59FB4 Offset: 0x1E55FB4 VA: 0x1E59FB4
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E5A1D4 Offset: 0x1E561D4 VA: 0x1E5A1D4 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E5A124 Offset: 0x1E56124 VA: 0x1E5A124
	private void UpdateIcon() { }

	// RVA: 0x1E5A1D8 Offset: 0x1E561D8 VA: 0x1E5A1D8 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E5A2FC Offset: 0x1E562FC VA: 0x1E5A2FC
	public void .ctor() { }
}
