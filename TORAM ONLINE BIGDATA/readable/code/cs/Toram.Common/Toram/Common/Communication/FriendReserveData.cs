// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class FriendReserveData : UnityHashBase // TypeDefIndex: 12983
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Time>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 66)]
	public string UserName { get; set; }
	[UnityHash(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[UnityHash(Code = 172)]
	public string Time { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36875EC Offset: 0x36835EC VA: 0x36875EC
	public void .ctor() { }

	// RVA: 0x36875F4 Offset: 0x36835F4 VA: 0x36875F4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36875FC Offset: 0x36835FC VA: 0x36875FC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3687604 Offset: 0x3683604 VA: 0x3687604
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368760C Offset: 0x368360C VA: 0x368760C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3687614 Offset: 0x3683614 VA: 0x3687614
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368761C Offset: 0x368361C VA: 0x368761C
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3687624 Offset: 0x3683624 VA: 0x3687624
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x368762C Offset: 0x368362C VA: 0x368762C
	public string get_Time() { }

	[CompilerGenerated]
	// RVA: 0x3687634 Offset: 0x3683634 VA: 0x3687634
	public void set_Time(string value) { }

	// RVA: 0x368763C Offset: 0x368363C VA: 0x368763C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3687644 Offset: 0x3683644 VA: 0x3687644 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3687908 Offset: 0x3683908 VA: 0x3687908 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
