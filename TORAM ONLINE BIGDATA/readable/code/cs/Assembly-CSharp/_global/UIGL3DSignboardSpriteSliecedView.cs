// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGL3DSignboardSpriteSliecedView : UIGL3DSignboardSpriteView // TypeDefIndex: 213
{
	// Fields
	private Vector2 size; // 0x6C
	private Vector3 offset; // 0x74
	private Vector3 scale; // 0x80
	private float[] uvX; // 0x90
	private float[] uvY; // 0x98
	private float[] slicedVertexX; // 0xA0
	private float[] slicedVertexY; // 0xA8
	private float[] drawSlicedVertexX; // 0xB0
	private float[] drawSlicedVertexY; // 0xB8

	// Properties
	public int width { get; set; }
	public int height { get; set; }

	// Methods

	// RVA: 0x21C2460 Offset: 0x21BE460 VA: 0x21C2460
	public int get_width() { }

	// RVA: 0x21C2480 Offset: 0x21BE480 VA: 0x21C2480
	public void set_width(int value) { }

	// RVA: 0x21C248C Offset: 0x21BE48C VA: 0x21C248C
	public int get_height() { }

	// RVA: 0x21C24AC Offset: 0x21BE4AC VA: 0x21C24AC
	public void set_height(int value) { }

	// RVA: 0x21C24B8 Offset: 0x21BE4B8 VA: 0x21C24B8
	public void .ctor(UIAtlas atlas, string spriteName, UIWidget.Pivot pivot, Color color) { }

	// RVA: 0x21C28E4 Offset: 0x21BE8E4 VA: 0x21C28E4 Slot: 4
	public override void SetScale(Vector3 scale) { }

	// RVA: 0x21C2904 Offset: 0x21BE904 VA: 0x21C2904
	public void SetColor(Color color) { }

	// RVA: 0x21C2910 Offset: 0x21BE910 VA: 0x21C2910 Slot: 5
	public override bool OnDraw(Matrix4x4 localToWorldMatrix, Vector3 position) { }
}
