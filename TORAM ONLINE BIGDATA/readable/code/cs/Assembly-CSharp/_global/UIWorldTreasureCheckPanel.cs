// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureCheckPanel : MonoBehaviour, IWorldTreasurePanel // TypeDefIndex: 8226
{
	// Fields
	[SerializeField]
	private GameObject panelObject; // 0x20
	[SerializeField]
	private UILabel messageLabel; // 0x28
	[SerializeField]
	private UILabel keyNumLabel; // 0x30
	[SerializeField]
	private UILabel timeLabel; // 0x38
	[SerializeField]
	private UIWidget timeGauge; // 0x40
	[SerializeField]
	private UIImageButton button; // 0x48
	private static readonly int gaugeMaxWidth; // 0x0
	private SystemTextManager systemTextManager; // 0x50
	private UIWorldTreasureManager manager; // 0x58
	private int keyNum; // 0x60

	// Methods

	// RVA: 0x1CFD0AC Offset: 0x1CF90AC VA: 0x1CFD0AC
	private void Start() { }

	// RVA: 0x1CFD0B0 Offset: 0x1CF90B0 VA: 0x1CFD0B0
	private void Update() { }

	// RVA: 0x1CFD190 Offset: 0x1CF9190 VA: 0x1CFD190
	private void GaugeUpdate() { }

	// RVA: 0x1CFD2A8 Offset: 0x1CF92A8 VA: 0x1CFD2A8
	private void KeyLabelUpdate() { }

	// RVA: 0x1CFD42C Offset: 0x1CF942C VA: 0x1CFD42C
	private void timeLabelUpdate() { }

	// RVA: 0x1CFD56C Offset: 0x1CF956C VA: 0x1CFD56C
	private void OnClickButton() { }

	// RVA: 0x1CFD588 Offset: 0x1CF9588 VA: 0x1CFD588 Slot: 4
	public void Initialize(UIWorldTreasureManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1CFD850 Offset: 0x1CF9850 VA: 0x1CFD850 Slot: 5
	public void Close() { }

	// RVA: 0x1CFD870 Offset: 0x1CF9870 VA: 0x1CFD870 Slot: 6
	public bool PushLeftTopButton() { }

	// RVA: 0x1CFD878 Offset: 0x1CF9878 VA: 0x1CFD878
	public void .ctor() { }

	// RVA: 0x1CFD880 Offset: 0x1CF9880 VA: 0x1CFD880
	private static void .cctor() { }
}
