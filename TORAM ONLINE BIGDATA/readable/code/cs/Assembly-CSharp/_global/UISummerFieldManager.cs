// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerFieldManager : UISummerBaseFieldManager // TypeDefIndex: 6283
{
	// Fields
	[SerializeField]
	private GameObject backReslutWindow; // 0xF0
	[SerializeField]
	private InactiveTimer backReslutWindowTimer; // 0xF8
	[SerializeField]
	private UILabel resultLabel; // 0x100
	protected bool isPopWindow; // 0x108

	// Methods

	// RVA: 0x18DC18C Offset: 0x18D818C VA: 0x18DC18C Slot: 8
	protected override void UpdateData() { }

	// RVA: 0x18DC1E0 Offset: 0x18D81E0 VA: 0x18DC1E0 Slot: 11
	protected virtual void CloseWindow() { }

	// RVA: 0x18DC3C0 Offset: 0x18D83C0 VA: 0x18DC3C0 Slot: 12
	protected virtual void PopWindow() { }

	// RVA: 0x18DC5A0 Offset: 0x18D85A0 VA: 0x18DC5A0
	public void OnResultEnter() { }

	// RVA: 0x18DC644 Offset: 0x18D8644 VA: 0x18DC644 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DC66C Offset: 0x18D866C VA: 0x18DC66C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DC684 Offset: 0x18D8684 VA: 0x18DC684
	public void .ctor() { }
}
