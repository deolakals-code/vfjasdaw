// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailGetBoxResponse : OperationResponseBase // TypeDefIndex: 12016
{
	// Fields
	[CompilerGenerated]
	private MailHeaderData[] <MailList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MailDeliveryData[] <DeliveryList>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <ServerTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <MailType>k__BackingField; // 0x40
	[CompilerGenerated]
	private Dictionary<long, byte> <UpdateMailStates>k__BackingField; // 0x48

	// Properties
	public MailHeaderData[] MailList { get; set; }
	public MailDeliveryData[] DeliveryList { get; set; }
	public DateTime ServerTime { get; set; }
	public int[] MailCounts { get; set; }
	public byte MailType { get; set; }
	public Dictionary<long, byte> UpdateMailStates { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3777970 Offset: 0x3773970 VA: 0x3777970
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3777978 Offset: 0x3773978 VA: 0x3777978
	public MailHeaderData[] get_MailList() { }

	[CompilerGenerated]
	// RVA: 0x3777980 Offset: 0x3773980 VA: 0x3777980
	public void set_MailList(MailHeaderData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3777988 Offset: 0x3773988 VA: 0x3777988
	public MailDeliveryData[] get_DeliveryList() { }

	[CompilerGenerated]
	// RVA: 0x3777990 Offset: 0x3773990 VA: 0x3777990
	public void set_DeliveryList(MailDeliveryData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3777998 Offset: 0x3773998 VA: 0x3777998
	public DateTime get_ServerTime() { }

	[CompilerGenerated]
	// RVA: 0x37779A0 Offset: 0x37739A0 VA: 0x37779A0
	public void set_ServerTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x37779A8 Offset: 0x37739A8 VA: 0x37779A8
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x37779B0 Offset: 0x37739B0 VA: 0x37779B0
	public void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x37779B8 Offset: 0x37739B8 VA: 0x37779B8
	public byte get_MailType() { }

	[CompilerGenerated]
	// RVA: 0x37779C0 Offset: 0x37739C0 VA: 0x37779C0
	public void set_MailType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37779C8 Offset: 0x37739C8 VA: 0x37779C8
	public Dictionary<long, byte> get_UpdateMailStates() { }

	[CompilerGenerated]
	// RVA: 0x37779D0 Offset: 0x37739D0 VA: 0x37779D0
	public void set_UpdateMailStates(Dictionary<long, byte> value) { }

	// RVA: 0x37779D8 Offset: 0x37739D8 VA: 0x37779D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37779E0 Offset: 0x37739E0 VA: 0x37779E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37779E8 Offset: 0x37739E8 VA: 0x37779E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3777D44 Offset: 0x3773D44 VA: 0x3777D44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
