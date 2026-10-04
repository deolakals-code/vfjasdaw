// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class OrbEnchantSave : OperationRequestBase // TypeDefIndex: 12135
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TargetType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x25

	// Properties
	public int TargetItemUuid { get; set; }
	public byte TargetType { get; set; }
	public byte Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378E858 Offset: 0x378A858 VA: 0x378E858
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378E860 Offset: 0x378A860 VA: 0x378E860
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378E868 Offset: 0x378A868 VA: 0x378E868
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378E870 Offset: 0x378A870 VA: 0x378E870
	public byte get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x378E878 Offset: 0x378A878 VA: 0x378E878
	public void set_TargetType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378E880 Offset: 0x378A880 VA: 0x378E880
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x378E888 Offset: 0x378A888 VA: 0x378E888
	public void set_Index(byte value) { }

	// RVA: 0x378E890 Offset: 0x378A890 VA: 0x378E890 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378E898 Offset: 0x378A898 VA: 0x378E898 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378E8A0 Offset: 0x378A8A0 VA: 0x378E8A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378E9AC Offset: 0x378A9AC VA: 0x378E9AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
