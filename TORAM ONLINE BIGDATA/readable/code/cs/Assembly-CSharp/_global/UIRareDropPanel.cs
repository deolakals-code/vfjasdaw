// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRareDropPanel : MonoBehaviour // TypeDefIndex: 6558
{
	// Fields
	[SerializeField]
	private UIGLIruna2Label popRareItemLabel; // 0x20
	[SerializeField]
	private UIGLSpriteSlicedNew popRareFrameSprite; // 0x28
	[SerializeField]
	private UIGLSpriteSlicedNew popRareBackSprite; // 0x30
	[SerializeField]
	private Transform iconTrans; // 0x38
	private UIGLIcon popRareItemIcon; // 0x40
	private UITweener[] uiTweener; // 0x48
	private ItemTextManager itemTextManager; // 0x50
	private float timer; // 0x58
	private Vector3 labelPos; // 0x5C
	private Vector3 iconPos; // 0x68

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1980F28 Offset: 0x197CF28 VA: 0x1980F28
	public bool get_IsActive() { }

	// RVA: 0x1980F6C Offset: 0x197CF6C VA: 0x1980F6C
	private void Start() { }

	// RVA: 0x19810D4 Offset: 0x197D0D4 VA: 0x19810D4
	public void PopRareItemLabel(int itemId, byte itemType) { }

	// RVA: 0x19812AC Offset: 0x197D2AC VA: 0x19812AC
	public void CloseRareItemLabel() { }

	// RVA: 0x19812D0 Offset: 0x197D2D0 VA: 0x19812D0
	private void Update() { }

	// RVA: 0x19814D0 Offset: 0x197D4D0 VA: 0x19814D0
	public void .ctor() { }
}
