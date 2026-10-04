// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketControl : UIBasePanelControl // TypeDefIndex: 8363
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x58
	private List<string> titleHistoryList; // 0x60
	[CompilerGenerated]
	private bool <IsPreviewWeapon>k__BackingField; // 0x68

	// Properties
	public bool IsPreviewWeapon { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D30B00 Offset: 0x1D2CB00 VA: 0x1D30B00
	public bool get_IsPreviewWeapon() { }

	[CompilerGenerated]
	// RVA: 0x1D30B08 Offset: 0x1D2CB08 VA: 0x1D30B08
	private void set_IsPreviewWeapon(bool value) { }

	// RVA: 0x1D30B14 Offset: 0x1D2CB14 VA: 0x1D30B14
	protected void Awake() { }

	// RVA: 0x1D30B3C Offset: 0x1D2CB3C VA: 0x1D30B3C Slot: 14
	protected virtual void InitializeAwake() { }

	// RVA: 0x1D30C24 Offset: 0x1D2CC24 VA: 0x1D30C24
	public void SetDefaultTitle(string titleLocalizeKey) { }

	// RVA: 0x1D30D2C Offset: 0x1D2CD2C VA: 0x1D30D2C Slot: 9
	public override void Push(Action pushFunction) { }

	// RVA: 0x1D30FF8 Offset: 0x1D2CFF8 VA: 0x1D30FF8 Slot: 13
	public override void Clear() { }

	// RVA: 0x1D30DF4 Offset: 0x1D2CDF4 VA: 0x1D30DF4
	public void Push(Action pushFunction, string titleLocalizeKey, string[] param) { }

	// RVA: 0x1D310F4 Offset: 0x1D2D0F4 VA: 0x1D310F4 Slot: 10
	public override Action Pop() { }

	// RVA: 0x1D31068 Offset: 0x1D2D068 VA: 0x1D31068
	private void updateTitleLabel() { }

	// RVA: 0x1D31174 Offset: 0x1D2D174 VA: 0x1D31174 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1D31208 Offset: 0x1D2D208 VA: 0x1D31208
	public void SetPreviewFlag(bool isPreview) { }

	// RVA: 0x1D31214 Offset: 0x1D2D214 VA: 0x1D31214
	public void ChangePreviewFlag() { }

	// RVA: 0x1D31224 Offset: 0x1D2D224 VA: 0x1D31224
	public void .ctor() { }
}
