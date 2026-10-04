// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSelectWindow_AutoItem : PopBaseWindow // TypeDefIndex: 8817
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private int baseParam; // 0x30
	private Action<int> retAction; // 0x38
	private string[] selectList; // 0x40
	private int addParam; // 0x48
	private PopUpSelectWindow_AutoItem.SelectData[] selectListEx; // 0x50
	private int messageAction; // 0x58
	private UISelectButton selectButton; // 0x60
	private UILabel descriptionLabel; // 0x68
	private UIIcon titleIconSprite; // 0x70
	private UIIcon selectIconSprite; // 0x78
	private int saveParam; // 0x80

	// Methods

	// RVA: 0x1E13A64 Offset: 0x1E0FA64 VA: 0x1E13A64
	public void .ctor(string title, string message, int baseParam, int add, string[] selectList, PopUpSelectWindow_AutoItem.SelectData[] selectListEx, Action<int> retAction) { }

	// RVA: 0x1E13B70 Offset: 0x1E0FB70 VA: 0x1E13B70 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E14134 Offset: 0x1E10134 VA: 0x1E14134 Slot: 5
	public override void Update() { }

	// RVA: 0x1E14274 Offset: 0x1E10274 VA: 0x1E14274 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E14344 Offset: 0x1E10344 VA: 0x1E14344 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E1434C Offset: 0x1E1034C VA: 0x1E1434C Slot: 8
	public override void Close() { }
}
