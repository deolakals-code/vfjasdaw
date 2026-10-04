// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class MobPopPoint : MonoBehaviour // TypeDefIndex: 3986
{
	// Fields
	[SerializeField]
	private float rad; // 0x20
	[SerializeField]
	private float height; // 0x24
	[SerializeField]
	private Vector3 size; // 0x28
	[SerializeField]
	private MobPopPoint.DecisionType decision; // 0x34
	[SerializeField]
	private int monsterDatabaseID; // 0x38
	[SerializeField]
	private bool isCreateImitation; // 0x3C
	[SerializeField]
	private int maxPopCount; // 0x40
	[SerializeField]
	private float rot; // 0x44
	[SerializeField]
	private float randomRot; // 0x48
	[SerializeField]
	private bool isBattleWait; // 0x4C
	[SerializeField]
	private bool isImitationFieldMapView; // 0x4D
	private Cylinder cylinder; // 0x50
	private OBB obb; // 0x58
	private bool hasImitation; // 0x60
	private readonly float popImitationInterval; // 0x64
	private float popImitationCounter; // 0x68
	[CompilerGenerated]
	private bool <IsInsidePlayer>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <IsCreatableImitation>k__BackingField; // 0x6D

	// Properties
	public bool IsCreateImitation { get; }
	public bool IsImitationFieldMapView { get; }
	public bool IsInsidePlayer { get; set; }
	public bool IsCreatableImitation { get; set; }
	public int MonsterDatabaseID { get; }
	public int MaxPopCount { get; }
	public bool IsBattleWait { get; }

	// Methods

	// RVA: 0x2431210 Offset: 0x242D210 VA: 0x2431210
	public bool get_IsCreateImitation() { }

	// RVA: 0x2431218 Offset: 0x242D218 VA: 0x2431218
	public bool get_IsImitationFieldMapView() { }

	[CompilerGenerated]
	// RVA: 0x2431220 Offset: 0x242D220 VA: 0x2431220
	public bool get_IsInsidePlayer() { }

	[CompilerGenerated]
	// RVA: 0x2431228 Offset: 0x242D228 VA: 0x2431228
	private void set_IsInsidePlayer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2431234 Offset: 0x242D234 VA: 0x2431234
	public bool get_IsCreatableImitation() { }

	[CompilerGenerated]
	// RVA: 0x243123C Offset: 0x242D23C VA: 0x243123C
	private void set_IsCreatableImitation(bool value) { }

	// RVA: 0x2431248 Offset: 0x242D248 VA: 0x2431248
	public int get_MonsterDatabaseID() { }

	// RVA: 0x2431250 Offset: 0x242D250 VA: 0x2431250
	public int get_MaxPopCount() { }

	// RVA: 0x24312C0 Offset: 0x242D2C0 VA: 0x24312C0
	public bool get_IsBattleWait() { }

	// RVA: 0x24312C8 Offset: 0x242D2C8 VA: 0x24312C8
	private void Start() { }

	// RVA: 0x243142C Offset: 0x242D42C VA: 0x243142C
	private void Update() { }

	// RVA: 0x24314A0 Offset: 0x242D4A0 VA: 0x24314A0
	public void SetImitationFlag() { }

	// RVA: 0x24314B0 Offset: 0x242D4B0 VA: 0x24314B0
	public void ClearImitationFlag() { }

	// RVA: 0x24314C0 Offset: 0x242D4C0 VA: 0x24314C0
	public bool CheckArea(Vector3 pos, float rad, float height) { }

	// RVA: 0x2431540 Offset: 0x242D540 VA: 0x2431540
	public Vector3 GetPopPosition() { }

	// RVA: 0x2431910 Offset: 0x242D910 VA: 0x2431910
	public Vector3 GetPopCenter() { }

	// RVA: 0x2431A68 Offset: 0x242DA68 VA: 0x2431A68
	public float GetRandomRot() { }

	// RVA: 0x2431A90 Offset: 0x242DA90 VA: 0x2431A90
	public void .ctor() { }
}
