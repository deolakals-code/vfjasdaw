// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetOwnershipUpdateResponse : OperationResponseBase // TypeDefIndex: 12322
{
	// Fields
	[CompilerGenerated]
	private bool <IsUpdate>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetEntityData[] <Pets>k__BackingField; // 0x28

	// Properties
	public bool IsUpdate { get; set; }
	public PetEntityData[] Pets { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F312C Offset: 0x35EF12C VA: 0x35F312C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F3134 Offset: 0x35EF134 VA: 0x35F3134
	public bool get_IsUpdate() { }

	[CompilerGenerated]
	// RVA: 0x35F313C Offset: 0x35EF13C VA: 0x35F313C
	public void set_IsUpdate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F3148 Offset: 0x35EF148 VA: 0x35F3148
	public PetEntityData[] get_Pets() { }

	[CompilerGenerated]
	// RVA: 0x35F3150 Offset: 0x35EF150 VA: 0x35F3150
	public void set_Pets(PetEntityData[] value) { }

	// RVA: 0x35F3158 Offset: 0x35EF158 VA: 0x35F3158
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3248 Offset: 0x35EF248 VA: 0x35F3248
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F32D4 Offset: 0x35EF2D4 VA: 0x35F32D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F32DC Offset: 0x35EF2DC VA: 0x35F32DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F32E4 Offset: 0x35EF2E4 VA: 0x35F32E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3414 Offset: 0x35EF414 VA: 0x35F3414 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
