// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetNamingResponse : OperationResponseBase // TypeDefIndex: 12319
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PetName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38

	// Properties
	public long PetUuid { get; set; }
	public string PetName { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F2A80 Offset: 0x35EEA80 VA: 0x35F2A80
	public void .ctor() { }

	// RVA: 0x35F2A88 Offset: 0x35EEA88 VA: 0x35F2A88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F2A90 Offset: 0x35EEA90 VA: 0x35F2A90
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F2A98 Offset: 0x35EEA98 VA: 0x35F2A98
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F2AA0 Offset: 0x35EEAA0 VA: 0x35F2AA0
	public string get_PetName() { }

	[CompilerGenerated]
	// RVA: 0x35F2AA8 Offset: 0x35EEAA8 VA: 0x35F2AA8
	public void set_PetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35F2AB0 Offset: 0x35EEAB0 VA: 0x35F2AB0
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F2AB8 Offset: 0x35EEAB8 VA: 0x35F2AB8
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F2AC0 Offset: 0x35EEAC0 VA: 0x35F2AC0
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F2AC8 Offset: 0x35EEAC8 VA: 0x35F2AC8
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F2AD0 Offset: 0x35EEAD0 VA: 0x35F2AD0
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F2AD8 Offset: 0x35EEAD8 VA: 0x35F2AD8
	public void set_Gold(int value) { }

	// RVA: 0x35F2AE0 Offset: 0x35EEAE0 VA: 0x35F2AE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F2AE8 Offset: 0x35EEAE8 VA: 0x35F2AE8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F2AF0 Offset: 0x35EEAF0 VA: 0x35F2AF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F2D7C Offset: 0x35EED7C VA: 0x35F2D7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
