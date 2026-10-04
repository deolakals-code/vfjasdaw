// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class EnterField : PacketBase // TypeDefIndex: 11547
{
	// Fields
	[CompilerGenerated]
	private int <ViewPersons>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 195)]
	public int ViewPersons { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37181E4 Offset: 0x37141E4 VA: 0x37181E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37181EC Offset: 0x37141EC VA: 0x37181EC
	public int get_ViewPersons() { }

	[CompilerGenerated]
	// RVA: 0x37181F4 Offset: 0x37141F4 VA: 0x37181F4
	public void set_ViewPersons(int value) { }

	// RVA: 0x37181FC Offset: 0x37141FC VA: 0x37181FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3718204 Offset: 0x3714204 VA: 0x3718204 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37182D4 Offset: 0x37142D4 VA: 0x37182D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
