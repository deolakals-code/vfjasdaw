// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class GlobalChannelChange : OperationRequestBase // TypeDefIndex: 11570
{
	// Fields
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChannelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <AccountWorldType>k__BackingField; // 0x25
	[CompilerGenerated]
	private short <CustomerPlatform>k__BackingField; // 0x26

	// Properties
	public int WorldId { get; set; }
	public byte ChannelId { get; set; }
	public byte AccountWorldType { get; set; }
	public short CustomerPlatform { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371C918 Offset: 0x3718918 VA: 0x371C918
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371C920 Offset: 0x3718920 VA: 0x371C920
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371C928 Offset: 0x3718928 VA: 0x371C928
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371C930 Offset: 0x3718930 VA: 0x371C930
	public byte get_ChannelId() { }

	[CompilerGenerated]
	// RVA: 0x371C938 Offset: 0x3718938 VA: 0x371C938
	public void set_ChannelId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371C940 Offset: 0x3718940 VA: 0x371C940
	public byte get_AccountWorldType() { }

	[CompilerGenerated]
	// RVA: 0x371C948 Offset: 0x3718948 VA: 0x371C948
	public void set_AccountWorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371C950 Offset: 0x3718950 VA: 0x371C950
	public short get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x371C958 Offset: 0x3718958 VA: 0x371C958
	public void set_CustomerPlatform(short value) { }

	// RVA: 0x371C960 Offset: 0x3718960 VA: 0x371C960 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371C968 Offset: 0x3718968 VA: 0x371C968 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371C970 Offset: 0x3718970 VA: 0x371C970 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371CBD0 Offset: 0x3718BD0 VA: 0x371CBD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
