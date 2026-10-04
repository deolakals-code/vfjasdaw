// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents.Summer
public class SummerLobbyData : BinaryBase // TypeDefIndex: 11185
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <MemberNum>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsLinkParty>k__BackingField; // 0x38

	// Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public short MemberNum { get; set; }
	public DateTime StartTime { get; set; }
	public bool IsLinkParty { get; set; }

	// Methods

	// RVA: 0x35D435C Offset: 0x35D035C VA: 0x35D435C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D4364 Offset: 0x35D0364 VA: 0x35D4364
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35D436C Offset: 0x35D036C VA: 0x35D436C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D4374 Offset: 0x35D0374 VA: 0x35D4374
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x35D437C Offset: 0x35D037C VA: 0x35D437C
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x35D4384 Offset: 0x35D0384 VA: 0x35D4384
	public short get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x35D438C Offset: 0x35D038C VA: 0x35D438C
	public void set_MemberNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D4394 Offset: 0x35D0394 VA: 0x35D4394
	public DateTime get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x35D439C Offset: 0x35D039C VA: 0x35D439C
	public void set_StartTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D43A4 Offset: 0x35D03A4 VA: 0x35D43A4
	public bool get_IsLinkParty() { }

	[CompilerGenerated]
	// RVA: 0x35D43AC Offset: 0x35D03AC VA: 0x35D43AC
	public void set_IsLinkParty(bool value) { }

	// RVA: 0x35D43B8 Offset: 0x35D03B8 VA: 0x35D43B8
	public int GetMemberNum() { }

	// RVA: 0x35D43C0 Offset: 0x35D03C0 VA: 0x35D43C0
	public bool IsOnlyAcquaintance() { }

	// RVA: 0x35D43CC Offset: 0x35D03CC VA: 0x35D43CC
	public bool IsOnlyParty() { }

	// RVA: 0x35D43D8 Offset: 0x35D03D8 VA: 0x35D43D8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D4530 Offset: 0x35D0530 VA: 0x35D4530 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
