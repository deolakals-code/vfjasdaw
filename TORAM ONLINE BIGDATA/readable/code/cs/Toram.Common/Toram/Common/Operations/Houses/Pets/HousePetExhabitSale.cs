// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetExhabitSale : OperationRequestBase // TypeDefIndex: 12295
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ExhabitType>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Password>k__BackingField; // 0x34

	// Properties
	public byte No { get; set; }
	public int Price { get; set; }
	public long PetUuid { get; set; }
	public byte ExhabitType { get; set; }
	public int Password { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EDEE8 Offset: 0x35E9EE8 VA: 0x35EDEE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EDEF0 Offset: 0x35E9EF0 VA: 0x35EDEF0
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35EDEF8 Offset: 0x35E9EF8 VA: 0x35EDEF8
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35EDF00 Offset: 0x35E9F00 VA: 0x35EDF00
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x35EDF08 Offset: 0x35E9F08 VA: 0x35EDF08
	public void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EDF10 Offset: 0x35E9F10 VA: 0x35EDF10
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EDF18 Offset: 0x35E9F18 VA: 0x35EDF18
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35EDF20 Offset: 0x35E9F20 VA: 0x35EDF20
	public byte get_ExhabitType() { }

	[CompilerGenerated]
	// RVA: 0x35EDF28 Offset: 0x35E9F28 VA: 0x35EDF28
	public void set_ExhabitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35EDF30 Offset: 0x35E9F30 VA: 0x35EDF30
	public int get_Password() { }

	[CompilerGenerated]
	// RVA: 0x35EDF38 Offset: 0x35E9F38 VA: 0x35EDF38
	public void set_Password(int value) { }

	// RVA: 0x35EDF40 Offset: 0x35E9F40 VA: 0x35EDF40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EDF48 Offset: 0x35E9F48 VA: 0x35EDF48 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EDF50 Offset: 0x35E9F50 VA: 0x35EDF50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EE0CC Offset: 0x35EA0CC VA: 0x35EE0CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
