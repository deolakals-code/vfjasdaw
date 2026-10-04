// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Mob.Buff
public class MobBuffData : UnityHashBase // TypeDefIndex: 12486
{
	// Fields
	[CompilerGenerated]
	private short <Id>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Time>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int[] <Vals>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private ActionAppendData <ApeendData>k__BackingField; // 0x30

	// Properties
	public short Id { get; set; }
	public int Time { get; set; }
	public int[] Vals { get; set; }
	public int Flag { get; set; }
	public ActionAppendData ApeendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360EB44 Offset: 0x360AB44 VA: 0x360EB44
	public void .ctor() { }

	// RVA: 0x360EB4C Offset: 0x360AB4C VA: 0x360EB4C
	public void .ctor(Dictionary<object, object> dictionary) { }

	[CompilerGenerated]
	// RVA: 0x360EB54 Offset: 0x360AB54 VA: 0x360EB54
	public short get_Id() { }

	[CompilerGenerated]
	// RVA: 0x360EB5C Offset: 0x360AB5C VA: 0x360EB5C
	public void set_Id(short value) { }

	[CompilerGenerated]
	// RVA: 0x360EB64 Offset: 0x360AB64 VA: 0x360EB64
	public int get_Time() { }

	[CompilerGenerated]
	// RVA: 0x360EB6C Offset: 0x360AB6C VA: 0x360EB6C
	public void set_Time(int value) { }

	[CompilerGenerated]
	// RVA: 0x360EB74 Offset: 0x360AB74 VA: 0x360EB74
	public int[] get_Vals() { }

	[CompilerGenerated]
	// RVA: 0x360EB7C Offset: 0x360AB7C VA: 0x360EB7C
	public void set_Vals(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x360EB84 Offset: 0x360AB84 VA: 0x360EB84
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x360EB8C Offset: 0x360AB8C VA: 0x360EB8C
	public void set_Flag(int value) { }

	[CompilerGenerated]
	// RVA: 0x360EB94 Offset: 0x360AB94 VA: 0x360EB94
	public ActionAppendData get_ApeendData() { }

	[CompilerGenerated]
	// RVA: 0x360EB9C Offset: 0x360AB9C VA: 0x360EB9C
	public void set_ApeendData(ActionAppendData value) { }

	// RVA: 0x360EBA4 Offset: 0x360ABA4 VA: 0x360EBA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360EBAC Offset: 0x360ABAC VA: 0x360EBAC Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x360EDB8 Offset: 0x360ADB8 VA: 0x360EDB8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
