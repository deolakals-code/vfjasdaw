// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbServiceBuyResponse : OperationResponseBase // TypeDefIndex: 11817
{
	// Fields
	[CompilerGenerated]
	private byte <ServiceType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<object, object> <ServiceParam>k__BackingField; // 0x30
	[CompilerGenerated]
	private OrbItemData[] <OrbItemList>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 232)]
	public byte ServiceType { get; set; }
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	[PacketParameter(Code = 18, IsOptional = True)]
	public Dictionary<object, object> ServiceParam { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData[] OrbItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3750E50 Offset: 0x374CE50 VA: 0x3750E50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3750E58 Offset: 0x374CE58 VA: 0x3750E58
	public byte get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x3750E60 Offset: 0x374CE60 VA: 0x3750E60
	public void set_ServiceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3750E68 Offset: 0x374CE68 VA: 0x3750E68
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3750E70 Offset: 0x374CE70 VA: 0x3750E70
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3750E78 Offset: 0x374CE78 VA: 0x3750E78
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3750E80 Offset: 0x374CE80 VA: 0x3750E80
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3750E88 Offset: 0x374CE88 VA: 0x3750E88
	public Dictionary<object, object> get_ServiceParam() { }

	[CompilerGenerated]
	// RVA: 0x3750E90 Offset: 0x374CE90 VA: 0x3750E90
	public void set_ServiceParam(Dictionary<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3750E98 Offset: 0x374CE98 VA: 0x3750E98
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3750EA0 Offset: 0x374CEA0 VA: 0x3750EA0
	public void set_OrbItemList(OrbItemData[] value) { }

	// RVA: 0x3750EA8 Offset: 0x374CEA8 VA: 0x3750EA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3750EB0 Offset: 0x374CEB0 VA: 0x3750EB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3750EB8 Offset: 0x374CEB8 VA: 0x3750EB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37511D0 Offset: 0x374D1D0 VA: 0x37511D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
