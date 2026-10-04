// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaEquipData : PacketBase // TypeDefIndex: 11212
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, int> <EquipLocation>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <Equips>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <Update>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <Refine>k__BackingField; // 0x38
	[CompilerGenerated]
	private short[] <SupplyEquips>k__BackingField; // 0x40

	// Properties
	public Dictionary<byte, int> EquipLocation { get; set; }
	public ItemDatav2[] Equips { get; set; }
	public byte[] Update { get; set; }
	public byte[] Refine { get; set; }
	public short[] SupplyEquips { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D93F8 Offset: 0x35D53F8 VA: 0x35D93F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DA7A8 Offset: 0x35D67A8 VA: 0x35DA7A8
	public Dictionary<byte, int> get_EquipLocation() { }

	[CompilerGenerated]
	// RVA: 0x35DA7B0 Offset: 0x35D67B0 VA: 0x35DA7B0
	public void set_EquipLocation(Dictionary<byte, int> value) { }

	[CompilerGenerated]
	// RVA: 0x35DA7B8 Offset: 0x35D67B8 VA: 0x35DA7B8
	public ItemDatav2[] get_Equips() { }

	[CompilerGenerated]
	// RVA: 0x35DA7C0 Offset: 0x35D67C0 VA: 0x35DA7C0
	public void set_Equips(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA7C8 Offset: 0x35D67C8 VA: 0x35DA7C8
	public byte[] get_Update() { }

	[CompilerGenerated]
	// RVA: 0x35DA7D0 Offset: 0x35D67D0 VA: 0x35DA7D0
	public void set_Update(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA7D8 Offset: 0x35D67D8 VA: 0x35DA7D8
	public byte[] get_Refine() { }

	[CompilerGenerated]
	// RVA: 0x35DA7E0 Offset: 0x35D67E0 VA: 0x35DA7E0
	public void set_Refine(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA7E8 Offset: 0x35D67E8 VA: 0x35DA7E8
	public short[] get_SupplyEquips() { }

	[CompilerGenerated]
	// RVA: 0x35DA7F0 Offset: 0x35D67F0 VA: 0x35DA7F0
	public void set_SupplyEquips(short[] value) { }

	// RVA: 0x35DA7F8 Offset: 0x35D67F8 VA: 0x35DA7F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DA800 Offset: 0x35D6800 VA: 0x35DA800 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35DA94C Offset: 0x35D694C VA: 0x35DA94C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
