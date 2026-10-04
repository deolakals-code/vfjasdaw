// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINameChangeLabel : UILabel // TypeDefIndex: 171
{
	// Fields
	private UIInput inputData; // 0x180
	private bool isHalfWidth; // 0x188
	private int maxLength; // 0x18C
	private Regex regex; // 0x190
	private float characterCount; // 0x198
	private string checkWord; // 0x1A0

	// Properties
	public Regex ColorCodeRegex { get; }
	public float CharacterCount { get; }

	// Methods

	// RVA: 0x1FD74C8 Offset: 0x1FD34C8 VA: 0x1FD74C8
	public Regex get_ColorCodeRegex() { }

	// RVA: 0x1FD74D0 Offset: 0x1FD34D0 VA: 0x1FD74D0
	public float get_CharacterCount() { }

	// RVA: 0x1FD74D8 Offset: 0x1FD34D8 VA: 0x1FD74D8
	private void Start() { }

	// RVA: 0x1FD7528 Offset: 0x1FD3528 VA: 0x1FD7528
	public void LabelUpdate() { }

	// RVA: 0x1FD787C Offset: 0x1FD387C VA: 0x1FD787C
	public void SetData(UIInput inputData, bool isHalfWidth) { }

	// RVA: 0x1FD7918 Offset: 0x1FD3918 VA: 0x1FD7918
	public void InputTextReprace() { }

	// RVA: 0x1FD7668 Offset: 0x1FD3668 VA: 0x1FD7668
	private string TextAdjustment(string baseText) { }

	// RVA: 0x1FD7AF8 Offset: 0x1FD3AF8 VA: 0x1FD7AF8 Slot: 29
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x1FD8078 Offset: 0x1FD4078 VA: 0x1FD8078
	public void .ctor() { }
}
