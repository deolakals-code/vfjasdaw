// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeStartEvent_ : EventSubBase // TypeDefIndex: 12897
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <SenderInventoryEmptyNum>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <SenderStarGemEmptyNum>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x40
	[CompilerGenerated]
	private short[] <TargetInventoryEmptyNum>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <TargetStarGemEmptyNum>k__BackingField; // 0x50

	// Properties
	public int SenderId { get; set; }
	public string SenderName { get; set; }
	public short[] SenderInventoryEmptyNum { get; set; }
	public short SenderStarGemEmptyNum { get; set; }
	public int TargetId { get; set; }
	public string TargetName { get; set; }
	public short[] TargetInventoryEmptyNum { get; set; }
	public short TargetStarGemEmptyNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3671F2C Offset: 0x366DF2C VA: 0x3671F2C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3671F34 Offset: 0x366DF34 VA: 0x3671F34
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3671F3C Offset: 0x366DF3C VA: 0x3671F3C
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671F44 Offset: 0x366DF44 VA: 0x3671F44
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x3671F4C Offset: 0x366DF4C VA: 0x3671F4C
	public void set_SenderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3671F54 Offset: 0x366DF54 VA: 0x3671F54
	public short[] get_SenderInventoryEmptyNum() { }

	[CompilerGenerated]
	// RVA: 0x3671F5C Offset: 0x366DF5C VA: 0x3671F5C
	public void set_SenderInventoryEmptyNum(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3671F64 Offset: 0x366DF64 VA: 0x3671F64
	public short get_SenderStarGemEmptyNum() { }

	[CompilerGenerated]
	// RVA: 0x3671F6C Offset: 0x366DF6C VA: 0x3671F6C
	public void set_SenderStarGemEmptyNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x3671F74 Offset: 0x366DF74 VA: 0x3671F74
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3671F7C Offset: 0x366DF7C VA: 0x3671F7C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671F84 Offset: 0x366DF84 VA: 0x3671F84
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3671F8C Offset: 0x366DF8C VA: 0x3671F8C
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3671F94 Offset: 0x366DF94 VA: 0x3671F94
	public short[] get_TargetInventoryEmptyNum() { }

	[CompilerGenerated]
	// RVA: 0x3671F9C Offset: 0x366DF9C VA: 0x3671F9C
	public void set_TargetInventoryEmptyNum(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3671FA4 Offset: 0x366DFA4 VA: 0x3671FA4
	public short get_TargetStarGemEmptyNum() { }

	[CompilerGenerated]
	// RVA: 0x3671FAC Offset: 0x366DFAC VA: 0x3671FAC
	public void set_TargetStarGemEmptyNum(short value) { }

	// RVA: 0x3671FB4 Offset: 0x366DFB4 VA: 0x3671FB4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3671FBC Offset: 0x366DFBC VA: 0x3671FBC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3671FC4 Offset: 0x366DFC4 VA: 0x3671FC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3672150 Offset: 0x366E150 VA: 0x3672150 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
