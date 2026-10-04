// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TargetSymbol : MonoBehaviour // TypeDefIndex: 4656
{
	// Fields
	private const float MAX_SIZE = 6;
	private Motion targetAnimation; // 0x20
	private Transform targetTransform; // 0x28
	private Vector3 targetPosition; // 0x30
	private Transform nextTargetTransform; // 0x40
	private Vector3 nextTargetPosition; // 0x48
	private float nextTargetSize; // 0x54
	private bool nextTargetPosMode; // 0x58
	private bool hasNextTarget; // 0x59
	private bool posMode; // 0x5A
	private bool isSetFrame; // 0x5B
	private TargetSymbol.SymbolState state; // 0x5C

	// Methods

	// RVA: 0x25875BC Offset: 0x25835BC VA: 0x25875BC
	private void Awake() { }

	// RVA: 0x2587614 Offset: 0x2583614 VA: 0x2587614
	public void SetTargetSimbolSize(float size) { }

	// RVA: 0x25872E4 Offset: 0x25832E4 VA: 0x25872E4
	public void SetNextTarget(Transform trans, float size) { }

	// RVA: 0x2587224 Offset: 0x2583224 VA: 0x2587224
	public void SetNextTarget(Vector3 pos, float size) { }

	// RVA: 0x2585A20 Offset: 0x2581A20 VA: 0x2585A20
	public void EndTarget() { }

	// RVA: 0x2587650 Offset: 0x2583650 VA: 0x2587650
	private void startAnimation() { }

	// RVA: 0x25878BC Offset: 0x25838BC VA: 0x25878BC
	private void endAnimation() { }

	// RVA: 0x2587904 Offset: 0x2583904 VA: 0x2587904
	private void Update() { }

	// RVA: 0x258793C Offset: 0x258393C VA: 0x258793C
	private void LateUpdate() { }

	// RVA: 0x25876A8 Offset: 0x25836A8 VA: 0x25876A8
	private void setTargetTransform(Transform trans) { }

	// RVA: 0x25877C0 Offset: 0x25837C0 VA: 0x25877C0
	private void setTargetPosition(Vector3 pos) { }

	// RVA: 0x2587AC4 Offset: 0x2583AC4 VA: 0x2587AC4
	public void .ctor() { }
}
