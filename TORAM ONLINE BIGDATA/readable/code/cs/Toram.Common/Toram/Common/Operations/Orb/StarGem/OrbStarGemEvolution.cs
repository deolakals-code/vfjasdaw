// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemEvolution : OperationRequestBase // TypeDefIndex: 11833
{
	// Fields
	[CompilerGenerated]
	private long <EvolutionGemUid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <EvolutionGemNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <EvolutionSkill>k__BackingField; // 0x2A

	// Properties
	[PacketParameter(Code = 91)]
	public long EvolutionGemUid { get; set; }
	[PacketParameter(Code = 148)]
	public short EvolutionGemNo { get; set; }
	[PacketParameter(Code = 90)]
	public short EvolutionSkill { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3753674 Offset: 0x374F674 VA: 0x3753674
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x375367C Offset: 0x374F67C VA: 0x375367C
	public long get_EvolutionGemUid() { }

	[CompilerGenerated]
	// RVA: 0x3753684 Offset: 0x374F684 VA: 0x3753684
	public void set_EvolutionGemUid(long value) { }

	[CompilerGenerated]
	// RVA: 0x375368C Offset: 0x374F68C VA: 0x375368C
	public short get_EvolutionGemNo() { }

	[CompilerGenerated]
	// RVA: 0x3753694 Offset: 0x374F694 VA: 0x3753694
	public void set_EvolutionGemNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x375369C Offset: 0x374F69C VA: 0x375369C
	public short get_EvolutionSkill() { }

	[CompilerGenerated]
	// RVA: 0x37536A4 Offset: 0x374F6A4 VA: 0x37536A4
	public void set_EvolutionSkill(short value) { }

	// RVA: 0x37536AC Offset: 0x374F6AC VA: 0x37536AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37536B4 Offset: 0x374F6B4 VA: 0x37536B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37536BC Offset: 0x374F6BC VA: 0x37536BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753880 Offset: 0x374F880 VA: 0x3753880 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
