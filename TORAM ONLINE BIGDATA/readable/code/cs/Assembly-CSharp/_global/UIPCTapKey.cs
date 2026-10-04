// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPCTapKey : UIPCKeyButton // TypeDefIndex: 8755
{
	// Fields
	[SerializeField]
	private GameObject[] widget; // 0x30
	[SerializeField]
	private IUILabel keyLabel; // 0x38
	private BoxCollider bocCollider; // 0x40
	private IUIWidget[] widgets; // 0x48

	// Properties
	public override bool IsUpdateLabel { get; }

	// Methods

	// RVA: 0x1E01D58 Offset: 0x1DFDD58 VA: 0x1E01D58 Slot: 11
	public override bool get_IsUpdateLabel() { }

	// RVA: 0x1E01D60 Offset: 0x1DFDD60 VA: 0x1E01D60
	private void Awake() { }

	// RVA: 0x1E01EB4 Offset: 0x1DFDEB4 VA: 0x1E01EB4 Slot: 12
	protected override void Start() { }

	// RVA: 0x1E01EB8 Offset: 0x1DFDEB8 VA: 0x1E01EB8
	private void OnEnable() { }

	// RVA: 0x1E01EBC Offset: 0x1DFDEBC VA: 0x1E01EBC Slot: 13
	public override void PushKeyDown() { }

	// RVA: 0x1E01FC0 Offset: 0x1DFDFC0 VA: 0x1E01FC0
	public void OnHover(bool isOver) { }

	// RVA: 0x1E020C8 Offset: 0x1DFE0C8 VA: 0x1E020C8 Slot: 16
	public override bool CheckAction() { }

	// RVA: 0x1E021CC Offset: 0x1DFE1CC VA: 0x1E021CC Slot: 17
	public override void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap) { }

	// RVA: 0x1E02334 Offset: 0x1DFE334 VA: 0x1E02334
	public void .ctor() { }
}
