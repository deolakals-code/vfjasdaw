// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class CmdLogItem // TypeDefIndex: 16975
{
	// Fields
	public int TimeInt; // 0x10
	public int Channel; // 0x14
	public int SequenceNumber; // 0x18
	public int Rtt; // 0x1C
	public int Variance; // 0x20

	// Methods

	// RVA: 0x30F783C Offset: 0x30F383C VA: 0x30F783C
	public void .ctor() { }

	// RVA: 0x30F7844 Offset: 0x30F3844 VA: 0x30F7844
	public void .ctor(NCommand command, int timeInt, int rtt, int variance) { }

	// RVA: 0x30F789C Offset: 0x30F389C VA: 0x30F789C Slot: 3
	public override string ToString() { }
}
