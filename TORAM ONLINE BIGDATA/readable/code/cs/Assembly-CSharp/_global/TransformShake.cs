// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TransformShake // TypeDefIndex: 387
{
	// Fields
	private readonly Transform transform; // 0x10
	private Dictionary<Transform, Vector3> damageShakeChiled; // 0x18

	// Methods

	// RVA: 0x255DA1C Offset: 0x2559A1C VA: 0x255DA1C
	public void .ctor(Transform transform) { }

	[IteratorStateMachine(typeof(TransformShake.<Shake>d__3))]
	// RVA: 0x255DA4C Offset: 0x2559A4C VA: 0x255DA4C
	public IEnumerator Shake(float power, float rate, Vector3 dir) { }
}
