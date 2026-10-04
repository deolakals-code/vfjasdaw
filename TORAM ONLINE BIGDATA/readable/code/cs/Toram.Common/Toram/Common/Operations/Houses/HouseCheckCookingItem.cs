// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCheckCookingItem : OperationRequestBase // TypeDefIndex: 12155
{
	// Fields
	[CompilerGenerated]
	private int[] <MainList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <SubList>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 148, IsOptional = True)]
	public int[] MainList { get; set; }
	[PacketClass(Code = 237, IsOptional = True)]
	public int[] SubList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37928DC Offset: 0x378E8DC VA: 0x37928DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37928E4 Offset: 0x378E8E4 VA: 0x37928E4
	public int[] get_MainList() { }

	[CompilerGenerated]
	// RVA: 0x37928EC Offset: 0x378E8EC VA: 0x37928EC
	public void set_MainList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x37928F4 Offset: 0x378E8F4 VA: 0x37928F4
	public int[] get_SubList() { }

	[CompilerGenerated]
	// RVA: 0x37928FC Offset: 0x378E8FC VA: 0x37928FC
	public void set_SubList(int[] value) { }

	// RVA: 0x3792904 Offset: 0x378E904 VA: 0x3792904 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379290C Offset: 0x378E90C VA: 0x379290C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3792914 Offset: 0x378E914 VA: 0x3792914 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3792A5C Offset: 0x378EA5C VA: 0x3792A5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
