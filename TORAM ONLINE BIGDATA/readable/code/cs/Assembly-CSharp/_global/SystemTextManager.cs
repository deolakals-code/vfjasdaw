// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SystemTextManager : TextManagerBase // TypeDefIndex: 5276
{
	// Fields
	private Dictionary<string, TextManagerDataSingle> TextData; // 0x18

	// Methods

	// RVA: 0x262072C Offset: 0x261C72C VA: 0x262072C Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: 0x2620B8C Offset: 0x261CB8C VA: 0x2620B8C
	public void BuildInLocalize(byte[] binary) { }

	// RVA: 0x2620F78 Offset: 0x261CF78 VA: 0x2620F78
	private void AddDebugText() { }

	// RVA: 0x2620F7C Offset: 0x261CF7C VA: 0x2620F7C
	public void ReInitialized() { }

	// RVA: -1 Offset: -1 Slot: 5
	public override T Get<T>(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F3F54 Offset: 0x26EFF54 VA: 0x26F3F54
	|-SystemTextManager.Get<object>
	*/

	// RVA: 0x2620F84 Offset: 0x261CF84 VA: 0x2620F84
	public string Get(string key) { }

	// RVA: 0x262103C Offset: 0x261D03C VA: 0x262103C
	public bool TryGet(string key, out string text) { }

	// RVA: 0x2621124 Offset: 0x261D124 VA: 0x2621124 Slot: 7
	public override void Clear() { }

	// RVA: 0x262117C Offset: 0x261D17C VA: 0x262117C
	private string ChangeLocalizeCheckText(string localizeText) { }

	// RVA: 0x2621530 Offset: 0x261D530 VA: 0x2621530
	public string DateTimeYYYYMMDD(DateTime time) { }

	// RVA: 0x26215CC Offset: 0x261D5CC VA: 0x26215CC
	public string DateTimeYYYYMMDD(int year, int month, int day) { }

	// RVA: 0x26216A4 Offset: 0x261D6A4 VA: 0x26216A4
	public string DateTimeSimpleFormat(DateTime time) { }

	// RVA: 0x2621948 Offset: 0x261D948 VA: 0x2621948
	public void .ctor() { }
}
