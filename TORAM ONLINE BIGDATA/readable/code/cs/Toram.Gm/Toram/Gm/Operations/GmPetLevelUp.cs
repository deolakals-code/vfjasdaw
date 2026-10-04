// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetLevelUp : OperationRequestBase // TypeDefIndex: 17619
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public short Level { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3798EA8 Offset: 0x3794EA8 VA: 0x3798EA8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3798EB0 Offset: 0x3794EB0 VA: 0x3798EB0
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3798EB8 Offset: 0x3794EB8 VA: 0x3798EB8
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3798EC0 Offset: 0x3794EC0 VA: 0x3798EC0
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3798EC8 Offset: 0x3794EC8 VA: 0x3798EC8
	public void set_Level(short value) { }

	// RVA: 0x3798ED0 Offset: 0x3794ED0 VA: 0x3798ED0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3798ED8 Offset: 0x3794ED8 VA: 0x3798ED8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3798EE0 Offset: 0x3794EE0 VA: 0x3798EE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3799058 Offset: 0x3795058 VA: 0x3799058 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
