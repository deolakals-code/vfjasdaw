// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGL3DSignboardLabelView : UIGL3DLabelView // TypeDefIndex: 208
{
	// Fields
	private Matrix4x4 localToWorldMatrix; // 0x80
	private Vector3 size; // 0xC0
	private bool isEnable; // 0xCC

	// Methods

	// RVA: 0x21C0174 Offset: 0x21BC174 VA: 0x21C0174
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, bool encoding) { }

	// RVA: 0x21C0208 Offset: 0x21BC208 VA: 0x21C0208
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding) { }

	// RVA: 0x21C02CC Offset: 0x21BC2CC VA: 0x21C02CC
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding, UILabel.Effect effectStyle, Color effectColor, Vector2 effectDistance) { }

	// RVA: 0x21C03D4 Offset: 0x21BC3D4 VA: 0x21C03D4
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding, UILabel.Effect effectStyle, Color effectColor, Vector2 effectDistance, bool isInitStack) { }

	// RVA: 0x21C04E0 Offset: 0x21BC4E0 VA: 0x21C04E0
	public void SetSize(Vector3 size) { }

	// RVA: 0x21C04EC Offset: 0x21BC4EC VA: 0x21C04EC
	public void SetEnable(bool isEnable) { }

	// RVA: 0x21C04F8 Offset: 0x21BC4F8 VA: 0x21C04F8 Slot: 4
	public override bool OnDraw(Matrix4x4 localToWorldMatrix, Vector3 position) { }

	// RVA: 0x21C0540 Offset: 0x21BC540 VA: 0x21C0540 Slot: 6
	protected override void DrawText(Vector3 pos, Vector3 worldPos, Vector3 matrix, bool vsColor) { }
}
