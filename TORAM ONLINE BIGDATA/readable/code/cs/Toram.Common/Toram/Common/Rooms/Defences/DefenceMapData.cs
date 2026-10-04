// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Defences
public class DefenceMapData : BinaryBase // TypeDefIndex: 11320
{
	// Fields
	[CompilerGenerated]
	private DefenceMapChip[] <MapChips>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobPopChip[] <MobPopChips>k__BackingField; // 0x28

	// Properties
	public DefenceMapChip[] MapChips { get; set; }
	public MobPopChip[] MobPopChips { get; set; }

	// Methods

	// RVA: 0x36DEED8 Offset: 0x36DAED8 VA: 0x36DEED8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36DF93C Offset: 0x36DB93C VA: 0x36DF93C
	public DefenceMapChip[] get_MapChips() { }

	[CompilerGenerated]
	// RVA: 0x36DF944 Offset: 0x36DB944 VA: 0x36DF944
	public void set_MapChips(DefenceMapChip[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DF94C Offset: 0x36DB94C VA: 0x36DF94C
	public MobPopChip[] get_MobPopChips() { }

	[CompilerGenerated]
	// RVA: 0x36DF954 Offset: 0x36DB954 VA: 0x36DF954
	public void set_MobPopChips(MobPopChip[] value) { }

	// RVA: 0x36DF95C Offset: 0x36DB95C VA: 0x36DF95C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DFB4C Offset: 0x36DBB4C VA: 0x36DFB4C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
