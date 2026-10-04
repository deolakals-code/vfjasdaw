// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Address
public class AddressEasyRegister : OperationRequestBase // TypeDefIndex: 12281
{
	// Fields
	[CompilerGenerated]
	private byte <Town>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AccountProgress>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <HeldGameEventIds>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x30

	// Properties
	public byte Town { get; set; }
	public int AccountProgress { get; set; }
	public byte[] HeldGameEventIds { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EBB58 Offset: 0x35E7B58 VA: 0x35EBB58
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EBB60 Offset: 0x35E7B60 VA: 0x35EBB60
	public byte get_Town() { }

	[CompilerGenerated]
	// RVA: 0x35EBB68 Offset: 0x35E7B68 VA: 0x35EBB68
	public void set_Town(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35EBB70 Offset: 0x35E7B70 VA: 0x35EBB70
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x35EBB78 Offset: 0x35E7B78 VA: 0x35EBB78
	public void set_AccountProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EBB80 Offset: 0x35E7B80 VA: 0x35EBB80
	public byte[] get_HeldGameEventIds() { }

	[CompilerGenerated]
	// RVA: 0x35EBB88 Offset: 0x35E7B88 VA: 0x35EBB88
	public void set_HeldGameEventIds(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35EBB90 Offset: 0x35E7B90 VA: 0x35EBB90
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35EBB98 Offset: 0x35E7B98 VA: 0x35EBB98
	public void set_Flag(byte value) { }

	// RVA: 0x35EBBA0 Offset: 0x35E7BA0 VA: 0x35EBBA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EBBA8 Offset: 0x35E7BA8 VA: 0x35EBBA8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EBBB0 Offset: 0x35E7BB0 VA: 0x35EBBB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35EBE98 Offset: 0x35E7E98 VA: 0x35EBE98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EC124 Offset: 0x35E8124 VA: 0x35EC124 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
