// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TellHistoryData // TypeDefIndex: 1764
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RegionCode>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <DateTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <LineCount>k__BackingField; // 0x38
	protected bool isAnnounce; // 0x3C
	private bool isOld; // 0x3D

	// Properties
	public int Id { get; set; }
	public string UserName { get; set; }
	public string Message { get; set; }
	public byte RegionCode { get; set; }
	public DateTime DateTime { get; set; }
	public int LineCount { get; set; }
	public virtual bool IsNewMessage { get; }
	public virtual bool IsMine { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20CCA3C Offset: 0x20C8A3C VA: 0x20CCA3C
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x20CCA44 Offset: 0x20C8A44 VA: 0x20CCA44
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x20CCA4C Offset: 0x20C8A4C VA: 0x20CCA4C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x20CCA54 Offset: 0x20C8A54 VA: 0x20CCA54
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x20CCA5C Offset: 0x20C8A5C VA: 0x20CCA5C
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x20CCA64 Offset: 0x20C8A64 VA: 0x20CCA64
	private void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x20CCA6C Offset: 0x20C8A6C VA: 0x20CCA6C
	public byte get_RegionCode() { }

	[CompilerGenerated]
	// RVA: 0x20CCA74 Offset: 0x20C8A74 VA: 0x20CCA74
	private void set_RegionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20CCA7C Offset: 0x20C8A7C VA: 0x20CCA7C
	public DateTime get_DateTime() { }

	[CompilerGenerated]
	// RVA: 0x20CCA84 Offset: 0x20C8A84 VA: 0x20CCA84
	private void set_DateTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x20CCA8C Offset: 0x20C8A8C VA: 0x20CCA8C
	public int get_LineCount() { }

	[CompilerGenerated]
	// RVA: 0x20CCA94 Offset: 0x20C8A94 VA: 0x20CCA94
	private void set_LineCount(int value) { }

	// RVA: 0x20CCA9C Offset: 0x20C8A9C VA: 0x20CCA9C Slot: 4
	public virtual bool get_IsNewMessage() { }

	// RVA: 0x20CCAA4 Offset: 0x20C8AA4 VA: 0x20CCAA4 Slot: 5
	public virtual bool get_IsMine() { }

	// RVA: 0x20CCAAC Offset: 0x20C8AAC VA: 0x20CCAAC
	public void .ctor() { }

	// RVA: 0x20C6370 Offset: 0x20C2370 VA: 0x20C6370
	public void .ctor(int id, string userName, string message, byte regionCode, DateTime dateTime) { }

	// RVA: 0x20CCB40 Offset: 0x20C8B40 VA: 0x20CCB40
	protected void Init(int id, string userName, string message, byte regionCode, DateTime dateTime) { }

	// RVA: 0x20CCB9C Offset: 0x20C8B9C VA: 0x20CCB9C Slot: 6
	public virtual void AddLineCount(int add) { }

	// RVA: 0x20CCC5C Offset: 0x20C8C5C VA: 0x20CCC5C Slot: 7
	public virtual void SetOld(bool isOld) { }

	// RVA: 0x20CCC68 Offset: 0x20C8C68 VA: 0x20CCC68 Slot: 8
	public virtual void ResponseTell() { }

	// RVA: 0x20CCC6C Offset: 0x20C8C6C VA: 0x20CCC6C Slot: 9
	public virtual string SaveData() { }

	// RVA: 0x20CCE70 Offset: 0x20C8E70 VA: 0x20CCE70 Slot: 10
	public virtual TellHistoryData Copy() { }
}
