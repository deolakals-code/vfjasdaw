// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyMemberStatusDataLight : BinaryBase, IPartyMemberStatusData // TypeDefIndex: 13005
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <HpRate>k__BackingField; // 0x20

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte HpRate { get; set; }

	// Methods

	// RVA: 0x368BDE8 Offset: 0x3687DE8 VA: 0x368BDE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x368BDF0 Offset: 0x3687DF0 VA: 0x368BDF0 Slot: 9
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x368BDF8 Offset: 0x3687DF8 VA: 0x368BDF8 Slot: 11
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368BE00 Offset: 0x3687E00 VA: 0x368BE00 Slot: 8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x368BE08 Offset: 0x3687E08 VA: 0x368BE08 Slot: 12
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368BE10 Offset: 0x3687E10 VA: 0x368BE10 Slot: 10
	public byte get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x368BE18 Offset: 0x3687E18 VA: 0x368BE18 Slot: 13
	public void set_HpRate(byte value) { }

	// RVA: 0x368BE20 Offset: 0x3687E20 VA: 0x368BE20 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368BE6C Offset: 0x3687E6C VA: 0x368BE6C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
