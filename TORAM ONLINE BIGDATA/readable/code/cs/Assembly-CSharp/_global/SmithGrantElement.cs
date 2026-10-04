// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithGrantElement : MonoBehaviour // TypeDefIndex: 8490
{
	// Fields
	[SerializeField]
	private UILabel NameLabel; // 0x20
	private int Index; // 0x28
	private int Step; // 0x2C
	private bool Enabled; // 0x30
	private SmithGrant Parent; // 0x38
	private SpringPosition spring; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Methods

	// RVA: 0x1D84DF4 Offset: 0x1D80DF4 VA: 0x1D84DF4
	private void Awake() { }

	// RVA: 0x1D84EDC Offset: 0x1D80EDC VA: 0x1D84EDC
	private void Start() { }

	// RVA: 0x1D84EE0 Offset: 0x1D80EE0 VA: 0x1D84EE0
	private void Update() { }

	// RVA: 0x1D84EE4 Offset: 0x1D80EE4 VA: 0x1D84EE4
	public void SetParent(SmithGrant parent) { }

	// RVA: 0x1D84EEC Offset: 0x1D80EEC VA: 0x1D84EEC
	public void SetIndex(int index) { }

	// RVA: 0x1D84EF4 Offset: 0x1D80EF4 VA: 0x1D84EF4
	public void SetStep(int step) { }

	// RVA: 0x1D84EFC Offset: 0x1D80EFC VA: 0x1D84EFC
	public void SetSelected(bool selected) { }

	// RVA: 0x1D850A4 Offset: 0x1D810A4 VA: 0x1D850A4
	public void ForceSelected(bool selected) { }

	// RVA: 0x1D85120 Offset: 0x1D81120 VA: 0x1D85120
	public void SetText(string text) { }

	// RVA: 0x1D8513C Offset: 0x1D8113C VA: 0x1D8513C
	public void SetEnable(bool enable) { }

	// RVA: 0x1D85238 Offset: 0x1D81238 VA: 0x1D85238
	public void SetIsFree() { }

	// RVA: 0x1D852D0 Offset: 0x1D812D0 VA: 0x1D852D0
	public void SetIsNotUsable() { }

	// RVA: 0x1D85368 Offset: 0x1D81368 VA: 0x1D85368
	private void OnClick() { }

	// RVA: 0x1D8539C Offset: 0x1D8139C VA: 0x1D8539C
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(SmithGrantElement.<MoveTo>d__21))]
	// RVA: 0x1D85014 Offset: 0x1D81014 VA: 0x1D85014
	private IEnumerator MoveTo(Vector3 to) { }

	// RVA: 0x1D853C8 Offset: 0x1D813C8 VA: 0x1D853C8
	public void .ctor() { }
}
