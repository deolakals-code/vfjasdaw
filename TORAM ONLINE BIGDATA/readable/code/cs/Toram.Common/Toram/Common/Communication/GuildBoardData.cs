// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildBoardData : UnityHashBase // TypeDefIndex: 12984
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 66, IsOptional = True)]
	public string UserName { get; set; }
	[UnityHash(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[UnityHash(Code = 172, IsOptional = True)]
	public DateTime Time { get; set; }
	[UnityHash(Code = 245, IsOptional = True)]
	public byte Type { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3687A90 Offset: 0x3683A90 VA: 0x3687A90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3687A98 Offset: 0x3683A98 VA: 0x3687A98
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3687AA0 Offset: 0x3683AA0 VA: 0x3687AA0
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3687AA8 Offset: 0x3683AA8 VA: 0x3687AA8
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3687AB0 Offset: 0x3683AB0 VA: 0x3687AB0
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3687AB8 Offset: 0x3683AB8 VA: 0x3687AB8
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3687AC0 Offset: 0x3683AC0 VA: 0x3687AC0
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3687AC8 Offset: 0x3683AC8 VA: 0x3687AC8
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x3687AD0 Offset: 0x3683AD0 VA: 0x3687AD0
	public void set_Time(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3687AD8 Offset: 0x3683AD8 VA: 0x3687AD8
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3687AE0 Offset: 0x3683AE0 VA: 0x3687AE0
	public void set_Type(byte value) { }

	// RVA: 0x3687AE8 Offset: 0x3683AE8 VA: 0x3687AE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3687AF0 Offset: 0x3683AF0 VA: 0x3687AF0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3687ED4 Offset: 0x3683ED4 VA: 0x3687ED4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
