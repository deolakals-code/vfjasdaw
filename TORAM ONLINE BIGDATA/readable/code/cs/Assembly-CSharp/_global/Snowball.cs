// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Snowball : MonoBehaviour // TypeDefIndex: 4489
{
	// Fields
	private const float Gravity = 9.8;
	private const int SplitCount = 4;
	private const string MineLayer = "Player";
	private const string OtherLayer = "OtherPlayer";
	public const float DefaultScale = 0.75;
	public const int SnowballModelId = 701;
	public const int SnowballMotionId = 1;
	public const int MeteorBallModelId = 601;
	public const int MeteorBallMotionId = 1;
	private Vector3 startPos; // 0x20
	private float prevMoveX; // 0x2C
	private float prevMoveY; // 0x30
	private Motion motion; // 0x38
	private float scale; // 0x40
	private float power; // 0x44
	private float angle; // 0x48
	private float height; // 0x4C
	private Vector3 direction; // 0x50
	private float speed; // 0x5C
	private float startTime; // 0x60
	private bool isEnd; // 0x64
	private GameObject hitObject; // 0x68
	private bool isMine; // 0x70
	[CompilerGenerated]
	private bool <IsFloor>k__BackingField; // 0x71
	[CompilerGenerated]
	private bool <IsWall>k__BackingField; // 0x72
	[CompilerGenerated]
	private bool <IsMeteor>k__BackingField; // 0x73

	// Properties
	public bool IsMoveEnd { get; }
	public bool IsFloor { get; set; }
	public bool IsWall { get; set; }
	public bool IsMeteor { get; set; }
	public GameObject HitObject { get; }

	// Methods

	// RVA: 0x2502C0C Offset: 0x24FEC0C VA: 0x2502C0C
	public bool get_IsMoveEnd() { }

	[CompilerGenerated]
	// RVA: 0x2502C14 Offset: 0x24FEC14 VA: 0x2502C14
	public bool get_IsFloor() { }

	[CompilerGenerated]
	// RVA: 0x2502C1C Offset: 0x24FEC1C VA: 0x2502C1C
	private void set_IsFloor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2502C28 Offset: 0x24FEC28 VA: 0x2502C28
	public bool get_IsWall() { }

	[CompilerGenerated]
	// RVA: 0x2502C30 Offset: 0x24FEC30 VA: 0x2502C30
	private void set_IsWall(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2502C3C Offset: 0x24FEC3C VA: 0x2502C3C
	public bool get_IsMeteor() { }

	[CompilerGenerated]
	// RVA: 0x2502C44 Offset: 0x24FEC44 VA: 0x2502C44
	private void set_IsMeteor(bool value) { }

	// RVA: 0x2502C50 Offset: 0x24FEC50 VA: 0x2502C50
	public GameObject get_HitObject() { }

	// RVA: 0x2502C58 Offset: 0x24FEC58 VA: 0x2502C58
	private void Update() { }

	// RVA: 0x2503294 Offset: 0x24FF294 VA: 0x2503294
	public void Throwing(Transform parent, Vector3 position, float scale, float power, float angle, float height, bool isMine, bool meteor) { }

	// RVA: 0x250347C Offset: 0x24FF47C VA: 0x250347C
	public void MotionPlay(int id, WrapMode mode = 0, float speedRate = 1) { }

	// RVA: 0x2502C5C Offset: 0x24FEC5C VA: 0x2502C5C
	private void Move() { }

	// RVA: 0x2503530 Offset: 0x24FF530 VA: 0x2503530
	private bool CheckHitLayer(Vector3 pos, string layerName, float scale, out GameObject hitObject) { }

	// RVA: 0x25036F4 Offset: 0x24FF6F4 VA: 0x25036F4
	public void .ctor() { }
}
