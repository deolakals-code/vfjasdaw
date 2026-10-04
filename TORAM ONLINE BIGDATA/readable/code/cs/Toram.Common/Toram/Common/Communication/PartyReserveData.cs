// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class PartyReserveData : UnityHashBase // TypeDefIndex: 12998
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Time>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 94)]
	public int PartyId { get; set; }
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 66, IsOptional = True)]
	public string UserName { get; set; }
	[UnityHash(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[UnityHash(Code = 172, IsOptional = True)]
	public string Time { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3689D84 Offset: 0x3685D84 VA: 0x3689D84
	public void .ctor() { }

	// RVA: 0x3689D8C Offset: 0x3685D8C VA: 0x3689D8C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3689D94 Offset: 0x3685D94 VA: 0x3689D94
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x3689D9C Offset: 0x3685D9C VA: 0x3689D9C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3689DA4 Offset: 0x3685DA4 VA: 0x3689DA4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3689DAC Offset: 0x3685DAC VA: 0x3689DAC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3689DB4 Offset: 0x3685DB4 VA: 0x3689DB4
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3689DBC Offset: 0x3685DBC VA: 0x3689DBC
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3689DC4 Offset: 0x3685DC4 VA: 0x3689DC4
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3689DCC Offset: 0x3685DCC VA: 0x3689DCC
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3689DD4 Offset: 0x3685DD4 VA: 0x3689DD4
	public string get_Time() { }

	[CompilerGenerated]
	// RVA: 0x3689DDC Offset: 0x3685DDC VA: 0x3689DDC
	public void set_Time(string value) { }

	// RVA: 0x3689DE4 Offset: 0x3685DE4 VA: 0x3689DE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3689DEC Offset: 0x3685DEC VA: 0x3689DEC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x368A17C Offset: 0x368617C VA: 0x368A17C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
