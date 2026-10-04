// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingAttack : MonoBehaviour // TypeDefIndex: 4523
{
	// Fields
	private float maxSpeed; // 0x20
	private float speed; // 0x24
	private float takeSpeed; // 0x28
	private Vector3 move; // 0x2C
	private Action callBack; // 0x38
	private SummerEventRoomData roomData; // 0x40
	private byte type; // 0x48
	private int id; // 0x4C
	private GameObject center; // 0x50
	private bool isHit; // 0x58
	private float downTimer; // 0x5C
	private bool isSuperMory; // 0x60
	private float hitTimer; // 0x64
	private int hitMobId; // 0x68
	[CompilerGenerated]
	private float <Rad>k__BackingField; // 0x6C

	// Properties
	public byte Type { get; }
	public int Id { get; }
	public GameObject HitObject { get; }
	public float Rad { get; set; }

	// Methods

	// RVA: 0x2514518 Offset: 0x2510518 VA: 0x2514518
	public byte get_Type() { }

	// RVA: 0x2514520 Offset: 0x2510520 VA: 0x2514520
	public int get_Id() { }

	// RVA: 0x2514528 Offset: 0x2510528 VA: 0x2514528
	public GameObject get_HitObject() { }

	[CompilerGenerated]
	// RVA: 0x2514530 Offset: 0x2510530 VA: 0x2514530
	public float get_Rad() { }

	[CompilerGenerated]
	// RVA: 0x2514538 Offset: 0x2510538 VA: 0x2514538
	private void set_Rad(float value) { }

	// RVA: 0x2514540 Offset: 0x2510540 VA: 0x2514540
	public void Initialize(int takeUid, Dictionary<TakeParameterType, int> appendParam, Action callback) { }

	// RVA: 0x25148E4 Offset: 0x25108E4 VA: 0x25148E4
	private void Update() { }

	// RVA: 0x2514C28 Offset: 0x2510C28 VA: 0x2514C28
	public void .ctor() { }
}
