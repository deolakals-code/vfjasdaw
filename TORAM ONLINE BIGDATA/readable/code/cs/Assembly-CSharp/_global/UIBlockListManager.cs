// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlockListManager : UIBasePanel // TypeDefIndex: 8142
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject elementObj; // 0x38
	[SerializeField]
	private GameObject nonList; // 0x40
	[SerializeField]
	private GameObject selectedPanel; // 0x48
	[SerializeField]
	private UILabel selectedLabel; // 0x50
	private UIBlockListManager.BlockUserData currentData; // 0x58
	private OptionBlock optionBlock; // 0x60
	private List<UIBlockListManager.BlockUserData> userDatas; // 0x68

	// Methods

	// RVA: 0x1CD56C0 Offset: 0x1CD16C0 VA: 0x1CD56C0
	private void Start() { }

	// RVA: 0x1CD6450 Offset: 0x1CD2450 VA: 0x1CD6450
	private void OnDestroy() { }

	// RVA: 0x1CD5E38 Offset: 0x1CD1E38 VA: 0x1CD5E38
	private void CreateListData() { }

	// RVA: 0x1CD646C Offset: 0x1CD246C VA: 0x1CD646C
	public void OnClick_SelectedRemoveUserId(int id) { }

	// RVA: 0x1CD6624 Offset: 0x1CD2624 VA: 0x1CD6624
	public void OnClick_RemovedUser() { }

	// RVA: 0x1CD66E0 Offset: 0x1CD26E0 VA: 0x1CD66E0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CD679C Offset: 0x1CD279C VA: 0x1CD679C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CD6820 Offset: 0x1CD2820 VA: 0x1CD6820
	public void .ctor() { }
}
