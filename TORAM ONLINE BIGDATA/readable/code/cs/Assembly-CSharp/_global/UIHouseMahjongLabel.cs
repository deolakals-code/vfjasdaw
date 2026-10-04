// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMahjongLabel : UINameLabel // TypeDefIndex: 8926
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

	// RVA: 0x1E585E4 Offset: 0x1E545E4 VA: 0x1E585E4 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E585EC Offset: 0x1E545EC VA: 0x1E585EC Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E58820 Offset: 0x1E54820 VA: 0x1E58820
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E58A40 Offset: 0x1E54A40 VA: 0x1E58A40 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E58990 Offset: 0x1E54990 VA: 0x1E58990
	private void UpdateIcon() { }

	// RVA: 0x1E58A44 Offset: 0x1E54A44 VA: 0x1E58A44 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E58B68 Offset: 0x1E54B68 VA: 0x1E58B68
	public void .ctor() { }
}
