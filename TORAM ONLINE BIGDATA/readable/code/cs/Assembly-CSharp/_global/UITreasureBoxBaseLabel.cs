// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UITreasureBoxBaseLabel : MonoBehaviour // TypeDefIndex: 6582
{
	// Fields
	[SerializeField]
	protected BoxCollider tapCollider; // 0x20
	[SerializeField]
	protected UIIcon boxLabelIcon; // 0x28
	[SerializeField]
	protected GameObject blinkIcon; // 0x30
	[SerializeField]
	protected GameObject labelObject; // 0x38
	protected PlayerDataManager playerDataManager; // 0x40
	protected SystemTextManager systemTextManager; // 0x48
	protected Transform boxTransform; // 0x50
	protected int boxId; // 0x58
	protected bool isActive; // 0x5C
	protected bool isOpened; // 0x5D
	protected UILabel clickLabel; // 0x60
	protected bool isEnableClick; // 0x68

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnClick();

	// RVA: 0x1990150 Offset: 0x198C150 VA: 0x1990150
	protected void Start() { }

	// RVA: 0x1990370 Offset: 0x198C370 VA: 0x1990370
	public void Initialize(PlayerDataManager playerDataManager) { }

	// RVA: 0x19903A4 Offset: 0x198C3A4 VA: 0x19903A4
	public void LabelObjectInactive() { }

	// RVA: 0x19903C4 Offset: 0x198C3C4 VA: 0x19903C4 Slot: 5
	protected virtual bool IsButtonEnabled() { }

	// RVA: 0x19904C8 Offset: 0x198C4C8 VA: 0x19904C8
	protected void PositionUpdate() { }

	// RVA: 0x19905E0 Offset: 0x198C5E0 VA: 0x19905E0
	private void CreateLimitedFunctionWindow() { }

	// RVA: 0x19903A0 Offset: 0x198C3A0 VA: 0x19903A0
	protected void CreateClickLabel() { }

	// RVA: 0x19906F0 Offset: 0x198C6F0 VA: 0x19906F0
	protected void ChangeEnabelClickLabel(bool isEnable) { }

	// RVA: 0x19908DC Offset: 0x198C8DC VA: 0x19908DC
	protected void .ctor() { }
}
