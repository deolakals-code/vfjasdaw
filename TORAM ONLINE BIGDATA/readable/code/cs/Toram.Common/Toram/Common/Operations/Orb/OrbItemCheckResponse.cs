// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbItemCheckResponse : OperationResponseBase // TypeDefIndex: 11810
{
	// Fields
	[CompilerGenerated]
	private OrbItemData <OrbItem>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData OrbItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374F98C Offset: 0x374B98C VA: 0x374F98C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374F994 Offset: 0x374B994 VA: 0x374F994
	public OrbItemData get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x374F99C Offset: 0x374B99C VA: 0x374F99C
	public void set_OrbItem(OrbItemData value) { }

	// RVA: 0x374F9A4 Offset: 0x374B9A4 VA: 0x374F9A4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374FAC0 Offset: 0x374BAC0 VA: 0x374FAC0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374FB3C Offset: 0x374BB3C VA: 0x374FB3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374FB44 Offset: 0x374BB44 VA: 0x374FB44 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374FB4C Offset: 0x374BB4C VA: 0x374FB4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374FBE4 Offset: 0x374BBE4 VA: 0x374FBE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
