// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChatManager.ChatLog // TypeDefIndex: 1757
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x10
	[CompilerGenerated]
	private HistoryLog.ChatType <ChatType>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RegionCode>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <TimeStamp>k__BackingField; // 0x30

	// Properties
	public int Uuid { get; set; }
	public HistoryLog.ChatType ChatType { get; set; }
	public string UserName { get; set; }
	public string Message { get; set; }
	public byte RegionCode { get; set; }
	public DateTime TimeStamp { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20C8574 Offset: 0x20C4574 VA: 0x20C8574
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x20C857C Offset: 0x20C457C VA: 0x20C857C
	private void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x20C8584 Offset: 0x20C4584 VA: 0x20C8584
	public HistoryLog.ChatType get_ChatType() { }

	[CompilerGenerated]
	// RVA: 0x20C858C Offset: 0x20C458C VA: 0x20C858C
	private void set_ChatType(HistoryLog.ChatType value) { }

	[CompilerGenerated]
	// RVA: 0x20C8594 Offset: 0x20C4594 VA: 0x20C8594
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x20C859C Offset: 0x20C459C VA: 0x20C859C
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x20C85A4 Offset: 0x20C45A4 VA: 0x20C85A4
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x20C85AC Offset: 0x20C45AC VA: 0x20C85AC
	private void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x20C85B4 Offset: 0x20C45B4 VA: 0x20C85B4
	public byte get_RegionCode() { }

	[CompilerGenerated]
	// RVA: 0x20C85BC Offset: 0x20C45BC VA: 0x20C85BC
	private void set_RegionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20C85C4 Offset: 0x20C45C4 VA: 0x20C85C4
	public DateTime get_TimeStamp() { }

	[CompilerGenerated]
	// RVA: 0x20C85CC Offset: 0x20C45CC VA: 0x20C85CC
	private void set_TimeStamp(DateTime value) { }

	// RVA: 0x20C85D4 Offset: 0x20C45D4 VA: 0x20C85D4
	public void .ctor() { }

	// RVA: 0x20C8664 Offset: 0x20C4664 VA: 0x20C8664
	public void .ctor(int uuid, HistoryLog.ChatType type, string userName, string message, byte regionCode) { }

	// RVA: 0x20C5658 Offset: 0x20C1658 VA: 0x20C5658
	public void .ctor(int uuid, HistoryLog.ChatType type, string userName, string message, byte regionCode, DateTime timeStamp) { }

	// RVA: 0x20C86D0 Offset: 0x20C46D0 VA: 0x20C86D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C87F0 Offset: 0x20C47F0 VA: 0x20C87F0 Slot: 0
	public override bool Equals(object obj) { }
}
