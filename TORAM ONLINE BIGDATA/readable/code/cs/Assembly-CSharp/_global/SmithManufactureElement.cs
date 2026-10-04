// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithManufactureElement : MonoBehaviour // TypeDefIndex: 8529
{
	// Fields
	[SerializeField]
	private UILabel NameLabel; // 0x20
	[SerializeField]
	private UILabel SubLabel; // 0x28
	[SerializeField]
	private UILabel ExplanationLabel; // 0x30
	private int Index; // 0x38
	private int Step; // 0x3C
	private SmithManufacture Parent; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Methods

	// RVA: 0x1D9C89C Offset: 0x1D9889C VA: 0x1D9C89C
	private void Start() { }

	// RVA: 0x1D9C984 Offset: 0x1D98984 VA: 0x1D9C984
	private void Update() { }

	// RVA: 0x1D9C988 Offset: 0x1D98988 VA: 0x1D9C988
	public void SetParent(SmithManufacture parent) { }

	// RVA: 0x1D9C990 Offset: 0x1D98990 VA: 0x1D9C990
	public void SetIndex(int index) { }

	// RVA: 0x1D9C998 Offset: 0x1D98998 VA: 0x1D9C998
	public void SetStep(int step) { }

	// RVA: 0x1D99F00 Offset: 0x1D95F00 VA: 0x1D99F00
	public void SetSelected(bool selected) { }

	// RVA: 0x1D9CA30 Offset: 0x1D98A30 VA: 0x1D9CA30
	public void SetSelectedFirst(bool selected) { }

	// RVA: 0x1D9CB48 Offset: 0x1D98B48 VA: 0x1D9CB48
	public void ForceSelected(bool selected) { }

	// RVA: 0x1D9CBFC Offset: 0x1D98BFC VA: 0x1D9CBFC
	private void OnClick() { }

	// RVA: 0x1D9CD48 Offset: 0x1D98D48 VA: 0x1D9CD48
	private void OnPress(bool isdown) { }

	// RVA: 0x1D9CEA8 Offset: 0x1D98EA8 VA: 0x1D9CEA8
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(SmithManufactureElement.<MoveTo>d__18))]
	// RVA: 0x1D9C9A0 Offset: 0x1D989A0 VA: 0x1D9C9A0
	private IEnumerator MoveTo(Vector3 to) { }

	// RVA: 0x1D9CED4 Offset: 0x1D98ED4 VA: 0x1D9CED4
	public void .ctor() { }
}
