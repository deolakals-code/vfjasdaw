// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AreaBonusResultReconnectionData : IReconnectionData // TypeDefIndex: 5051
{
	// Fields
	private short bounusGauge; // 0x10
	private short bounusMaxGauge; // 0x12
	private Dictionary<int, int> subdueMobs; // 0x18
	private bool resultThrough; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x21

	// Properties
	public byte State { get; set; }
	public byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25EF578 Offset: 0x25EB578 VA: 0x25EF578
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x25EF580 Offset: 0x25EB580 VA: 0x25EF580
	private void set_State(byte value) { }

	// RVA: 0x25EF588 Offset: 0x25EB588 VA: 0x25EF588 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF590 Offset: 0x25EB590 VA: 0x25EF590
	public void .ctor(short bounusGauge, short bounusMaxGauge, Dictionary<int, int> subdueMobs, bool resultThrough, byte state) { }

	// RVA: 0x25EF5F4 Offset: 0x25EB5F4 VA: 0x25EF5F4 Slot: 5
	public void Reconnection(Game engine) { }
}
