// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaResultManager : UIBasePanelConnection // TypeDefIndex: 6113
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor anchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor bottomRightAnchor; // 0x38
	[SerializeField]
	private UIToggle checkTopToggle; // 0x40
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private bool isParty; // 0x58
	private MobaRoomData roomData; // 0x60
	private GameObject partyTopElement; // 0x68

	// Properties
	public bool IsClose { get; set; }
	private float rankObjPosY { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x188AF08 Offset: 0x1886F08 VA: 0x188AF08
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x188AF10 Offset: 0x1886F10 VA: 0x188AF10
	private void set_IsClose(bool value) { }

	// RVA: 0x188AF1C Offset: 0x1886F1C VA: 0x188AF1C
	private float get_rankObjPosY() { }

	// RVA: 0x188AF3C Offset: 0x1886F3C VA: 0x188AF3C
	private void OnDestroy() { }

	// RVA: 0x188AF9C Offset: 0x1886F9C VA: 0x188AF9C
	public void Initialize() { }

	// RVA: 0x188BB58 Offset: 0x1887B58 VA: 0x188BB58
	public void OnCheckTop() { }

	// RVA: 0x188BA20 Offset: 0x1887A20 VA: 0x188BA20
	private GameObject CreateElement(GameObject elementObj, Transform parent, Vector3 pos, Vector3 scale) { }

	// RVA: 0x188BA00 Offset: 0x1887A00 VA: 0x188BA00
	private void Close() { }

	[IteratorStateMachine(typeof(UIMobaResultManager.<Leave>d__18))]
	// RVA: 0x188BBE8 Offset: 0x1887BE8 VA: 0x188BBE8
	private IEnumerator Leave() { }

	// RVA: 0x188BC7C Offset: 0x1887C7C VA: 0x188BC7C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x188BCF0 Offset: 0x1887CF0 VA: 0x188BCF0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x188BDA4 Offset: 0x1887DA4 VA: 0x188BDA4
	public void .ctor() { }
}
