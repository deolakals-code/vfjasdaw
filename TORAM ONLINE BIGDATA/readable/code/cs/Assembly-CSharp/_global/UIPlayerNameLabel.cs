// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerNameLabel : UINameLabel // TypeDefIndex: 9014
{
	// Fields
	private PlayerObjectBase otherPlayer; // 0x88
	private OptionBlock optionBlock; // 0x90
	private float updateCount; // 0x98
	private float hideTimer; // 0x9C
	private UIPlayerNameLabel.ColorMemberType isColorMember; // 0xA0
	private int saveColor; // 0xA4
	private bool isBan; // 0xA8
	private float height; // 0xAC
	private MiniGameRoomData roomData; // 0xB0
	[SerializeField]
	private GameObject moodMessageObject; // 0xB8
	private IUILabel moodMessageLabel; // 0xC0

	// Properties
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E9200C Offset: 0x1E8E00C VA: 0x1E9200C Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E9201C Offset: 0x1E8E01C VA: 0x1E9201C Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E920AC Offset: 0x1E8E0AC VA: 0x1E920AC
	public void Initialize(Transform traceObject, string name, float height) { }

	// RVA: 0x1E9238C Offset: 0x1E8E38C VA: 0x1E9238C
	public void SetTapEnabled(bool enabled) { }

	// RVA: 0x1E92398 Offset: 0x1E8E398 VA: 0x1E92398
	private void UpdateTapEnabled() { }

	// RVA: 0x1E92464 Offset: 0x1E8E464 VA: 0x1E92464 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E9221C Offset: 0x1E8E21C VA: 0x1E9221C
	private void NameColorUpdate(bool ban) { }

	// RVA: 0x1E92C68 Offset: 0x1E8EC68 VA: 0x1E92C68
	private void MiniGameUpdate() { }

	// RVA: 0x1E93084 Offset: 0x1E8F084 VA: 0x1E93084 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E93330 Offset: 0x1E8F330 VA: 0x1E93330
	public void .ctor() { }
}
