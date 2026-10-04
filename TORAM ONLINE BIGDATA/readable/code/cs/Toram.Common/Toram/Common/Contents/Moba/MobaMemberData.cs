// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaMemberData : BinaryBase // TypeDefIndex: 11220
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <PartyId>k__BackingField; // 0x29

	// Properties
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte State { get; set; }
	public byte PartyId { get; set; }

	// Methods

	// RVA: 0x35DCC70 Offset: 0x35D8C70 VA: 0x35DCC70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DCC78 Offset: 0x35D8C78 VA: 0x35DCC78
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x35DCC80 Offset: 0x35D8C80 VA: 0x35DCC80
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DCC88 Offset: 0x35D8C88 VA: 0x35DCC88
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x35DCC90 Offset: 0x35D8C90 VA: 0x35DCC90
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35DCC98 Offset: 0x35D8C98 VA: 0x35DCC98
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35DCCA0 Offset: 0x35D8CA0 VA: 0x35DCCA0
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DCCA8 Offset: 0x35D8CA8 VA: 0x35DCCA8
	public byte get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x35DCCB0 Offset: 0x35D8CB0 VA: 0x35DCCB0
	public void set_PartyId(byte value) { }

	// RVA: 0x35DCCB8 Offset: 0x35D8CB8 VA: 0x35DCCB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x35DD040 Offset: 0x35D9040 VA: 0x35DD040 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DD09C Offset: 0x35D909C VA: 0x35DD09C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DCD58 Offset: 0x35D8D58 VA: 0x35DCD58
	public static string ToStringState(byte state) { }
}
