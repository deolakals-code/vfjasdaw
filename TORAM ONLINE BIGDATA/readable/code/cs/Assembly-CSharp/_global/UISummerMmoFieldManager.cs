// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerMmoFieldManager : UISummerBaseFieldManager // TypeDefIndex: 6285
{
	// Fields
	[SerializeField]
	private GameObject backReslutWindow; // 0xF0
	[SerializeField]
	private InactiveTimer backReslutWindowTimer; // 0xF8
	[SerializeField]
	private UILabel resultLabel; // 0x100
	protected bool isPopWindow; // 0x108
	private bool treasureBoxPopResult; // 0x109
	private bool isInit; // 0x10A

	// Methods

	[IteratorStateMachine(typeof(UISummerMmoFieldManager.<Start>d__6))]
	// RVA: 0x18DC688 Offset: 0x18D8688 VA: 0x18DC688 Slot: 11
	protected virtual IEnumerator Start() { }

	// RVA: 0x18DC71C Offset: 0x18D871C VA: 0x18DC71C Slot: 8
	protected override void UpdateData() { }

	// RVA: 0x18DC880 Offset: 0x18D8880 VA: 0x18DC880 Slot: 12
	protected virtual void CloseWindow() { }

	// RVA: 0x18DCA60 Offset: 0x18D8A60 VA: 0x18DCA60 Slot: 13
	protected virtual void PopWindow() { }

	// RVA: 0x18DCC40 Offset: 0x18D8C40 VA: 0x18DCC40
	public void OnResultEnter() { }

	// RVA: 0x18DCC94 Offset: 0x18D8C94 VA: 0x18DCC94
	public void OnClick_Action() { }

	// RVA: 0x18DCD64 Offset: 0x18D8D64 VA: 0x18DCD64 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DCE00 Offset: 0x18D8E00 VA: 0x18DCE00 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DCE88 Offset: 0x18D8E88 VA: 0x18DCE88
	public void .ctor() { }
}
