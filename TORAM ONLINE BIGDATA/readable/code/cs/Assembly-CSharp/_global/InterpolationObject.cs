// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InterpolationObject : MonoBehaviour // TypeDefIndex: 5500
{
	// Methods

	// RVA: 0x177DC34 Offset: 0x1779C34 VA: 0x177DC34
	public void SetPosition(Vector3 position, float duration) { }

	// RVA: 0x177DCDC Offset: 0x1779CDC VA: 0x177DCDC
	public void Activate(float duration, Action callback) { }

	// RVA: 0x177DE88 Offset: 0x1779E88 VA: 0x177DE88
	public void Destroy(float duration, Action callback) { }

	[IteratorStateMachine(typeof(InterpolationObject.<Activation>d__3))]
	// RVA: 0x177DDF0 Offset: 0x1779DF0 VA: 0x177DDF0
	private IEnumerator Activation(float duration, Action callback) { }

	[IteratorStateMachine(typeof(InterpolationObject.<InActivation>d__4))]
	// RVA: 0x177DF64 Offset: 0x1779F64 VA: 0x177DF64
	private IEnumerator InActivation(float duration, Action callback) { }

	// RVA: 0x177E04C Offset: 0x177A04C VA: 0x177E04C
	public void .ctor() { }
}
