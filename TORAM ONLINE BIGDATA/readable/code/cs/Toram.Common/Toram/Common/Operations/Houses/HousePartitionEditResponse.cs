// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HousePartitionEditResponse : OperationRequestBase // TypeDefIndex: 12185
{
	// Fields
	[CompilerGenerated]
	private int[] <RemoveList>k__BackingField; // 0x20

	// Properties
	public int[] RemoveList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DDBA4 Offset: 0x35D9BA4 VA: 0x35DDBA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DDBAC Offset: 0x35D9BAC VA: 0x35DDBAC
	public int[] get_RemoveList() { }

	[CompilerGenerated]
	// RVA: 0x35DDBB4 Offset: 0x35D9BB4 VA: 0x35DDBB4
	public void set_RemoveList(int[] value) { }

	// RVA: 0x35DDBBC Offset: 0x35D9BBC VA: 0x35DDBBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DDBC4 Offset: 0x35D9BC4 VA: 0x35DDBC4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DDBCC Offset: 0x35D9BCC VA: 0x35DDBCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DDD24 Offset: 0x35D9D24 VA: 0x35DDD24 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
