// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceCuisineCleanUpResponse : UnityHashBase // TypeDefIndex: 11863
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3759788 Offset: 0x3755788 VA: 0x3759788
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3759790 Offset: 0x3755790 VA: 0x3759790
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3759798 Offset: 0x3755798 VA: 0x3759798
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x37597A0 Offset: 0x37557A0 VA: 0x37597A0
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x37597A4 Offset: 0x37557A4 VA: 0x37597A4
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x37597A8 Offset: 0x37557A8 VA: 0x37597A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37597B0 Offset: 0x37557B0 VA: 0x37597B0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3759950 Offset: 0x3755950 VA: 0x3759950 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
