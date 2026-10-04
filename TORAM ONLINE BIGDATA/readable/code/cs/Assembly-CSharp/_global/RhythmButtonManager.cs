// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RhythmButtonManager : MonoBehaviour // TypeDefIndex: 6190
{
	// Fields
	protected int id; // 0x20
	private Rect range; // 0x24
	private Camera worldCamera; // 0x38
	private Vector3 touchKeepPos; // 0x40
	private Vector3 touchOutPos; // 0x4C
	protected Action<int, int> touchAction; // 0x58
	private int fingerId; // 0x60
	private const int savingFrameCount = 2;
	private const float flickSpeed = 0.0001;
	private bool isFlickDone; // 0x64
	private List<Vector3> saveKeepPosList; // 0x68
	private Vector3 flickStartPos; // 0x70
	private Vector3 flickEndPos; // 0x7C

	// Methods

	// RVA: 0x18B4420 Offset: 0x18B0420 VA: 0x18B4420 Slot: 4
	public virtual void Initialize(int id, Rect range, Camera worldCamera, Action<int, int> touch) { }

	// RVA: 0x18B44D8 Offset: 0x18B04D8 VA: 0x18B44D8
	public void SetFlickDone() { }

	// RVA: 0x18B44E4 Offset: 0x18B04E4 VA: 0x18B44E4 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x18B4884 Offset: 0x18B0884 VA: 0x18B4884
	private bool CheckFlick(Vector3 pos, out RhythmNotesData.NotesType flickType) { }

	// RVA: 0x18B4C60 Offset: 0x18B0C60 VA: 0x18B4C60
	private RhythmNotesData.NotesType GetFlickState(Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x18B4CE8 Offset: 0x18B0CE8 VA: 0x18B4CE8
	private bool CheckTouchButton(Vector3 pos) { }

	// RVA: 0x18B4674 Offset: 0x18B0674 VA: 0x18B4674
	private bool CheckDown() { }

	// RVA: 0x18B4758 Offset: 0x18B0758 VA: 0x18B4758
	private bool CheckPress() { }

	// RVA: 0x18B4B78 Offset: 0x18B0B78 VA: 0x18B4B78
	private bool CheckUp() { }

	// RVA: 0x18B4DF4 Offset: 0x18B0DF4 VA: 0x18B4DF4
	private bool IsScreenTouch(out Vector3 touchPos) { }

	// RVA: 0x18B4AA4 Offset: 0x18B0AA4 VA: 0x18B4AA4
	private bool CheckScreenUp(out int fingerId) { }

	// RVA: 0x18B4D2C Offset: 0x18B0D2C VA: 0x18B4D2C
	private Vector3 GetTouchWorldPosition(Vector3 pos) { }

	// RVA: 0x18B4F1C Offset: 0x18B0F1C VA: 0x18B4F1C
	private Vector3 GetTouchPosition() { }

	// RVA: 0x18B5020 Offset: 0x18B1020 VA: 0x18B5020
	public void .ctor() { }
}
