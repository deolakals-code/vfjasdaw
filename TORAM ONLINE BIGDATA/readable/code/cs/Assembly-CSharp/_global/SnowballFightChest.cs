// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballFightChest : MonoBehaviour // TypeDefIndex: 4498
{
	// Fields
	[CompilerGenerated]
	private int <ItemUid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ItemType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <OwnerArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x2C
	public const int ChestModelId = 5;
	public const int ChestMotionId = 6;
	public const int DropModelId = 18;
	public const int DropMotionId = 0;
	private const float Range = 3;
	private const float Angle = 90;
	private const float Sita = 1.5707964;
	private const float Gravity = 0.098;
	private const float Mass = 0.075;
	private const float Power = 0.25;
	private const float Elastic = 0.9;
	private const int DefaultBoundNum = 2;
	private const float DropRange = 2;
	private const float BaseMoveSpeed = 5;
	private const float BaseAccele = 1;
	private const float RecommunicationTime = 3;
	private GameObject chestModel; // 0x30
	private Motion chestMotion; // 0x38
	private FadeAnimationManager chestFade; // 0x40
	private int motionId; // 0x48
	private GameObject dropModel; // 0x50
	private Motion dropMotion; // 0x58
	private SkinnedMeshRenderer dropSkinnedMeshRenderer; // 0x60
	private SnowballFightAvatarData actor; // 0x68
	private Transform actorTransform; // 0x70
	private Transform ownerTransform; // 0x78
	private bool isDrop; // 0x80
	private bool isLocalDrop; // 0x81
	private SnowballFightChest.State state; // 0x84
	private float time; // 0x88
	private float vy; // 0x8C
	private int boundCount; // 0x90
	private float moveSpeed; // 0x94
	private float accele; // 0x98
	private FieldRayPick fieldRayPick; // 0xA0
	private float waitTimer; // 0xA8

	// Properties
	public int ItemUid { get; set; }
	public byte ItemType { get; set; }
	public int OwnerArchetypeId { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2506104 Offset: 0x2502104 VA: 0x2506104
	public int get_ItemUid() { }

	[CompilerGenerated]
	// RVA: 0x250610C Offset: 0x250210C VA: 0x250610C
	private void set_ItemUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x2506114 Offset: 0x2502114 VA: 0x2506114
	public byte get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x250611C Offset: 0x250211C VA: 0x250611C
	private void set_ItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2506124 Offset: 0x2502124 VA: 0x2506124
	public int get_OwnerArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x250612C Offset: 0x250212C VA: 0x250612C
	private void set_OwnerArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2506134 Offset: 0x2502134 VA: 0x2506134
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x250613C Offset: 0x250213C VA: 0x250613C
	private void set_IsEnd(bool value) { }

	// RVA: 0x2506148 Offset: 0x2502148 VA: 0x2506148
	private void Start() { }

	// RVA: 0x250614C Offset: 0x250214C VA: 0x250614C
	private void Update() { }

	// RVA: 0x25067A0 Offset: 0x25027A0 VA: 0x25067A0
	public void OnDestroy() { }

	// RVA: 0x25068A8 Offset: 0x25028A8 VA: 0x25068A8
	public void Initialized(SnowballFightAvatarData actor, Transform actorTransform, int itemUid) { }

	// RVA: 0x2506CF8 Offset: 0x2502CF8 VA: 0x2506CF8
	public void OnGetItem(int archetypeId, Transform ownerTransform, byte itemType) { }

	// RVA: 0x2506F68 Offset: 0x2502F68 VA: 0x2506F68
	public void FailureGetItem() { }

	// RVA: 0x2506F70 Offset: 0x2502F70 VA: 0x2506F70
	public bool OnUseItem(int archetype) { }

	// RVA: 0x2506F98 Offset: 0x2502F98 VA: 0x2506F98
	public void ForceEnd() { }

	// RVA: 0x2506BA0 Offset: 0x2502BA0 VA: 0x2506BA0
	public static GameObject CreateChestModel() { }

	// RVA: 0x2506C94 Offset: 0x2502C94 VA: 0x2506C94
	public static GameObject CreateDropModel() { }

	// RVA: 0x2506280 Offset: 0x2502280 VA: 0x2506280
	private void UpdateChest() { }

	// RVA: 0x2506318 Offset: 0x2502318 VA: 0x2506318
	private void UpdateDrop() { }

	// RVA: 0x2506360 Offset: 0x2502360 VA: 0x2506360
	private void UpdateGet() { }

	// RVA: 0x25066E4 Offset: 0x25026E4 VA: 0x25066E4
	private void UpdateWait() { }

	// RVA: 0x2507034 Offset: 0x2503034 VA: 0x2507034
	private void DropInitialize() { }

	// RVA: 0x2507104 Offset: 0x2503104 VA: 0x2507104
	private bool Jump(float elastic) { }

	// RVA: 0x2506C04 Offset: 0x2502C04 VA: 0x2506C04
	private void PlayPop() { }

	// RVA: 0x2506FA4 Offset: 0x2502FA4 VA: 0x2506FA4
	private void PlayWita() { }

	// RVA: 0x2506ED8 Offset: 0x2502ED8 VA: 0x2506ED8
	private void PlayOpen() { }

	// RVA: 0x2506D54 Offset: 0x2502D54 VA: 0x2506D54
	private void ChangeDropColor(byte itemType) { }

	// RVA: 0x2507254 Offset: 0x2503254 VA: 0x2507254
	public void .ctor() { }
}
