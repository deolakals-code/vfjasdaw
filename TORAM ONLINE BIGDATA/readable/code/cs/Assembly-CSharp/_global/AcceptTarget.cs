// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class AcceptTarget // TypeDefIndex: 1082
{
	// Fields
	private GameObject[] acceptObject; // 0x10
	private EffectTargetTap[] makerCache; // 0x18
	private Action<GameObject> tapEvent; // 0x20
	private bool isFirstTap; // 0x28

	// Methods

	// RVA: 0x1F4613C Offset: 0x1F4213C VA: 0x1F4613C
	public void .ctor(Action<GameObject> tapEvent, int targetNum) { }

	// RVA: 0x1F45610 Offset: 0x1F41610 VA: 0x1F45610
	public void Initialize() { }

	// RVA: 0x1F46200 Offset: 0x1F42200 VA: 0x1F46200
	public void Clear() { }

	// RVA: 0x1F458C4 Offset: 0x1F418C4 VA: 0x1F458C4
	public void Update(IEnumerable<GameObject> candidateObjects, float timer) { }

	// RVA: 0x1F4636C Offset: 0x1F4236C VA: 0x1F4636C
	private void FirstTap(GameObject gameObject) { }
}
