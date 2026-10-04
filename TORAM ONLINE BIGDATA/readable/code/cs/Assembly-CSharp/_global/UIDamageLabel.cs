// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDamageLabel : MonoBehaviour // TypeDefIndex: 6488
{
	// Fields
	private float timer; // 0x20
	private float moveTimer; // 0x24
	private Vector3 movePos; // 0x28
	private Vector3 startPos; // 0x34

	// Methods

	// RVA: 0x1958EA4 Offset: 0x1954EA4 VA: 0x1958EA4
	private void TweenPosition_Begin(float time, Vector3 pos) { }

	// RVA: 0x1958F0C Offset: 0x1954F0C VA: 0x1958F0C
	public bool BattleDamageLabel(string text, Color setColor, float size, Vector3 basePosition, Vector3 targetPosition, float scale, float shakeWidth = 0) { }

	// RVA: 0x195956C Offset: 0x195556C VA: 0x195956C
	public void CopyTransformDamageLabel(string text, GameObject copyBase, float scale, Vector3 offset) { }

	// RVA: 0x1959A58 Offset: 0x1955A58 VA: 0x1959A58
	public void PopUpLabel(string text, Color setColor, float size, Vector3 basePosition, float scale) { }

	// RVA: 0x1959D98 Offset: 0x1955D98 VA: 0x1959D98
	public void PopDownLabel(string text, Color setColor, float size, Vector3 basePosition, float scale) { }

	// RVA: 0x1959B44 Offset: 0x1955B44 VA: 0x1959B44
	private void PopMoveLabel(string text, Color setColor, float size, Vector3 basePosition, Vector3 move, float scale) { }

	// RVA: 0x1959E84 Offset: 0x1955E84 VA: 0x1959E84
	public void BreakPartsLabel(string text, Color setColor, float size, Vector3 basePosition, Vector3 targetPosition, float scale) { }

	// RVA: 0x19592A8 Offset: 0x19552A8 VA: 0x19592A8
	private bool GetScreenVec(Vector3 basePosition, Vector3 targetPosition) { }

	// RVA: 0x19591AC Offset: 0x19551AC VA: 0x19591AC
	private Vector3 GetScreenPosition(Vector3 position, float size) { }

	// RVA: 0x1959334 Offset: 0x1955334 VA: 0x1959334
	private IUILabel SetBattleLabel(string text, Color color, float size, UIWidget.Pivot pivot) { }

	// RVA: 0x1959704 Offset: 0x1955704 VA: 0x1959704
	private IUILabel CopyBattleLabel(string text, GameObject copyBase) { }

	// RVA: 0x195A1EC Offset: 0x19561EC VA: 0x195A1EC
	private void Update() { }

	// RVA: 0x195A37C Offset: 0x195637C VA: 0x195A37C
	public void .ctor() { }
}
