// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.SaveSlot
public class HouseSlotData : UnityHashBase // TypeDefIndex: 12522
{
	// Fields
	[CompilerGenerated]
	private byte <SlotNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private string <Memo>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ObjectNum>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 210)]
	public byte SlotNo { get; set; }
	[UnityHash(Code = 98)]
	public string Memo { get; set; }
	[UnityHash(Code = 92)]
	public short ObjectNum { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3617874 Offset: 0x3613874 VA: 0x3617874
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x361787C Offset: 0x361387C VA: 0x361787C
	public byte get_SlotNo() { }

	[CompilerGenerated]
	// RVA: 0x3617884 Offset: 0x3613884 VA: 0x3617884
	public void set_SlotNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361788C Offset: 0x361388C VA: 0x361788C
	public string get_Memo() { }

	[CompilerGenerated]
	// RVA: 0x3617894 Offset: 0x3613894 VA: 0x3617894
	public void set_Memo(string value) { }

	[CompilerGenerated]
	// RVA: 0x361789C Offset: 0x361389C VA: 0x361789C
	public short get_ObjectNum() { }

	[CompilerGenerated]
	// RVA: 0x36178A4 Offset: 0x36138A4 VA: 0x36178A4
	public void set_ObjectNum(short value) { }

	// RVA: 0x36178AC Offset: 0x36138AC VA: 0x36178AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36178B4 Offset: 0x36138B4 VA: 0x36178B4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3617AD8 Offset: 0x3613AD8 VA: 0x3617AD8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
