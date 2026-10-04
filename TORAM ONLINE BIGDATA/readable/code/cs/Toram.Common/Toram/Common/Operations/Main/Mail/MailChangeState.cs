// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailChangeState : OperationRequestBase // TypeDefIndex: 12019
{
	// Fields
	[CompilerGenerated]
	private Dictionary<long, byte> <UpdateStates>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public Dictionary<long, byte> UpdateStates { get; set; }

	// Methods

	// RVA: 0x37785C4 Offset: 0x37745C4 VA: 0x37785C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37785CC Offset: 0x37745CC VA: 0x37785CC Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x37785D4 Offset: 0x37745D4 VA: 0x37785D4
	public Dictionary<long, byte> get_UpdateStates() { }

	[CompilerGenerated]
	// RVA: 0x37785DC Offset: 0x37745DC VA: 0x37785DC
	public void set_UpdateStates(Dictionary<long, byte> value) { }

	// RVA: 0x37785E4 Offset: 0x37745E4 VA: 0x37785E4
	public void .ctor() { }

	// RVA: 0x37785EC Offset: 0x37745EC VA: 0x37785EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3778660 Offset: 0x3774660 VA: 0x3778660 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
