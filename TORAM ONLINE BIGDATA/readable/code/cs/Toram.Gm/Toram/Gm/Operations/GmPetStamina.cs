// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetStamina : OperationRequestBase // TypeDefIndex: 17624
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Stamina>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public short Stamina { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3799D30 Offset: 0x3795D30 VA: 0x3799D30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3799D38 Offset: 0x3795D38 VA: 0x3799D38
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3799D40 Offset: 0x3795D40 VA: 0x3799D40
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3799D48 Offset: 0x3795D48 VA: 0x3799D48
	public short get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x3799D50 Offset: 0x3795D50 VA: 0x3799D50
	public void set_Stamina(short value) { }

	// RVA: 0x3799D58 Offset: 0x3795D58 VA: 0x3799D58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3799D60 Offset: 0x3795D60 VA: 0x3799D60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3799D68 Offset: 0x3795D68 VA: 0x3799D68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3799EE0 Offset: 0x3795EE0 VA: 0x3799EE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
