// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaKillEvent : EventSubBase // TypeDefIndex: 12669
{
	// Fields
	[CompilerGenerated]
	private int <DeadId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <DeadType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <DeadName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <WinnerId>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <WinnerType>k__BackingField; // 0x34
	[CompilerGenerated]
	private string <WinnerName>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <KillType>k__BackingField; // 0x40

	// Properties
	public int DeadId { get; set; }
	public byte DeadType { get; set; }
	public string DeadName { get; set; }
	public int WinnerId { get; set; }
	public byte WinnerType { get; set; }
	public string WinnerName { get; set; }
	public byte KillType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363DB4C Offset: 0x3639B4C VA: 0x363DB4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363DB54 Offset: 0x3639B54 VA: 0x363DB54
	public int get_DeadId() { }

	[CompilerGenerated]
	// RVA: 0x363DB5C Offset: 0x3639B5C VA: 0x363DB5C
	public void set_DeadId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363DB64 Offset: 0x3639B64 VA: 0x363DB64
	public byte get_DeadType() { }

	[CompilerGenerated]
	// RVA: 0x363DB6C Offset: 0x3639B6C VA: 0x363DB6C
	public void set_DeadType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363DB74 Offset: 0x3639B74 VA: 0x363DB74
	public string get_DeadName() { }

	[CompilerGenerated]
	// RVA: 0x363DB7C Offset: 0x3639B7C VA: 0x363DB7C
	public void set_DeadName(string value) { }

	[CompilerGenerated]
	// RVA: 0x363DB84 Offset: 0x3639B84 VA: 0x363DB84
	public int get_WinnerId() { }

	[CompilerGenerated]
	// RVA: 0x363DB8C Offset: 0x3639B8C VA: 0x363DB8C
	public void set_WinnerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363DB94 Offset: 0x3639B94 VA: 0x363DB94
	public byte get_WinnerType() { }

	[CompilerGenerated]
	// RVA: 0x363DB9C Offset: 0x3639B9C VA: 0x363DB9C
	public void set_WinnerType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363DBA4 Offset: 0x3639BA4 VA: 0x363DBA4
	public string get_WinnerName() { }

	[CompilerGenerated]
	// RVA: 0x363DBAC Offset: 0x3639BAC VA: 0x363DBAC
	public void set_WinnerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x363DBB4 Offset: 0x3639BB4 VA: 0x363DBB4
	public byte get_KillType() { }

	[CompilerGenerated]
	// RVA: 0x363DBBC Offset: 0x3639BBC VA: 0x363DBBC
	public void set_KillType(byte value) { }

	// RVA: 0x363DBC4 Offset: 0x3639BC4 VA: 0x363DBC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363DBCC Offset: 0x3639BCC VA: 0x363DBCC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363DBD4 Offset: 0x3639BD4 VA: 0x363DBD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363DD6C Offset: 0x3639D6C VA: 0x363DD6C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
