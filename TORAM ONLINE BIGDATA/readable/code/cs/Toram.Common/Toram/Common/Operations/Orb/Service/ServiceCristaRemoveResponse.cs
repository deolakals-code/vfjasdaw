// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceCristaRemoveResponse : UnityHashBase // TypeDefIndex: 11876
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28

	// Properties
	public GameStatusData GameStatus { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375BB04 Offset: 0x3757B04 VA: 0x375BB04
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375BB0C Offset: 0x3757B0C VA: 0x375BB0C
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375BB14 Offset: 0x3757B14 VA: 0x375BB14
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375BB1C Offset: 0x3757B1C VA: 0x375BB1C
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x375BB24 Offset: 0x3757B24 VA: 0x375BB24
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x375BB2C Offset: 0x3757B2C VA: 0x375BB2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375BB34 Offset: 0x3757B34 VA: 0x375BB34 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375BE0C Offset: 0x3757E0C VA: 0x375BE0C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
