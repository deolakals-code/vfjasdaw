// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Pets
public class PetJoin : OperationRequestBase // TypeDefIndex: 11499
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3713C70 Offset: 0x370FC70 VA: 0x3713C70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3713C78 Offset: 0x370FC78 VA: 0x3713C78
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3713C80 Offset: 0x370FC80 VA: 0x3713C80
	public void set_PetUuid(long value) { }

	// RVA: 0x3713C88 Offset: 0x370FC88 VA: 0x3713C88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3713C90 Offset: 0x370FC90 VA: 0x3713C90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3713C98 Offset: 0x370FC98 VA: 0x3713C98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3713DB8 Offset: 0x370FDB8 VA: 0x3713DB8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
