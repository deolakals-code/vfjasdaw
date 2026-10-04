// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaMobProperties : PacketBase // TypeDefIndex: 11222
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <HpRate>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ItemId>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <PopAreaNo>k__BackingField; // 0x2C

	// Properties
	public int MobId { get; set; }
	public int HpRate { get; set; }
	public byte State { get; set; }
	public short ItemId { get; set; }
	public byte PopAreaNo { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35DD34C Offset: 0x35D934C VA: 0x35DD34C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DD354 Offset: 0x35D9354 VA: 0x35DD354
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x35DD35C Offset: 0x35D935C VA: 0x35DD35C
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DD364 Offset: 0x35D9364 VA: 0x35DD364
	public int get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x35DD36C Offset: 0x35D936C VA: 0x35DD36C
	public void set_HpRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DD374 Offset: 0x35D9374 VA: 0x35DD374
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35DD37C Offset: 0x35D937C VA: 0x35DD37C
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DD384 Offset: 0x35D9384 VA: 0x35DD384
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35DD38C Offset: 0x35D938C VA: 0x35DD38C
	public void set_ItemId(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DD394 Offset: 0x35D9394 VA: 0x35DD394
	public byte get_PopAreaNo() { }

	[CompilerGenerated]
	// RVA: 0x35DD39C Offset: 0x35D939C VA: 0x35DD39C
	public void set_PopAreaNo(byte value) { }

	// RVA: 0x35DD3A4 Offset: 0x35D93A4 VA: 0x35DD3A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DD3AC Offset: 0x35D93AC VA: 0x35DD3AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35DD56C Offset: 0x35D956C VA: 0x35DD56C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
