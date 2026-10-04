// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class TreasureBoxBase // TypeDefIndex: 3832
{
	// Fields
	protected PlayerDataManager playerDataManager; // 0x10
	protected List<int> openedBoxId; // 0x18
	protected Dictionary<int, TreasureBoxData> treasureBoxList; // 0x20

	// Properties
	public int[] OpenedBoxId { get; }
	public TreasureBoxData[] TreasureBoxList { get; }

	// Methods

	// RVA: 0x23F2AEC Offset: 0x23EEAEC VA: 0x23F2AEC
	public int[] get_OpenedBoxId() { }

	// RVA: 0x23F2B3C Offset: 0x23EEB3C VA: 0x23F2B3C
	public TreasureBoxData[] get_TreasureBoxList() { }

	// RVA: 0x23EAB78 Offset: 0x23E6B78 VA: 0x23EAB78
	public void .ctor() { }

	// RVA: 0x23F2BE0 Offset: 0x23EEBE0 VA: 0x23F2BE0
	public void OpenTreasureBox(int id) { }

	// RVA: 0x23F2CD4 Offset: 0x23EECD4 VA: 0x23F2CD4
	public void BoxListRemove(int id) { }

	// RVA: 0x23F2D64 Offset: 0x23EED64 VA: 0x23F2D64 Slot: 4
	public virtual void Clear() { }

	// RVA: 0x23F3014 Offset: 0x23EF014 VA: 0x23F3014
	public TreasureBoxData GetTreasureBoxData(int id) { }

	// RVA: 0x23F3084 Offset: 0x23EF084 VA: 0x23F3084
	public byte GetTreasureBoxType(int id) { }

	// RVA: 0x23F309C Offset: 0x23EF09C VA: 0x23F309C
	public void AddOpenedBoxId(int id) { }

	// RVA: 0x23F3140 Offset: 0x23EF140 VA: 0x23F3140
	public bool IsOpenedBox(int id) { }
}
