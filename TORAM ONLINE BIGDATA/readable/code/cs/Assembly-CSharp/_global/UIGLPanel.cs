// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLPanel : MonoBehaviour // TypeDefIndex: 210
{
	// Fields
	private Dictionary<byte, List<UIGLWidget>> list; // 0x20
	[SerializeField]
	private UIAtlas[] atlas; // 0x28
	[SerializeField]
	private UIFont[] fontAtlas; // 0x30
	[SerializeField]
	private byte[] atlasLayerIndex; // 0x38
	[SerializeField]
	private byte[] fontAtlasLayerIndex; // 0x40
	private int[] fontAtlasLayerId; // 0x48
	private Camera thisCamera; // 0x50
	private UISignBoardManager signboardManager; // 0x58

	// Methods

	// RVA: 0x21C07E8 Offset: 0x21BC7E8 VA: 0x21C07E8
	private void Awake() { }

	// RVA: 0x21C092C Offset: 0x21BC92C VA: 0x21C092C
	public void AddUIGLWidget(UIGLWidget widget) { }

	// RVA: 0x21C0C78 Offset: 0x21BCC78 VA: 0x21C0C78
	public void RemoveUIGLWidget(UIGLWidget widget) { }

	// RVA: 0x21C0D60 Offset: 0x21BCD60 VA: 0x21C0D60
	private void LateUpdate() { }

	// RVA: 0x21C1048 Offset: 0x21BD048 VA: 0x21C1048
	public bool CheckAtlasSprite(byte atlasId, string spriteName) { }

	// RVA: 0x21C109C Offset: 0x21BD09C VA: 0x21C109C
	private void OnRenderObject() { }

	// RVA: 0x21C12AC Offset: 0x21BD2AC VA: 0x21C12AC
	private void AtlasDraw(Material atlasMaterial, byte id) { }

	// RVA: 0x21C154C Offset: 0x21BD54C VA: 0x21C154C
	private void DrawD2Signboard() { }

	// RVA: 0x21C1638 Offset: 0x21BD638 VA: 0x21C1638
	public void .ctor() { }
}
