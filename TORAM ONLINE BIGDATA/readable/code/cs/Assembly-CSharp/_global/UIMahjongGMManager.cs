// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongGMManager : MonoBehaviour // TypeDefIndex: 5902
{
	// Fields
	[SerializeField]
	private UILabel fixParentButtonLabel; // 0x20
	[SerializeField]
	private UILabel fixWaremeButtonLabel; // 0x28
	[SerializeField]
	private UILabel tileListLabel; // 0x30
	[SerializeField]
	private UILabel navigationLabel; // 0x38
	[SerializeField]
	private GameObject completeLabel; // 0x40
	[SerializeField]
	private UIButtonCallAction tileButton; // 0x48
	[SerializeField]
	private Transform tileButtonParent; // 0x50
	private MahjongRoomData roomData; // 0x58
	private List<MahjongMemberData> memberDatas; // 0x60
	private bool isInitialized; // 0x68
	private int selectMemberArchetypeIdIndex; // 0x6C
	private UIMahjongGMManager.OperationType operationType; // 0x70
	private List<int> doraList; // 0x78
	private List<int> uraDoraList; // 0x80
	private const int maxDoraListSize = 5;
	private List<int> handList; // 0x88
	private const int maxHandListSize = 13;
	private int tsumoTileId; // 0x90
	private List<int> rinshanList; // 0x98
	private const int maxRinshanCount = 4;
	private int haiteiTileId; // 0xA0
	private const float completeLabelActiveTime = 2;
	private float completeLabelActiveTimeCount; // 0xA4

	// Methods

	// RVA: 0x183AA48 Offset: 0x1836A48 VA: 0x183AA48
	public void .ctor() { }
}
