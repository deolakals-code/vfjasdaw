// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballAnnouce : MonoBehaviour // TypeDefIndex: 6007
{
	// Fields
	[SerializeField]
	private UILabel waitLabel; // 0x20
	[SerializeField]
	private UILabel annouceLabel; // 0x28
	[SerializeField]
	private UILabel numLabel; // 0x30
	[SerializeField]
	private UILabel itemLabel; // 0x38
	private MiniGameRoomData roomData; // 0x40
	private TweenScale annouceScale; // 0x48
	private TweenScale numberScale; // 0x50
	private bool isStartPrint; // 0x58
	private SystemTextManager systemTextManager; // 0x60

	// Properties
	public bool IsWaitEnable { get; }
	public bool IsAnnouceEnable { get; }
	public bool IsNumEnable { get; }
	public bool IsItenAnnounceEnable { get; }

	// Methods

	// RVA: 0x1864B1C Offset: 0x1860B1C VA: 0x1864B1C
	public bool get_IsWaitEnable() { }

	// RVA: 0x1864B38 Offset: 0x1860B38 VA: 0x1864B38
	public bool get_IsAnnouceEnable() { }

	// RVA: 0x1864B54 Offset: 0x1860B54 VA: 0x1864B54
	public bool get_IsNumEnable() { }

	// RVA: 0x1864B70 Offset: 0x1860B70 VA: 0x1864B70
	public bool get_IsItenAnnounceEnable() { }

	// RVA: 0x1864B8C Offset: 0x1860B8C VA: 0x1864B8C
	private void Start() { }

	// RVA: 0x1864C74 Offset: 0x1860C74 VA: 0x1864C74
	private void Update() { }

	// RVA: 0x18652D0 Offset: 0x18612D0 VA: 0x18652D0
	public void SetRoomData(MiniGameRoomData roomData) { }

	// RVA: 0x18652D8 Offset: 0x18612D8 VA: 0x18652D8
	public void SetAllEnable(bool isEnable) { }

	// RVA: 0x1864F34 Offset: 0x1860F34 VA: 0x1864F34
	public void SetWaitEnable(bool isEnable) { }

	// RVA: 0x186534C Offset: 0x186134C VA: 0x186534C
	public void SetAnnouceEnable(bool isEnable) { }

	// RVA: 0x1864F54 Offset: 0x1860F54 VA: 0x1864F54
	public void SetNumberEnable(bool isEnable) { }

	// RVA: 0x1864F74 Offset: 0x1860F74 VA: 0x1864F74
	public void SetItemEnable(bool isEnable) { }

	// RVA: 0x1864E20 Offset: 0x1860E20 VA: 0x1864E20
	public void PlayAnnouce(string text, bool isScale) { }

	// RVA: 0x18653D8 Offset: 0x18613D8 VA: 0x18653D8
	public void PlayItemAnnounce(string text) { }

	[IteratorStateMachine(typeof(UISnowballAnnouce.<CloseAnnouce>d__27))]
	// RVA: 0x186536C Offset: 0x186136C VA: 0x186536C
	private IEnumerator CloseAnnouce() { }

	// RVA: 0x1864F94 Offset: 0x1860F94 VA: 0x1864F94
	private void UpdateTimer() { }

	[IteratorStateMachine(typeof(UISnowballAnnouce.<MoveItemAnnounce>d__29))]
	// RVA: 0x1865454 Offset: 0x1861454 VA: 0x1865454
	private IEnumerator MoveItemAnnounce() { }

	// RVA: 0x1865510 Offset: 0x1861510 VA: 0x1865510
	public void .ctor() { }
}
