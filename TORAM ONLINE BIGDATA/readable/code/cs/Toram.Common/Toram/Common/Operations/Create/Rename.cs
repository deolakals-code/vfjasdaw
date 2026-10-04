// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class Rename : PacketBase // TypeDefIndex: 11400
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	[PacketParameter(Code = 21)]
	public int UseOrb { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3701420 Offset: 0x36FD420 VA: 0x3701420
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3701428 Offset: 0x36FD428 VA: 0x3701428
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3701430 Offset: 0x36FD430 VA: 0x3701430
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3701438 Offset: 0x36FD438 VA: 0x3701438
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3701440 Offset: 0x36FD440 VA: 0x3701440
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3701448 Offset: 0x36FD448 VA: 0x3701448
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x3701450 Offset: 0x36FD450 VA: 0x3701450
	public void set_UseOrb(int value) { }

	// RVA: 0x3701458 Offset: 0x36FD458 VA: 0x3701458 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3701460 Offset: 0x36FD460 VA: 0x3701460 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3701624 Offset: 0x36FD624 VA: 0x3701624 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
