// Assembly: Toram.Common.dll
// Namespace: Toram.Common.MiniGame
public class SummerMemberData : BinaryBase // TypeDefIndex: 11161
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x28

	// Properties
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte State { get; set; }

	// Methods

	// RVA: 0x35CCE14 Offset: 0x35C8E14 VA: 0x35CCE14
	public void .ctor() { }

	// RVA: 0x35CCE1C Offset: 0x35C8E1C VA: 0x35CCE1C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35CCE24 Offset: 0x35C8E24 VA: 0x35CCE24
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x35CCE2C Offset: 0x35C8E2C VA: 0x35CCE2C
	protected void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CCE34 Offset: 0x35C8E34 VA: 0x35CCE34
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x35CCE3C Offset: 0x35C8E3C VA: 0x35CCE3C
	protected void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35CCE44 Offset: 0x35C8E44 VA: 0x35CCE44
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35CCE4C Offset: 0x35C8E4C VA: 0x35CCE4C
	protected void set_State(byte value) { }

	// RVA: 0x35CCE54 Offset: 0x35C8E54 VA: 0x35CCE54
	public bool IsLogin() { }

	// RVA: 0x35CCE60 Offset: 0x35C8E60 VA: 0x35CCE60
	public bool IsLeaved() { }

	// RVA: 0x35CCE6C Offset: 0x35C8E6C VA: 0x35CCE6C
	public bool IsDead() { }

	// RVA: 0x35CCE78 Offset: 0x35C8E78 VA: 0x35CCE78 Slot: 3
	public override string ToString() { }

	// RVA: 0x35CCFB0 Offset: 0x35C8FB0 VA: 0x35CCFB0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CD0DC Offset: 0x35C90DC VA: 0x35CD0DC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
