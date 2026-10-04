// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PhantomMissileAction.MoveEffect // TypeDefIndex: 2886
{
	// Fields
	private PhantomMissileAction.MoveEffect.EffectState state; // 0x10
	private bool isHit; // 0x14
	private bool isHitCheck; // 0x15
	private float hitCheckOffTimer; // 0x18
	private bool isEnd; // 0x1C
	private GameObject effect; // 0x20
	private Transform targetTransform; // 0x28
	private float targetSize; // 0x30
	private Vector3 moveSpeed; // 0x34
	private const float acceleration = 75;
	private const float turningSpeed = 5;
	private int bounceCount; // 0x40
	private int maxBounce; // 0x44

	// Properties
	private Vector3 accelDir { get; }

	// Methods

	// RVA: 0x22BD7B4 Offset: 0x22B97B4 VA: 0x22BD7B4
	private Vector3 get_accelDir() { }

	// RVA: 0x22BCC48 Offset: 0x22B8C48 VA: 0x22BCC48
	public void .ctor(GameObject obj, GameObject target, int bounce) { }

	// RVA: 0x22BCE30 Offset: 0x22B8E30 VA: 0x22BCE30
	public void Update() { }

	// RVA: 0x22BD3EC Offset: 0x22B93EC VA: 0x22BD3EC
	public void ChangeState(int state) { }

	// RVA: 0x22BD5CC Offset: 0x22B95CC VA: 0x22BD5CC
	public bool CheckNextTake() { }

	// RVA: 0x22BD958 Offset: 0x22B9958 VA: 0x22BD958
	private bool HitCheck() { }
}
