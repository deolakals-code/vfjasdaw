// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OptionManager : Singleton<OptionManager> // TypeDefIndex: 5366
{
	// Fields
	private Dictionary<byte, int> memorySaveOptionData; // 0x20
	[CompilerGenerated]
	private OptionsSystem <OptionsSystem>k__BackingField; // 0x28
	[CompilerGenerated]
	private OptionsGraphics <OptionsGraphics>k__BackingField; // 0x30
	[CompilerGenerated]
	private OptionsSound <OptionsSound>k__BackingField; // 0x38
	[CompilerGenerated]
	private OptionChat <OptionChat>k__BackingField; // 0x40
	[CompilerGenerated]
	private OptionBlock <OptionBlock>k__BackingField; // 0x48
	[CompilerGenerated]
	private OptionsVariety <OptionsVariety>k__BackingField; // 0x50
	[CompilerGenerated]
	private OptionsCommunication <OptionsCommunication>k__BackingField; // 0x58
	[CompilerGenerated]
	private OptionsMoodMessage <OptionsMoodMessage>k__BackingField; // 0x60
	[CompilerGenerated]
	private OptionKeyConfig <OptionKeyConfig>k__BackingField; // 0x68
	private bool isInit; // 0x70
	private readonly string saveAppIdKey; // 0x78
	private readonly string saveIsAccountUserKey; // 0x80

	// Properties
	private static bool MouseClick { get; }
	public static int MouseL { get; }
	public static int MouseR { get; }
	public static byte Resolution { get; }
	public static bool MouseDesign { get; }
	public static CursorLockMode CursorScreen { get; }
	public OptionsSystem OptionsSystem { get; set; }
	public OptionsGraphics OptionsGraphics { get; set; }
	public OptionsSound OptionsSound { get; set; }
	public OptionChat OptionChat { get; set; }
	public OptionBlock OptionBlock { get; set; }
	public OptionsVariety OptionsVariety { get; set; }
	public OptionsCommunication OptionsCommunication { get; set; }
	public OptionsMoodMessage OptionsMoodMessage { get; set; }
	public OptionKeyConfig OptionKeyConfig { get; set; }

	// Methods

	// RVA: 0x264CF28 Offset: 0x2648F28 VA: 0x264CF28
	private static bool get_MouseClick() { }

	// RVA: 0x264CF30 Offset: 0x2648F30 VA: 0x264CF30
	public static int MouseKey(int id) { }

	// RVA: 0x264CF34 Offset: 0x2648F34 VA: 0x264CF34
	public static int get_MouseL() { }

	// RVA: 0x264CF3C Offset: 0x2648F3C VA: 0x264CF3C
	public static int get_MouseR() { }

	// RVA: 0x264CF44 Offset: 0x2648F44 VA: 0x264CF44
	public static byte get_Resolution() { }

	// RVA: 0x264D298 Offset: 0x2649298 VA: 0x264D298
	public static bool get_MouseDesign() { }

	// RVA: 0x264D364 Offset: 0x2649364 VA: 0x264D364
	public static CursorLockMode get_CursorScreen() { }

	[CompilerGenerated]
	// RVA: 0x264D36C Offset: 0x264936C VA: 0x264D36C
	private void set_OptionsSystem(OptionsSystem value) { }

	[CompilerGenerated]
	// RVA: 0x264D374 Offset: 0x2649374 VA: 0x264D374
	public OptionsSystem get_OptionsSystem() { }

	[CompilerGenerated]
	// RVA: 0x264D37C Offset: 0x264937C VA: 0x264D37C
	private void set_OptionsGraphics(OptionsGraphics value) { }

	[CompilerGenerated]
	// RVA: 0x264D384 Offset: 0x2649384 VA: 0x264D384
	public OptionsGraphics get_OptionsGraphics() { }

	[CompilerGenerated]
	// RVA: 0x264D38C Offset: 0x264938C VA: 0x264D38C
	private void set_OptionsSound(OptionsSound value) { }

	[CompilerGenerated]
	// RVA: 0x264D394 Offset: 0x2649394 VA: 0x264D394
	public OptionsSound get_OptionsSound() { }

	[CompilerGenerated]
	// RVA: 0x264D39C Offset: 0x264939C VA: 0x264D39C
	private void set_OptionChat(OptionChat value) { }

	[CompilerGenerated]
	// RVA: 0x264D3A4 Offset: 0x26493A4 VA: 0x264D3A4
	public OptionChat get_OptionChat() { }

	[CompilerGenerated]
	// RVA: 0x264D3AC Offset: 0x26493AC VA: 0x264D3AC
	private void set_OptionBlock(OptionBlock value) { }

	[CompilerGenerated]
	// RVA: 0x264D3B4 Offset: 0x26493B4 VA: 0x264D3B4
	public OptionBlock get_OptionBlock() { }

	[CompilerGenerated]
	// RVA: 0x264D3BC Offset: 0x26493BC VA: 0x264D3BC
	private void set_OptionsVariety(OptionsVariety value) { }

	[CompilerGenerated]
	// RVA: 0x264D3C4 Offset: 0x26493C4 VA: 0x264D3C4
	public OptionsVariety get_OptionsVariety() { }

	[CompilerGenerated]
	// RVA: 0x264D3CC Offset: 0x26493CC VA: 0x264D3CC
	private void set_OptionsCommunication(OptionsCommunication value) { }

	[CompilerGenerated]
	// RVA: 0x264D3D4 Offset: 0x26493D4 VA: 0x264D3D4
	public OptionsCommunication get_OptionsCommunication() { }

	[CompilerGenerated]
	// RVA: 0x264D3DC Offset: 0x26493DC VA: 0x264D3DC
	private void set_OptionsMoodMessage(OptionsMoodMessage value) { }

	[CompilerGenerated]
	// RVA: 0x264D3E4 Offset: 0x26493E4 VA: 0x264D3E4
	public OptionsMoodMessage get_OptionsMoodMessage() { }

	[CompilerGenerated]
	// RVA: 0x264D3EC Offset: 0x26493EC VA: 0x264D3EC
	private void set_OptionKeyConfig(OptionKeyConfig value) { }

	[CompilerGenerated]
	// RVA: 0x264D3F4 Offset: 0x26493F4 VA: 0x264D3F4
	public OptionKeyConfig get_OptionKeyConfig() { }

	// RVA: 0x264D3FC Offset: 0x26493FC VA: 0x264D3FC
	private void Awake() { }

	// RVA: 0x264D010 Offset: 0x2649010 VA: 0x264D010
	private void Initialize() { }

	// RVA: 0x264DE6C Offset: 0x2649E6C VA: 0x264DE6C
	public void NewAccountClear() { }

	// RVA: 0x264E02C Offset: 0x264A02C VA: 0x264E02C
	public void ChangeAccountClear() { }

	// RVA: 0x264E158 Offset: 0x264A158 VA: 0x264E158
	public bool GetMemorySaveOptionData(OptionManager.OptionMemoryType type, out int param) { }

	// RVA: 0x264E1C0 Offset: 0x264A1C0 VA: 0x264E1C0
	public void UpdateMemorySaveOptionData(OptionManager.OptionMemoryType type, int param) { }

	// RVA: 0x264E228 Offset: 0x264A228 VA: 0x264E228
	public void UpdateSaveAppId() { }

	// RVA: 0x264E22C Offset: 0x264A22C VA: 0x264E22C
	public void .ctor() { }
}
