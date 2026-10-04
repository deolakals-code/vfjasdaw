// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetUsePotionResponse : OperationResponseBase // TypeDefIndex: 12331
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private OrbItemData <OrbItem>k__BackingField; // 0x30

	// Properties
	public long PetUuid { get; set; }
	public PetBreedStatusData BreedStatus { get; set; }
	public OrbItemData OrbItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F52F8 Offset: 0x35F12F8 VA: 0x35F52F8
	public void .ctor() { }

	// RVA: 0x35F5300 Offset: 0x35F1300 VA: 0x35F5300
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F5308 Offset: 0x35F1308 VA: 0x35F5308
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F5310 Offset: 0x35F1310 VA: 0x35F5310
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F5318 Offset: 0x35F1318 VA: 0x35F5318
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x35F5320 Offset: 0x35F1320 VA: 0x35F5320
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35F5328 Offset: 0x35F1328 VA: 0x35F5328
	public OrbItemData get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x35F5330 Offset: 0x35F1330 VA: 0x35F5330
	public void set_OrbItem(OrbItemData value) { }

	// RVA: 0x35F5338 Offset: 0x35F1338 VA: 0x35F5338
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F5504 Offset: 0x35F1504 VA: 0x35F5504
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F55AC Offset: 0x35F15AC VA: 0x35F55AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F55B4 Offset: 0x35F15B4 VA: 0x35F55B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F55BC Offset: 0x35F15BC VA: 0x35F55BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F56EC Offset: 0x35F16EC VA: 0x35F56EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
