// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbListButton : MonoBehaviour // TypeDefIndex: 7600
{
	// Fields
	protected UIOrbShopListPanel manager; // 0x20
	protected int buttonId; // 0x28
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <Size>k__BackingField; // 0x2D
	[SerializeField]
	private UISprite backgroundSprite; // 0x30
	[SerializeField]
	private UITexture backgroundTexture; // 0x38
	protected GameObject mainTexture; // 0x40
	protected GameObject buyTexture; // 0x48
	[SerializeField]
	private GameObject baseFrame; // 0x50
	[SerializeField]
	private GameObject baseFrameEx; // 0x58
	[SerializeField]
	private GameObject effectTextureObj; // 0x60
	protected BoxCollider boxCollider; // 0x68
	protected Dictionary<byte, GameObject> effectDataList; // 0x70

	// Properties
	public byte Index { get; set; }
	public byte Size { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BBD2BC Offset: 0x1BB92BC VA: 0x1BBD2BC
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x1BBD2C4 Offset: 0x1BB92C4 VA: 0x1BBD2C4
	private void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBD2CC Offset: 0x1BB92CC VA: 0x1BBD2CC
	public byte get_Size() { }

	[CompilerGenerated]
	// RVA: 0x1BBD2D4 Offset: 0x1BB92D4 VA: 0x1BBD2D4
	private void set_Size(byte value) { }

	// RVA: 0x1BBD2DC Offset: 0x1BB92DC VA: 0x1BBD2DC
	public void Initialize(UIOrbListButtonDataBase baseData, UIOrbShopListPanel manager) { }

	// RVA: 0x1BBDF90 Offset: 0x1BB9F90 VA: 0x1BBDF90
	private void SpriteBackground(string spriteName, int w, int h) { }

	// RVA: 0x1BBDD3C Offset: 0x1BB9D3C VA: 0x1BBDD3C
	private OrbShopTextureDataAssets GetOrbShopTextureDataAssets(string path, bool localize) { }

	// RVA: 0x1BBE038 Offset: 0x1BBA038 VA: 0x1BBE038
	protected GameObject addCopyGameObject(GameObject baseObj) { }

	// RVA: 0x1BBE200 Offset: 0x1BBA200 VA: 0x1BBE200 Slot: 4
	public virtual void Initialize(UIOrbListButtonDataBase baseData) { }

	// RVA: 0x1BBE204 Offset: 0x1BBA204 VA: 0x1BBE204 Slot: 5
	public virtual void OnClick() { }

	// RVA: 0x1BBD22C Offset: 0x1BB922C VA: 0x1BBD22C
	public void .ctor() { }
}
