// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HousePartitionEdit : OperationRequestBase // TypeDefIndex: 12184
{
	// Fields
	[CompilerGenerated]
	private int <StartPosition>k__BackingField; // 0x20
	[CompilerGenerated]
	private HousePartitionEditData[] <UpdateList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <RemoveItemList>k__BackingField; // 0x30

	// Properties
	public int StartPosition { get; set; }
	public HousePartitionEditData[] UpdateList { get; set; }
	public int[] RemoveItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DD880 Offset: 0x35D9880 VA: 0x35DD880
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DD888 Offset: 0x35D9888 VA: 0x35DD888
	public int get_StartPosition() { }

	[CompilerGenerated]
	// RVA: 0x35DD890 Offset: 0x35D9890 VA: 0x35DD890
	public void set_StartPosition(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DD898 Offset: 0x35D9898 VA: 0x35DD898
	public HousePartitionEditData[] get_UpdateList() { }

	[CompilerGenerated]
	// RVA: 0x35DD8A0 Offset: 0x35D98A0 VA: 0x35DD8A0
	public void set_UpdateList(HousePartitionEditData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DD8A8 Offset: 0x35D98A8 VA: 0x35DD8A8
	public int[] get_RemoveItemList() { }

	[CompilerGenerated]
	// RVA: 0x35DD8B0 Offset: 0x35D98B0 VA: 0x35DD8B0
	public void set_RemoveItemList(int[] value) { }

	// RVA: 0x35DD8B8 Offset: 0x35D98B8 VA: 0x35DD8B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DD8C0 Offset: 0x35D98C0 VA: 0x35DD8C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DD8C8 Offset: 0x35D98C8 VA: 0x35DD8C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DDAA4 Offset: 0x35D9AA4 VA: 0x35DDAA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
