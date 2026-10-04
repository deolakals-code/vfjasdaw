// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHousePetShopLabel : UINameLabel // TypeDefIndex: 8930
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
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E59738 Offset: 0x1E55738 VA: 0x1E59738 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E59740 Offset: 0x1E55740 VA: 0x1E59740 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E5998C Offset: 0x1E5598C VA: 0x1E5998C
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E59BAC Offset: 0x1E55BAC VA: 0x1E59BAC Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E59AFC Offset: 0x1E55AFC VA: 0x1E59AFC
	private void UpdateIcon() { }

	// RVA: 0x1E59BB0 Offset: 0x1E55BB0 VA: 0x1E59BB0 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E59CD4 Offset: 0x1E55CD4 VA: 0x1E59CD4
	public void .ctor() { }
}
