// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceCreateMapObject : MonoBehaviour // TypeDefIndex: 3861
{
	// Fields
	[SerializeField]
	private int mapWidth; // 0x20
	[SerializeField]
	private int mapHeight; // 0x24
	[SerializeField]
	private Vector3 mapBlock; // 0x28
	[SerializeField]
	private List<GameObject> mapObject; // 0x38
	[SerializeField]
	private GameObject[] mapBase; // 0x40
	[SerializeField]
	private AnimationClip[] addAnimationClip; // 0x48
	[SerializeField]
	private Mesh[] mapBaseFloorCol; // 0x50
	[SerializeField]
	private Mesh[] mapBaseWallCol; // 0x58
	[SerializeField]
	private GameObject[] mapWall; // 0x60
	[SerializeField]
	private Mesh[] mapWallCol; // 0x68
	[SerializeField]
	private Mesh[] mapWallFloorCol; // 0x70
	[SerializeField]
	private MeshCollider floorColLayer; // 0x78
	[SerializeField]
	private MeshCollider wallColLayer; // 0x80
	private MergeFieldObject mergeFieldObject; // 0x88
	[SerializeField]
	private Texture2D[] miniMapBase; // 0x90
	private Color[] pixel; // 0x98
	protected Texture2D miniMap; // 0xA0

	// Properties
	public Texture2D MiniMap { get; }

	// Methods

	// RVA: 0x23FC524 Offset: 0x23F8524 VA: 0x23FC524
	public Texture2D get_MiniMap() { }

	// RVA: 0x23FC52C Offset: 0x23F852C VA: 0x23FC52C
	private void Start() { }

	// RVA: 0x23FC878 Offset: 0x23F8878 VA: 0x23FC878
	public void Create() { }

	// RVA: 0x23FC914 Offset: 0x23F8914 VA: 0x23FC914
	private void MapModelMerge() { }

	// RVA: 0x23FD604 Offset: 0x23F9604 VA: 0x23FD604
	private void SetMiniMapChip(DefenceMapChip mapChip, int rot) { }

	// RVA: 0x23FD880 Offset: 0x23F9880 VA: 0x23FD880
	public void .ctor() { }
}
