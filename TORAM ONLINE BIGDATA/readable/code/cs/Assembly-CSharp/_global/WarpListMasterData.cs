// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarpListMasterData // TypeDefIndex: 1871
{
	// Fields
	[CompilerGenerated]
	private int <ListId>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<WarpListRowData> <Rows>k__BackingField; // 0x18

	// Properties
	public int ListId { get; set; }
	public List<WarpListRowData> Rows { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20F7BC4 Offset: 0x20F3BC4 VA: 0x20F7BC4
	public int get_ListId() { }

	[CompilerGenerated]
	// RVA: 0x20F7BCC Offset: 0x20F3BCC VA: 0x20F7BCC
	private void set_ListId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20F7BD4 Offset: 0x20F3BD4 VA: 0x20F7BD4
	public List<WarpListRowData> get_Rows() { }

	[CompilerGenerated]
	// RVA: 0x20F7BDC Offset: 0x20F3BDC VA: 0x20F7BDC
	private void set_Rows(List<WarpListRowData> value) { }

	// RVA: 0x20F79D0 Offset: 0x20F39D0 VA: 0x20F79D0
	public void .ctor(BinaryReader reader) { }

	// RVA: 0x20F7D28 Offset: 0x20F3D28 VA: 0x20F7D28
	public List<WarpListRowData> GetRowDataList(short parentCategory) { }

	// RVA: 0x20F7E20 Offset: 0x20F3E20 VA: 0x20F7E20
	public bool TryGetRowData(short index, out WarpListRowData data) { }
}
