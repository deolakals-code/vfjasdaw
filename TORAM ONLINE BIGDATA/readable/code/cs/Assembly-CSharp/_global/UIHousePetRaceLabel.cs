// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHousePetRaceLabel : UINameLabel // TypeDefIndex: 8929
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

	// RVA: 0x1E5918C Offset: 0x1E5518C VA: 0x1E5918C Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E59194 Offset: 0x1E55194 VA: 0x1E59194 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E593C8 Offset: 0x1E553C8 VA: 0x1E593C8
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height) { }

	// RVA: 0x1E595E8 Offset: 0x1E555E8 VA: 0x1E595E8 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E59538 Offset: 0x1E55538 VA: 0x1E59538
	private void UpdateIcon() { }

	// RVA: 0x1E595EC Offset: 0x1E555EC VA: 0x1E595EC Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E5969C Offset: 0x1E5569C VA: 0x1E5969C
	public void .ctor() { }
}
