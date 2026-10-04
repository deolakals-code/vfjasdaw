// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntBoxLabel : UITreasureBoxBaseLabel // TypeDefIndex: 6583
{
	// Fields
	[SerializeField]
	private UILabel consumptionTimeLabel; // 0x70
	private TreasureBoxData boxData; // 0x78
	private int currentTimeLabelValue; // 0x80
	private float clickWaitTime; // 0x84

	// Methods

	// RVA: 0x19909AC Offset: 0x198C9AC VA: 0x19909AC Slot: 4
	protected override void OnClick() { }

	// RVA: 0x1990C54 Offset: 0x198CC54 VA: 0x1990C54
	public void SetTreasureBoxData(int id, TreasureBoxData data) { }

	// RVA: 0x1990CA4 Offset: 0x198CCA4 VA: 0x1990CA4
	public void LabelUpdate(bool isActive, int time = -1) { }

	// RVA: 0x1990DDC Offset: 0x198CDDC VA: 0x1990DDC Slot: 5
	protected override bool IsButtonEnabled() { }

	// RVA: 0x1990B9C Offset: 0x198CB9C VA: 0x1990B9C
	private bool IsTimeRemaining() { }

	// RVA: 0x1990EC0 Offset: 0x198CEC0 VA: 0x1990EC0
	public void .ctor() { }
}
