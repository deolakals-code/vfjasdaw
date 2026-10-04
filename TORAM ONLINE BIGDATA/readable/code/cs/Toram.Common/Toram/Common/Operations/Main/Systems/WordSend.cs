// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class WordSend : PacketBase // TypeDefIndex: 11942
{
	// Fields
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Word>k__BackingField; // 0x28

	// Properties
	public int Index { get; set; }
	public string Word { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376B3A4 Offset: 0x37673A4 VA: 0x376B3A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376B3AC Offset: 0x37673AC VA: 0x376B3AC
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x376B3B4 Offset: 0x37673B4 VA: 0x376B3B4
	public void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x376B3BC Offset: 0x37673BC VA: 0x376B3BC
	public string get_Word() { }

	[CompilerGenerated]
	// RVA: 0x376B3C4 Offset: 0x37673C4 VA: 0x376B3C4
	public void set_Word(string value) { }

	// RVA: 0x376B3CC Offset: 0x37673CC VA: 0x376B3CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376B3D4 Offset: 0x37673D4 VA: 0x376B3D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376B54C Offset: 0x376754C VA: 0x376B54C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
