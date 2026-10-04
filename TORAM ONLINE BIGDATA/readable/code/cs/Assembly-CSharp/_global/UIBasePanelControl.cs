// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBasePanelControl : UIBasePanel, IUIPanelControl // TypeDefIndex: 8869
{
	// Fields
	private Stack<Action> backAction; // 0x30
	[CompilerGenerated]
	private bool <Lock>k__BackingField; // 0x38
	protected Action closeAction; // 0x40
	protected Action rightSingleAction; // 0x48
	protected bool isRightSingleActionClear; // 0x50

	// Properties
	public Action TopAction { get; }
	public bool Lock { get; set; }

	// Methods

	// RVA: 0x1E3B14C Offset: 0x1E3714C VA: 0x1E3B14C
	public Action get_TopAction() { }

	[CompilerGenerated]
	// RVA: 0x1E3B1C4 Offset: 0x1E371C4 VA: 0x1E3B1C4
	public bool get_Lock() { }

	[CompilerGenerated]
	// RVA: 0x1E3B1CC Offset: 0x1E371CC VA: 0x1E3B1CC
	public void set_Lock(bool value) { }

	// RVA: 0x1E3B1D8 Offset: 0x1E371D8 VA: 0x1E3B1D8
	public void SetRightAction(Action closeAction) { }

	// RVA: 0x1E3B1E0 Offset: 0x1E371E0 VA: 0x1E3B1E0
	public void SetRightSingleAction(Action action, bool isClear = False) { }

	// RVA: 0x1E3B20C Offset: 0x1E3720C VA: 0x1E3B20C
	public void RightActionClear() { }

	// RVA: 0x1E3B234 Offset: 0x1E37234 VA: 0x1E3B234 Slot: 9
	public virtual void Push(Action pushFunction) { }

	// RVA: 0x1E3B28C Offset: 0x1E3728C VA: 0x1E3B28C Slot: 10
	public virtual Action Pop() { }

	// RVA: 0x1E3B3A8 Offset: 0x1E373A8 VA: 0x1E3B3A8 Slot: 11
	public virtual void Pop(int popCount) { }

	// RVA: 0x1E3B3E4 Offset: 0x1E373E4 VA: 0x1E3B3E4 Slot: 12
	public virtual void CheckPop(Action targetAction) { }

	// RVA: 0x1E3B468 Offset: 0x1E37468 VA: 0x1E3B468 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x1E3B4B8 Offset: 0x1E374B8 VA: 0x1E3B4B8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1E3B5C4 Offset: 0x1E375C4 VA: 0x1E3B5C4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1E3B704 Offset: 0x1E37704 VA: 0x1E3B704
	public void .ctor() { }
}
