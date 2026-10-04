// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions
public class CompanionCheckRespawnTime : OperationRequestBase // TypeDefIndex: 11383
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FEDA4 Offset: 0x36FADA4 VA: 0x36FEDA4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FEDAC Offset: 0x36FADAC VA: 0x36FEDAC
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36FEDB4 Offset: 0x36FADB4 VA: 0x36FEDB4
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FEDBC Offset: 0x36FADBC VA: 0x36FEDBC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36FEDC4 Offset: 0x36FADC4 VA: 0x36FEDC4
	public void set_ArchetypeId(int value) { }

	// RVA: 0x36FEDCC Offset: 0x36FADCC VA: 0x36FEDCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FEDD4 Offset: 0x36FADD4 VA: 0x36FEDD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FEDDC Offset: 0x36FADDC VA: 0x36FEDDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FEF54 Offset: 0x36FAF54 VA: 0x36FEF54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
