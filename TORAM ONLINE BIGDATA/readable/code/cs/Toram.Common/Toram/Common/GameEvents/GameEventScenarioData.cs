// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents
public class GameEventScenarioData : BinaryBase // TypeDefIndex: 11180
{
	// Fields
	private byte[] flags; // 0x20
	[CompilerGenerated]
	private bool <IsUpdate>k__BackingField; // 0x28

	// Properties
	public int FlagRenge { get; }

	// Methods

	// RVA: 0x35D30F8 Offset: 0x35CF0F8 VA: 0x35D30F8
	public void .ctor() { }

	// RVA: 0x35D3100 Offset: 0x35CF100 VA: 0x35D3100
	public void .ctor(int length) { }

	// RVA: 0x35D3170 Offset: 0x35CF170 VA: 0x35D3170
	public void .ctor(byte[] binary) { }

	// RVA: 0x35D3178 Offset: 0x35CF178 VA: 0x35D3178
	public int get_FlagRenge() { }

	// RVA: 0x35D3190 Offset: 0x35CF190 VA: 0x35D3190 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D3328 Offset: 0x35CF328 VA: 0x35D3328
	public byte GetFlagValue(byte idx) { }

	// RVA: 0x35D33DC Offset: 0x35CF3DC VA: 0x35D33DC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D34DC Offset: 0x35CF4DC VA: 0x35D34DC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
