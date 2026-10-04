// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CreateNinjutsuScrollReconnectionData : IReconnectionSubData // TypeDefIndex: 5068
{
	// Fields
	private ItemSelectData[] itemDatas; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFBF0 Offset: 0x25EBBF0 VA: 0x25EFBF0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFBF8 Offset: 0x25EBBF8 VA: 0x25EFBF8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFC00 Offset: 0x25EBC00 VA: 0x25EFC00
	public void .ctor(ItemSelectData[] itemDatas) { }

	// RVA: 0x25EFC30 Offset: 0x25EBC30 VA: 0x25EFC30 Slot: 6
	public void Reconnection(Game engine) { }
}
