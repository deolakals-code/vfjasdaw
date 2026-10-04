// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillManager.UpdateExSkillConfig : UpdateExSkillConfigExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1820
{
	// Fields
	private ExSkillManager manager; // 0x20

	// Methods

	// RVA: 0x20E53B4 Offset: 0x20E13B4 VA: 0x20E53B4
	public void .ctor(ExSkillManager manager, short skillId, byte[] binary) { }

	// RVA: 0x20E5544 Offset: 0x20E1544 VA: 0x20E5544 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x20E55A4 Offset: 0x20E15A4 VA: 0x20E55A4 Slot: 13
	protected override void OnNoChange() { }

	// RVA: 0x20E5600 Offset: 0x20E1600 VA: 0x20E5600 Slot: 12
	protected override void OnNotAllowed() { }

	// RVA: 0x20E565C Offset: 0x20E165C VA: 0x20E565C Slot: 11
	protected override void OnSkillNotAllowed() { }

	// RVA: 0x20E56B8 Offset: 0x20E16B8 VA: 0x20E56B8 Slot: 10
	protected override void OnSuccess(UpdateExSkillConfigResponse response) { }
}
