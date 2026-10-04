// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaTreasureDropLabel : UINameLabel // TypeDefIndex: 6118
{
	// Fields
	[SerializeField]
	private GameObject iconsObj; // 0x88
	[SerializeField]
	private UIGLSprite itemIcon; // 0x90
	[SerializeField]
	private UIGLLabel itemLabel; // 0x98
	[SerializeField]
	private UIGLSprite icon; // 0xA0
	private int uniqueId; // 0xA8
	private MobaTreasureDropActionManager mobaAction; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private MobaTreasureBonusManager bonusManager; // 0xC0

	// Properties
	public int UniqueId { get; }
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x188D534 Offset: 0x1889534 VA: 0x188D534
	public int get_UniqueId() { }

	// RVA: 0x188D53C Offset: 0x188953C VA: 0x188D53C Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x188D548 Offset: 0x1889548 VA: 0x188D548 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x188D5D0 Offset: 0x18895D0 VA: 0x188D5D0
	public void Initialize(Transform traceObject, int uniqueId) { }

	// RVA: 0x188D8FC Offset: 0x18898FC VA: 0x188D8FC Slot: 9
	protected override void OnClick() { }

	// RVA: 0x188D7FC Offset: 0x18897FC VA: 0x188D7FC
	public void UpdateItemLabel() { }

	// RVA: 0x188DA08 Offset: 0x1889A08 VA: 0x188DA08
	public void .ctor() { }
}
