// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ActionAppendData : BinaryBase // TypeDefIndex: 13105
{
	// Fields
	private byte count; // 0x19
	private Dictionary<short, int> datas; // 0x20

	// Methods

	// RVA: 0x36A25B8 Offset: 0x369E5B8 VA: 0x36A25B8
	public void .ctor() { }

	// RVA: 0x36A2644 Offset: 0x369E644 VA: 0x36A2644
	public void .ctor(byte[] binary) { }

	// RVA: 0x36A264C Offset: 0x369E64C VA: 0x36A264C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36A272C Offset: 0x369E72C VA: 0x36A272C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36A2968 Offset: 0x369E968 VA: 0x36A2968
	public bool Add(short type, int value) { }

	// RVA: 0x36A2A08 Offset: 0x369EA08 VA: 0x36A2A08
	public bool Contains(short type) { }

	// RVA: 0x36A2A9C Offset: 0x369EA9C VA: 0x36A2A9C
	public int Get(short type) { }
}
