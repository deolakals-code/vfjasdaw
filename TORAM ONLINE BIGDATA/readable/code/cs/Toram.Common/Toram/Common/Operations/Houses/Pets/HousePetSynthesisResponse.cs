// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetSynthesisResponse : OperationResponseBase // TypeDefIndex: 12330
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <NewPet>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <RemovePetUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38

	// Properties
	public PetInfoData NewPet { get; set; }
	public long RemovePetUuid { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F4D6C Offset: 0x35F0D6C VA: 0x35F4D6C
	public void .ctor() { }

	// RVA: 0x35F4D74 Offset: 0x35F0D74 VA: 0x35F4D74
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F4D7C Offset: 0x35F0D7C VA: 0x35F4D7C
	public PetInfoData get_NewPet() { }

	[CompilerGenerated]
	// RVA: 0x35F4D84 Offset: 0x35F0D84 VA: 0x35F4D84
	public void set_NewPet(PetInfoData value) { }

	[CompilerGenerated]
	// RVA: 0x35F4D8C Offset: 0x35F0D8C VA: 0x35F4D8C
	public long get_RemovePetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F4D94 Offset: 0x35F0D94 VA: 0x35F4D94
	public void set_RemovePetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F4D9C Offset: 0x35F0D9C VA: 0x35F4D9C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F4DA4 Offset: 0x35F0DA4 VA: 0x35F4DA4
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F4DAC Offset: 0x35F0DAC VA: 0x35F4DAC
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F4DB4 Offset: 0x35F0DB4 VA: 0x35F4DB4
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F4DBC Offset: 0x35F0DBC VA: 0x35F4DBC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F4DC4 Offset: 0x35F0DC4 VA: 0x35F4DC4
	public void set_Gold(int value) { }

	// RVA: 0x35F4DCC Offset: 0x35F0DCC VA: 0x35F4DCC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4EE8 Offset: 0x35F0EE8 VA: 0x35F4EE8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4F64 Offset: 0x35F0F64 VA: 0x35F4F64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F4F6C Offset: 0x35F0F6C VA: 0x35F4F6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F4F74 Offset: 0x35F0F74 VA: 0x35F4F74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F51B8 Offset: 0x35F11B8 VA: 0x35F51B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
