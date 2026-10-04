// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaChestLabel : UINameLabel // TypeDefIndex: 6042
{
	// Fields
	[SerializeField]
	private UIGLSpriteSliced waitBar; // 0x88
	[SerializeField]
	private GameObject barsObj; // 0x90
	[SerializeField]
	private GameObject iconsObj; // 0x98
	[SerializeField]
	private UIGLSprite[] icons; // 0xA0
	private int uniqueId; // 0xA8
	private MobaChestActionManager mobaAction; // 0xB0

	// Properties
	public int UniqueId { get; }
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1874B90 Offset: 0x1870B90 VA: 0x1874B90
	public int get_UniqueId() { }

	// RVA: 0x1874B98 Offset: 0x1870B98 VA: 0x1874B98 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1874BA4 Offset: 0x1870BA4 VA: 0x1874BA4 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1874C2C Offset: 0x1870C2C VA: 0x1874C2C
	public void Initialize(Transform traceObject, int uniqueId) { }

	// RVA: 0x1874EA0 Offset: 0x1870EA0 VA: 0x1874EA0 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1874EF8 Offset: 0x1870EF8 VA: 0x1874EF8
	public void StartWaitTimer() { }

	// RVA: 0x1874F30 Offset: 0x1870F30 VA: 0x1874F30
	public void Cancel() { }

	// RVA: 0x1874F68 Offset: 0x1870F68 VA: 0x1874F68
	public void Opened() { }

	// RVA: 0x1874FA0 Offset: 0x1870FA0 VA: 0x1874FA0 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1875074 Offset: 0x1871074 VA: 0x1875074
	public void .ctor() { }
}
