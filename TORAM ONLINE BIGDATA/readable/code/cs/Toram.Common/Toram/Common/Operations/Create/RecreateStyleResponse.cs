// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class RecreateStyleResponse : PacketBase // TypeDefIndex: 11409
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

	// RVA: 0x3702970 Offset: 0x36FE970 VA: 0x3702970
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3702978 Offset: 0x36FE978 VA: 0x3702978
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3702980 Offset: 0x36FE980 VA: 0x3702980
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3702988 Offset: 0x36FE988 VA: 0x3702988
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3702990 Offset: 0x36FE990 VA: 0x3702990
	public void set_PaidOrb(int value) { }

	// RVA: 0x3702998 Offset: 0x36FE998 VA: 0x3702998 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37029A0 Offset: 0x36FE9A0 VA: 0x37029A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3702B58 Offset: 0x36FEB58 VA: 0x3702B58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
