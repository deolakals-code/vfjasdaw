// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceStatusResetResponse : UnityHashBase // TypeDefIndex: 11887
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375E580 Offset: 0x375A580 VA: 0x375E580
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375E588 Offset: 0x375A588 VA: 0x375E588
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x375E590 Offset: 0x375A590 VA: 0x375E590
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375E598 Offset: 0x375A598 VA: 0x375E598
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375E5A0 Offset: 0x375A5A0 VA: 0x375E5A0
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x375E5A8 Offset: 0x375A5A8 VA: 0x375E5A8
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375E7EC Offset: 0x375A7EC VA: 0x375E7EC
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375E8F8 Offset: 0x375A8F8 VA: 0x375E8F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375E900 Offset: 0x375A900 VA: 0x375E900 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375E998 Offset: 0x375A998 VA: 0x375E998 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
