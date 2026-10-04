// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BonusScriptManager // TypeDefIndex: 1743
{
	// Fields
	private Dictionary<BonusType, Func<BonusParameter, BonusScriptManager.BonusScriptCommand>> funcList; // 0x10
	private PlayerStatusBase playerStatus; // 0x18
	private BonusScriptData script; // 0x20

	// Methods

	// RVA: 0x20BE3CC Offset: 0x20BA3CC VA: 0x20BE3CC
	public void .ctor(PlayerStatusBase playerStatus) { }

	// RVA: 0x20BF770 Offset: 0x20BB770 VA: 0x20BF770
	public void InitNewBonus(BonusScriptData bonusScript, float time) { }

	// RVA: 0x20BF8A8 Offset: 0x20BB8A8 VA: 0x20BF8A8
	public void Run(BonusScriptData bonusScript, bool updateTime) { }

	// RVA: 0x20BFA70 Offset: 0x20BBA70 VA: 0x20BFA70
	private bool timeCheck(bool updateTime) { }

	// RVA: 0x20BFC08 Offset: 0x20BBC08 VA: 0x20BFC08
	private int getValue(int val) { }

	// RVA: 0x20BFC2C Offset: 0x20BBC2C VA: 0x20BFC2C
	private BonusScriptManager.BonusScriptCommand funcSetTime(BonusParameter line) { }

	// RVA: 0x20BFC78 Offset: 0x20BBC78 VA: 0x20BFC78
	private BonusScriptManager.BonusScriptCommand funcSetRepeatWait(BonusParameter line) { }

	// RVA: 0x20BFCB8 Offset: 0x20BBCB8 VA: 0x20BFCB8
	private BonusScriptManager.BonusScriptCommand funcSetStartWait(BonusParameter line) { }

	// RVA: 0x20BFCF8 Offset: 0x20BBCF8 VA: 0x20BFCF8
	private BonusScriptManager.BonusScriptCommand funcEndScript(BonusParameter line) { }

	// RVA: 0x20BFD00 Offset: 0x20BBD00 VA: 0x20BFD00
	private BonusScriptManager.BonusScriptCommand funcSetBonus(BonusParameter line) { }

	// RVA: 0x20BFD40 Offset: 0x20BBD40 VA: 0x20BFD40
	private BonusScriptManager.BonusScriptCommand funcSetInstantBonus(BonusParameter line) { }

	// RVA: 0x20BFD80 Offset: 0x20BBD80 VA: 0x20BFD80
	private BonusScriptManager.BonusScriptCommand funcSetAntiVirusBonus(BonusParameter line) { }

	// RVA: 0x20BFDB0 Offset: 0x20BBDB0 VA: 0x20BFDB0
	private BonusScriptManager.BonusScriptCommand funcSetBuff(BonusParameter line) { }

	// RVA: 0x20BFDF0 Offset: 0x20BBDF0 VA: 0x20BFDF0
	private BonusScriptManager.BonusScriptCommand funcSetDebuff(BonusParameter line) { }

	// RVA: 0x20BFE1C Offset: 0x20BBE1C VA: 0x20BFE1C
	private BonusScriptManager.BonusScriptCommand funcEquipTypeLimit(BonusParameter line) { }

	// RVA: 0x20C0028 Offset: 0x20BC028 VA: 0x20C0028
	private BonusScriptManager.BonusScriptCommand funcSetValue(BonusParameter line) { }

	// RVA: 0x20C0050 Offset: 0x20BC050 VA: 0x20C0050
	private BonusScriptManager.BonusScriptCommand funcAddValue(BonusParameter line) { }

	// RVA: 0x20C0080 Offset: 0x20BC080 VA: 0x20C0080
	private BonusScriptManager.BonusScriptCommand funcProductValue(BonusParameter line) { }

	// RVA: 0x20C00C0 Offset: 0x20BC0C0 VA: 0x20C00C0
	private BonusScriptManager.BonusScriptCommand funcStatusValue(BonusParameter line) { }

	// RVA: 0x20C0544 Offset: 0x20BC544 VA: 0x20C0544
	private BonusScriptManager.BonusScriptCommand funcIf(BonusParameter line) { }

	// RVA: 0x20C0744 Offset: 0x20BC744 VA: 0x20C0744
	private BonusScriptManager.BonusScriptCommand eventCheck(BonusParameter line) { }

	// RVA: 0x20C07B0 Offset: 0x20BC7B0 VA: 0x20C07B0
	private BonusScriptManager.BonusScriptCommand funcSetSpecialInstantBonus(BonusParameter line) { }

	// RVA: 0x20C0840 Offset: 0x20BC840 VA: 0x20C0840
	private BonusScriptManager.BonusScriptCommand funcSetSpecialBonus(BonusParameter line) { }

	// RVA: 0x20C08D0 Offset: 0x20BC8D0 VA: 0x20C08D0
	private BonusScriptManager.BonusScriptCommand funcSetSpecialBuff(BonusParameter line) { }

	// RVA: 0x20C0960 Offset: 0x20BC960 VA: 0x20C0960
	private BonusScriptManager.BonusScriptCommand funcSetSpecialValue(BonusParameter line) { }

	// RVA: 0x20C0990 Offset: 0x20BC990 VA: 0x20C0990
	private BonusScriptManager.BonusScriptCommand funcSetCalcSpecialBonus(BonusParameter line) { }

	// RVA: 0x20C0DBC Offset: 0x20BCDBC VA: 0x20C0DBC
	private BonusScriptManager.BonusScriptCommand funcSetDamageBonus(BonusParameter line) { }
}
