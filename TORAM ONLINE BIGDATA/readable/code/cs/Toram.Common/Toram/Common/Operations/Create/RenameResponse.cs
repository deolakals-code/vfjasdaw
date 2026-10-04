// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class RenameResponse : PacketBase // TypeDefIndex: 11401
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370172C Offset: 0x36FD72C VA: 0x370172C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3701734 Offset: 0x36FD734 VA: 0x3701734
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x370173C Offset: 0x36FD73C VA: 0x370173C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3701744 Offset: 0x36FD744 VA: 0x3701744
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x370174C Offset: 0x36FD74C VA: 0x370174C
	public void set_PaidOrb(int value) { }

	// RVA: 0x3701754 Offset: 0x36FD754 VA: 0x3701754 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370175C Offset: 0x36FD75C VA: 0x370175C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3701914 Offset: 0x36FD914 VA: 0x3701914 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
