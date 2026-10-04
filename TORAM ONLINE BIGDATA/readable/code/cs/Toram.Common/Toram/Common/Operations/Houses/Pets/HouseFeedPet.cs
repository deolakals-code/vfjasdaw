// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseFeedPet : OperationRequestBase // TypeDefIndex: 12306
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FoodId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <NotLimitUp>k__BackingField; // 0x34

	// Properties
	public long PetUuid { get; set; }
	public int FoodId { get; set; }
	public int UseOrb { get; set; }
	public int Orb { get; set; }
	public bool NotLimitUp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EFAFC Offset: 0x35EBAFC VA: 0x35EFAFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EFB04 Offset: 0x35EBB04 VA: 0x35EFB04
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EFB0C Offset: 0x35EBB0C VA: 0x35EFB0C
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35EFB14 Offset: 0x35EBB14 VA: 0x35EFB14
	public int get_FoodId() { }

	[CompilerGenerated]
	// RVA: 0x35EFB1C Offset: 0x35EBB1C VA: 0x35EFB1C
	public void set_FoodId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EFB24 Offset: 0x35EBB24 VA: 0x35EFB24
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x35EFB2C Offset: 0x35EBB2C VA: 0x35EFB2C
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EFB34 Offset: 0x35EBB34 VA: 0x35EFB34
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35EFB3C Offset: 0x35EBB3C VA: 0x35EFB3C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EFB44 Offset: 0x35EBB44 VA: 0x35EFB44
	public bool get_NotLimitUp() { }

	[CompilerGenerated]
	// RVA: 0x35EFB4C Offset: 0x35EBB4C VA: 0x35EFB4C
	public void set_NotLimitUp(bool value) { }

	// RVA: 0x35EFB58 Offset: 0x35EBB58 VA: 0x35EFB58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EFB60 Offset: 0x35EBB60 VA: 0x35EFB60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EFB68 Offset: 0x35EBB68 VA: 0x35EFB68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EFE24 Offset: 0x35EBE24 VA: 0x35EFE24 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
