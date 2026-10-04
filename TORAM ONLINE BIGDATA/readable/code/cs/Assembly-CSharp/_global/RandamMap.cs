// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(RenderSetting))]
[AddComponentMenu("Iruna2/Render/RandamMap")]
public class RandamMap : RandamMapBase // TypeDefIndex: 3992
{
	// Fields
	private MergeFieldObject mergeFieldObject; // 0x70
	private byte[] mapData; // 0x78
	private readonly int[] rootWall; // 0x80
	[SerializeField]
	private Vector3 mapBlock; // 0x88
	[SerializeField]
	private int walltype; // 0x94
	[SerializeField]
	private GameObject[] mapBase; // 0x98
	[SerializeField]
	private AnimationClip[] addAnimationClip; // 0xA0
	[SerializeField]
	private Mesh[] mapBaseFloorCol; // 0xA8
	[SerializeField]
	private Mesh[] mapBaseWallCol; // 0xB0
	[SerializeField]
	private GameObject[] mapWall; // 0xB8
	[SerializeField]
	private Mesh[] mapWallCol; // 0xC0
	[SerializeField]
	private Mesh[] mapWallFloorCol; // 0xC8
	[SerializeField]
	private GameObject[] mapObject; // 0xD0
	[SerializeField]
	private Mesh[] mapObjectCol; // 0xD8
	[SerializeField]
	private GameObject[] mapBackgroundObject; // 0xE0
	[SerializeField]
	private GameObject backgroundObjectParent; // 0xE8
	[SerializeField]
	private MeshCollider floorColLayer; // 0xF0
	[SerializeField]
	private MeshCollider wallColLayer; // 0xF8
	[SerializeField]
	private Texture2D[] miniMapBase; // 0x100
	private Color[] pixel; // 0x108

	// Methods

	// RVA: 0x2432BE4 Offset: 0x242EBE4 VA: 0x2432BE4
	private void Start() { }

	// RVA: 0x2432E48 Offset: 0x242EE48 VA: 0x2432E48 Slot: 4
	protected override void RandamCreate(byte[] roomChipList) { }

	// RVA: 0x2432FA0 Offset: 0x242EFA0 VA: 0x2432FA0
	private void MapByteClear() { }

	// RVA: 0x24346B4 Offset: 0x24306B4 VA: 0x24346B4
	private int BitSearch(int bit, int nomber, int max) { }

	// RVA: 0x24346F4 Offset: 0x24306F4 VA: 0x24346F4 Slot: 5
	public override Vector3 GetMapChipPosition(byte mapChipId, float y) { }

	// RVA: 0x2433048 Offset: 0x242F048 VA: 0x2433048
	private Vector2 RandomMapCreate(byte[] roomNumber) { }

	// RVA: 0x2434740 Offset: 0x2430740 VA: 0x2434740
	private void SetMiniMapChip(int mapId, int rot, int x, int y) { }

	// RVA: 0x24337B0 Offset: 0x242F7B0 VA: 0x24337B0
	private void MapModelMerge() { }

	// RVA: 0x2434A10 Offset: 0x2430A10 VA: 0x2434A10
	public void .ctor() { }
}
