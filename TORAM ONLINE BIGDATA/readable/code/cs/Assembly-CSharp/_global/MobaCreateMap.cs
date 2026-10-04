// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaCreateMap : RandamMapBase // TypeDefIndex: 3984
{
	// Fields
	[SerializeField]
	private TextAsset createText; // 0x70
	private int blockNum; // 0x78
	private MergeFieldObject[] mergeFieldObject; // 0x80
	private GameObject[] mergeFieldObjectParent; // 0x88
	private Transform mainCamera; // 0x90
	private byte[] mapData; // 0x98
	private readonly int[] rootWall; // 0xA0
	[SerializeField]
	private Vector3 mapBlock; // 0xA8
	[SerializeField]
	private int walltype; // 0xB4
	[SerializeField]
	private GameObject[] mapBase; // 0xB8
	[SerializeField]
	private AnimationClip[] addAnimationClip; // 0xC0
	[SerializeField]
	private Mesh[] mapBaseFloorCol; // 0xC8
	[SerializeField]
	private Mesh[] mapBaseWallCol; // 0xD0
	[SerializeField]
	private GameObject[] mapWall; // 0xD8
	[SerializeField]
	private Mesh[] mapWallCol; // 0xE0
	[SerializeField]
	private Mesh[] mapWallFloorCol; // 0xE8
	[SerializeField]
	private GameObject[] mapObject; // 0xF0
	[SerializeField]
	private Mesh[] mapObjectCol; // 0xF8
	[SerializeField]
	private GameObject[] mapBackgroundObject; // 0x100
	[SerializeField]
	private GameObject backgroundObjectParent; // 0x108
	[SerializeField]
	private MeshCollider floorColLayer; // 0x110
	[SerializeField]
	private MeshCollider wallColLayer; // 0x118
	[SerializeField]
	private Texture2D[] miniMapBase; // 0x120
	private Color[] pixel; // 0x128

	// Methods

	// RVA: 0x242F75C Offset: 0x242B75C VA: 0x242F75C
	private void Start() { }

	// RVA: 0x2430914 Offset: 0x242C914 VA: 0x2430914
	private void LateUpdate() { }

	// RVA: 0x2430B18 Offset: 0x242CB18 VA: 0x2430B18
	private void SetActivePanel(int[] ids) { }

	// RVA: 0x2430BC4 Offset: 0x242CBC4 VA: 0x2430BC4 Slot: 4
	protected override void RandamCreate(byte[] roomChipList) { }

	// RVA: 0x242FEB0 Offset: 0x242BEB0 VA: 0x242FEB0
	private void MapByteClear() { }

	// RVA: 0x2430BC8 Offset: 0x242CBC8 VA: 0x2430BC8
	private int BitSearch(int bit, int nomber, int max) { }

	// RVA: 0x2430C08 Offset: 0x242CC08 VA: 0x2430C08 Slot: 5
	public override Vector3 GetMapChipPosition(byte mapChipId, float y) { }

	// RVA: 0x242FF58 Offset: 0x242BF58 VA: 0x242FF58
	private Vector2 RandomMapCreate() { }

	// RVA: 0x2430C54 Offset: 0x242CC54 VA: 0x2430C54
	private void SetMiniMapChip(int mapId, int rot, int x, int y) { }

	// RVA: 0x2430220 Offset: 0x242C220 VA: 0x2430220
	private void MapModelMerge() { }

	// RVA: 0x2430F24 Offset: 0x242CF24 VA: 0x2430F24
	public void .ctor() { }
}
