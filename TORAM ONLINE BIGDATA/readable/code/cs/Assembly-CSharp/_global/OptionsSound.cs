// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionsSound // TypeDefIndex: 5378
{
	// Fields
	[CompilerGenerated]
	private bool <BGMPlay>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <BGMVolume>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <SelfSEPlay>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <SEVolume>k__BackingField; // 0x13
	[CompilerGenerated]
	private byte <SystemSEVolume>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <OtherSEPlay>k__BackingField; // 0x15
	[CompilerGenerated]
	private bool <PartySEPlay>k__BackingField; // 0x16
	[CompilerGenerated]
	private byte <SelectMaxSE>k__BackingField; // 0x17
	[CompilerGenerated]
	private byte <MasterVolume>k__BackingField; // 0x18
	public const byte DefaultSelectMaxSE = 0;

	// Properties
	[SerializeField]
	public bool BGMPlay { get; set; }
	[SerializeField]
	public byte BGMVolume { get; set; }
	[SerializeField]
	public bool SelfSEPlay { get; set; }
	[SerializeField]
	public byte SEVolume { get; set; }
	[SerializeField]
	public byte SystemSEVolume { get; set; }
	[SerializeField]
	public bool OtherSEPlay { get; set; }
	[SerializeField]
	public bool PartySEPlay { get; set; }
	[SerializeField]
	public byte SelectMaxSE { get; set; }
	public int MaxSE { get; }
	[SerializeField]
	public byte MasterVolume { get; set; }
	public float MasterVolumeNum { get; }
	protected virtual byte DefaultMasterVolume { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x264F694 Offset: 0x264B694 VA: 0x264F694
	private void set_BGMPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264F6A0 Offset: 0x264B6A0 VA: 0x264F6A0
	public bool get_BGMPlay() { }

	[CompilerGenerated]
	// RVA: 0x264F6A8 Offset: 0x264B6A8 VA: 0x264F6A8
	private void set_BGMVolume(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264F6B0 Offset: 0x264B6B0 VA: 0x264F6B0
	public byte get_BGMVolume() { }

	[CompilerGenerated]
	// RVA: 0x264F6B8 Offset: 0x264B6B8 VA: 0x264F6B8
	private void set_SelfSEPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264F6C4 Offset: 0x264B6C4 VA: 0x264F6C4
	public bool get_SelfSEPlay() { }

	[CompilerGenerated]
	// RVA: 0x264F6CC Offset: 0x264B6CC VA: 0x264F6CC
	private void set_SEVolume(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264F6D4 Offset: 0x264B6D4 VA: 0x264F6D4
	public byte get_SEVolume() { }

	[CompilerGenerated]
	// RVA: 0x264F6DC Offset: 0x264B6DC VA: 0x264F6DC
	private void set_SystemSEVolume(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264F6E4 Offset: 0x264B6E4 VA: 0x264F6E4
	public byte get_SystemSEVolume() { }

	[CompilerGenerated]
	// RVA: 0x264F6EC Offset: 0x264B6EC VA: 0x264F6EC
	private void set_OtherSEPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264F6F8 Offset: 0x264B6F8 VA: 0x264F6F8
	public bool get_OtherSEPlay() { }

	[CompilerGenerated]
	// RVA: 0x264F700 Offset: 0x264B700 VA: 0x264F700
	private void set_PartySEPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264F70C Offset: 0x264B70C VA: 0x264F70C
	public bool get_PartySEPlay() { }

	[CompilerGenerated]
	// RVA: 0x264F714 Offset: 0x264B714 VA: 0x264F714
	private void set_SelectMaxSE(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264F71C Offset: 0x264B71C VA: 0x264F71C
	public byte get_SelectMaxSE() { }

	// RVA: 0x264F724 Offset: 0x264B724 VA: 0x264F724
	public int get_MaxSE() { }

	[CompilerGenerated]
	// RVA: 0x264F734 Offset: 0x264B734 VA: 0x264F734
	private void set_MasterVolume(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264F73C Offset: 0x264B73C VA: 0x264F73C
	public byte get_MasterVolume() { }

	// RVA: 0x264F744 Offset: 0x264B744 VA: 0x264F744
	public float get_MasterVolumeNum() { }

	// RVA: 0x264F75C Offset: 0x264B75C VA: 0x264F75C Slot: 4
	protected virtual byte get_DefaultMasterVolume() { }

	// RVA: 0x264D6B8 Offset: 0x26496B8 VA: 0x264D6B8
	public void .ctor() { }

	// RVA: 0x264F764 Offset: 0x264B764 VA: 0x264F764
	public void SoundOptionSave() { }

	// RVA: 0x264D6F0 Offset: 0x26496F0 VA: 0x264D6F0
	public void SoundOptionLoad() { }

	// RVA: 0x264F840 Offset: 0x264B840 VA: 0x264F840
	public bool SetFlag(OptionsSound.SoundOptionType Type, bool setFlag) { }

	// RVA: 0x264F900 Offset: 0x264B900 VA: 0x264F900
	public bool SetParam(OptionsSound.SoundOptionType Type, int setParam) { }
}
