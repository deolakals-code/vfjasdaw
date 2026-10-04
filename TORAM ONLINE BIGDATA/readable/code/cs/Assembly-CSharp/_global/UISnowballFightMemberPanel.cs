// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballFightMemberPanel : MonoBehaviour // TypeDefIndex: 6017
{
	// Fields
	[SerializeField]
	private GameObject memberPanel; // 0x20
	[SerializeField]
	private UILabel enterNumLabel; // 0x28
	[SerializeField]
	private UISprite windowFrame; // 0x30
	[SerializeField]
	private Transform myTeamTrans; // 0x38
	[SerializeField]
	private Transform enemyTeamTrans; // 0x40
	[SerializeField]
	private GameObject myTeamElement; // 0x48
	[SerializeField]
	private GameObject enemyTeamElement; // 0x50
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x58
	private MiniGameRoomData roomData; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private Dictionary<int, GameObject> myTeamList; // 0x70
	private Dictionary<int, GameObject> enemyTeamList; // 0x78
	private bool isPress; // 0x80
	private MiniGameMemberData[] myPrevData; // 0x88
	private MiniGameMemberData[] enemyPrevData; // 0x90
	private int touchId; // 0x98

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x186C038 Offset: 0x1868038 VA: 0x186C038
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x186C040 Offset: 0x1868040 VA: 0x186C040
	private void set_IsOpen(bool value) { }

	// RVA: 0x186C04C Offset: 0x186804C VA: 0x186C04C
	private void Awake() { }

	// RVA: 0x186C054 Offset: 0x1868054 VA: 0x186C054
	private void Update() { }

	// RVA: 0x1868FB0 Offset: 0x1864FB0 VA: 0x1868FB0
	public void Initalize(MiniGameRoomData data) { }

	// RVA: 0x1868FCC Offset: 0x1864FCC VA: 0x1868FCC
	public void Open() { }

	// RVA: 0x186A5BC Offset: 0x18665BC VA: 0x186A5BC
	public void Close() { }

	// RVA: 0x186C860 Offset: 0x1868860 VA: 0x186C860
	private void InitPanel() { }

	// RVA: 0x186C064 Offset: 0x1868064 VA: 0x186C064
	private void UpdatePanel() { }

	// RVA: 0x186CB2C Offset: 0x1868B2C VA: 0x186CB2C
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x186CC70 Offset: 0x1868C70 VA: 0x186CC70
	private void OnPress(bool isPress) { }

	// RVA: 0x186CD28 Offset: 0x1868D28 VA: 0x186CD28
	public void .ctor() { }
}
