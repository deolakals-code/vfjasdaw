// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetNaming : OperationRequestBase // TypeDefIndex: 12318
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PetName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsDirect>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38

	// Properties
	public long PetUuid { get; set; }
	public string PetName { get; set; }
	public int Orb { get; set; }
	public bool IsDirect { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F2644 Offset: 0x35EE644 VA: 0x35F2644
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F264C Offset: 0x35EE64C VA: 0x35F264C
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F2654 Offset: 0x35EE654 VA: 0x35F2654
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F265C Offset: 0x35EE65C VA: 0x35F265C
	public string get_PetName() { }

	[CompilerGenerated]
	// RVA: 0x35F2664 Offset: 0x35EE664 VA: 0x35F2664
	public void set_PetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35F266C Offset: 0x35EE66C VA: 0x35F266C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F2674 Offset: 0x35EE674 VA: 0x35F2674
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F267C Offset: 0x35EE67C VA: 0x35F267C
	public bool get_IsDirect() { }

	[CompilerGenerated]
	// RVA: 0x35F2684 Offset: 0x35EE684 VA: 0x35F2684
	public void set_IsDirect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F2690 Offset: 0x35EE690 VA: 0x35F2690
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F2698 Offset: 0x35EE698 VA: 0x35F2698
	public void set_Gold(int value) { }

	// RVA: 0x35F26A0 Offset: 0x35EE6A0 VA: 0x35F26A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F26A8 Offset: 0x35EE6A8 VA: 0x35F26A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F26B0 Offset: 0x35EE6B0 VA: 0x35F26B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F2924 Offset: 0x35EE924 VA: 0x35F2924 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
