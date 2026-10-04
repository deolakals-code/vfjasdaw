// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ProbeRootPopPoint : MonoBehaviour // TypeDefIndex: 3990
{
	// Fields
	[SerializeField]
	private byte popType; // 0x20
	[SerializeField]
	private int popValue; // 0x24
	[SerializeField]
	private byte[] moveProbeIds; // 0x28

	// Properties
	public byte PopType { get; }
	public int PopValue { get; }
	public byte[] MoveProbeIds { get; }

	// Methods

	// RVA: 0x243289C Offset: 0x242E89C VA: 0x243289C
	public byte get_PopType() { }

	// RVA: 0x24328A4 Offset: 0x242E8A4 VA: 0x24328A4
	public int get_PopValue() { }

	// RVA: 0x24328AC Offset: 0x242E8AC VA: 0x24328AC
	public byte[] get_MoveProbeIds() { }

	// RVA: 0x24328F4 Offset: 0x242E8F4 VA: 0x24328F4
	public void .ctor() { }
}
