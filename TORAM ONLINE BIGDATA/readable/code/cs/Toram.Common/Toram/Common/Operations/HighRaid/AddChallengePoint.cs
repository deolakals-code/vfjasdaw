// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class AddChallengePoint : OperationRequestBase // TypeDefIndex: 11553
{
	// Fields
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<int, byte> <ClientItems>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 153)]
	public byte Index { get; set; }
	[PacketParameter(Code = 148)]
	public Dictionary<int, byte> ClientItems { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3719504 Offset: 0x3715504 VA: 0x3719504
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371950C Offset: 0x371550C VA: 0x371950C
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3719514 Offset: 0x3715514 VA: 0x3719514
	public void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371951C Offset: 0x371551C VA: 0x371951C
	public Dictionary<int, byte> get_ClientItems() { }

	[CompilerGenerated]
	// RVA: 0x3719524 Offset: 0x3715524 VA: 0x3719524
	public void set_ClientItems(Dictionary<int, byte> value) { }

	// RVA: 0x371952C Offset: 0x371552C VA: 0x371952C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719618 Offset: 0x3715618 VA: 0x3719618
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719684 Offset: 0x3715684 VA: 0x3719684 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371968C Offset: 0x371568C VA: 0x371968C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3719694 Offset: 0x3715694 VA: 0x3719694 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3719740 Offset: 0x3715740 VA: 0x3719740 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
