// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class CmdLogSentReliable : CmdLogItem // TypeDefIndex: 16978
{
	// Fields
	public int Resend; // 0x24
	public int RoundtripTimeout; // 0x28
	public int Timeout; // 0x2C
	public bool TriggeredTimeout; // 0x30

	// Methods

	// RVA: 0x30F7ECC Offset: 0x30F3ECC VA: 0x30F7ECC
	public void .ctor(NCommand command, int timeInt, int rtt, int variance, bool triggeredTimeout = False) { }

	// RVA: 0x30F7F48 Offset: 0x30F3F48 VA: 0x30F7F48 Slot: 3
	public override string ToString() { }
}
