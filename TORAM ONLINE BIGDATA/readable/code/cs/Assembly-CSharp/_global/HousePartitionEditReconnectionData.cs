// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HousePartitionEditReconnectionData : IReconnectionSubData // TypeDefIndex: 4895
{
	// Fields
	private int startPosition; // 0x10
	private HousePartitionEditData[] updateList; // 0x18
	private int[] removeList; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC6FC Offset: 0x25E86FC VA: 0x25EC6FC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC704 Offset: 0x25E8704 VA: 0x25EC704 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC70C Offset: 0x25E870C VA: 0x25EC70C
	public void .ctor(int startPosition, HousePartitionEditData[] updateList, int[] removeList) { }

	// RVA: 0x25EC760 Offset: 0x25E8760 VA: 0x25EC760 Slot: 6
	public void Reconnection(Game engine) { }
}
