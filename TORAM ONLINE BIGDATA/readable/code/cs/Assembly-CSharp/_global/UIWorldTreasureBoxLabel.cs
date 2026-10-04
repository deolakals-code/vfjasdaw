// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureBoxLabel : UITreasureBoxBaseLabel // TypeDefIndex: 8222
{
	// Fields
	private byte treasureType; // 0x69
	private bool isShow; // 0x6A
	private bool isOpened; // 0x6B
	private bool isBagMax; // 0x6C

	// Methods

	// RVA: 0x1CFB9C0 Offset: 0x1CF79C0 VA: 0x1CFB9C0 Slot: 4
	protected override void OnClick() { }

	// RVA: 0x1CFBCD0 Offset: 0x1CF7CD0 VA: 0x1CFBCD0
	public void SetTreasureBoxData(int id, byte type, Transform target) { }

	// RVA: 0x1CFBCE4 Offset: 0x1CF7CE4 VA: 0x1CFBCE4
	public void LabelUpdate(bool isActive) { }

	[IteratorStateMachine(typeof(UIWorldTreasureBoxLabel.<SetLabel>d__7))]
	// RVA: 0x1CFBD80 Offset: 0x1CF7D80 VA: 0x1CFBD80
	private IEnumerator SetLabel() { }

	// RVA: 0x1CFBDEC Offset: 0x1CF7DEC VA: 0x1CFBDEC
	private void LabelIconUpdate() { }

	[IteratorStateMachine(typeof(UIWorldTreasureBoxLabel.<TreasureOpen>d__9))]
	// RVA: 0x1CFBC64 Offset: 0x1CF7C64 VA: 0x1CFBC64
	private IEnumerator TreasureOpen() { }

	// RVA: 0x1CFBB54 Offset: 0x1CF7B54 VA: 0x1CFBB54
	private void CreateLimitedFunctionWindow() { }

	// RVA: 0x1CFBB44 Offset: 0x1CF7B44 VA: 0x1CFBB44
	private bool IsBoxType() { }

	// RVA: 0x1CFC000 Offset: 0x1CF8000 VA: 0x1CFC000
	public void .ctor() { }
}
