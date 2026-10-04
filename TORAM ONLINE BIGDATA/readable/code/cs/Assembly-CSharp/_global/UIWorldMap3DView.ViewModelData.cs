// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIWorldMap3DView.ViewModelData // TypeDefIndex: 7383
{
	// Fields
	public readonly int FieldId; // 0x10
	public readonly Matrix4x4 Trans; // 0x14
	public readonly bool IsBonus; // 0x54
	public readonly bool IsWarp; // 0x55
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x56
	[CompilerGenerated]
	private bool <IsPickup>k__BackingField; // 0x57
	private UIGL3DLabelView labelView; // 0x58
	private UIGL3DLabelView selectLabelView; // 0x60

	// Properties
	public bool IsActive { get; set; }
	public bool IsPickup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B36E64 Offset: 0x1B32E64 VA: 0x1B36E64
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x1B36E6C Offset: 0x1B32E6C VA: 0x1B36E6C
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B36E78 Offset: 0x1B32E78 VA: 0x1B36E78
	public bool get_IsPickup() { }

	[CompilerGenerated]
	// RVA: 0x1B36E80 Offset: 0x1B32E80 VA: 0x1B36E80
	private void set_IsPickup(bool value) { }

	// RVA: 0x1B36E8C Offset: 0x1B32E8C VA: 0x1B36E8C
	public void .ctor(bool isBonus, bool isWarp, int fieldId, Matrix4x4 trans, UIGL3DLabelView labelView, UIGL3DLabelView selectLabelView) { }

	// RVA: 0x1B34458 Offset: 0x1B30458 VA: 0x1B34458
	public void .ctor(bool isBonus, bool isWarp, int fieldId, Matrix4x4 trans, UIGL3DLabelView labelView, UIGL3DLabelView selectLabelView, bool isPickup) { }

	// RVA: 0x1B34E84 Offset: 0x1B30E84 VA: 0x1B34E84
	public void ViewAreaCheck(Vector3 minPos, Vector3 maxPos) { }

	// RVA: 0x1B36830 Offset: 0x1B32830 VA: 0x1B36830
	public void DrawUI(Matrix4x4 viewTrans, Vector3 pos, float alpha) { }

	// RVA: 0x1B36968 Offset: 0x1B32968 VA: 0x1B36968
	public void DrawUI(Matrix4x4 viewTrans, UIGL3DLabelView bonusLabel, Vector3 pos, float alpha) { }
}
