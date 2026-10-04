// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Facility
public class GuildSetFacilityFlag : OperationRequestBase // TypeDefIndex: 12440
{
	// Fields
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 20)]
	public bool IsActive { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360880C Offset: 0x360480C VA: 0x360880C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3608814 Offset: 0x3604814 VA: 0x3608814
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x360881C Offset: 0x360481C VA: 0x360881C
	public void set_IsActive(bool value) { }

	// RVA: 0x3608828 Offset: 0x3604828 VA: 0x3608828 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3608830 Offset: 0x3604830 VA: 0x3608830 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3608838 Offset: 0x3604838 VA: 0x3608838 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36088D8 Offset: 0x36048D8 VA: 0x36088D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
