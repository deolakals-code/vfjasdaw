// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BoneMotionClip // TypeDefIndex: 5301
{
	// Fields
	[CompilerGenerated]
	private int <MotionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <FrameRate>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <Mode>k__BackingField; // 0x15
	[CompilerGenerated]
	private float <Lenght>k__BackingField; // 0x18
	private Dictionary<byte, BoneClip> motionData; // 0x20
	private static List<BoneClip.MotionKeyFrame> posX; // 0x0
	private static List<BoneClip.MotionKeyFrame> posY; // 0x8
	private static List<BoneClip.MotionKeyFrame> posZ; // 0x10
	private static List<BoneClip.MotionKeyFrame> rotX; // 0x18
	private static List<BoneClip.MotionKeyFrame> rotY; // 0x20
	private static List<BoneClip.MotionKeyFrame> rotZ; // 0x28
	private static List<BoneClip.MotionKeyFrame> rotW; // 0x30
	private static List<BoneClip.MotionKeyFrame> scaleX; // 0x38
	private static List<BoneClip.MotionKeyFrame> scaleY; // 0x40
	private static List<BoneClip.MotionKeyFrame> scaleZ; // 0x48

	// Properties
	public int MotionId { get; set; }
	public byte FrameRate { get; set; }
	public byte Mode { get; set; }
	public float Lenght { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2627A58 Offset: 0x2623A58 VA: 0x2627A58
	private void set_MotionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2627A60 Offset: 0x2623A60 VA: 0x2627A60
	public int get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x2627A68 Offset: 0x2623A68 VA: 0x2627A68
	private void set_FrameRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2627A70 Offset: 0x2623A70 VA: 0x2627A70
	public byte get_FrameRate() { }

	[CompilerGenerated]
	// RVA: 0x2627A78 Offset: 0x2623A78 VA: 0x2627A78
	private void set_Mode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2627A80 Offset: 0x2623A80 VA: 0x2627A80
	public byte get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x2627A88 Offset: 0x2623A88 VA: 0x2627A88
	private void set_Lenght(float value) { }

	[CompilerGenerated]
	// RVA: 0x2627A90 Offset: 0x2623A90 VA: 0x2627A90
	public float get_Lenght() { }

	// RVA: 0x2627A98 Offset: 0x2623A98 VA: 0x2627A98
	public void .ctor(byte frameRate, byte mode, int motionId) { }

	// RVA: 0x2627B44 Offset: 0x2623B44 VA: 0x2627B44
	public bool AddBoneClip(byte boneId, BoneClip clip) { }

	// RVA: 0x2627BE8 Offset: 0x2623BE8 VA: 0x2627BE8
	public bool GetBoneClip(byte boneId, out BoneClip clip) { }

	// RVA: 0x2627C60 Offset: 0x2623C60 VA: 0x2627C60
	public void SetLenght(short len) { }

	// RVA: 0x2627C7C Offset: 0x2623C7C VA: 0x2627C7C
	public static BoneMotionClip LoadMotion(BinaryReader read) { }

	// RVA: 0x2629098 Offset: 0x2625098 VA: 0x2629098
	public static long LoadMotion(byte[] binary, long position, out BoneMotionClip clip) { }

	// RVA: 0x2629B8C Offset: 0x2625B8C VA: 0x2629B8C
	private static int AddKeyFrame(List<BoneClip.MotionKeyFrame> list, byte[] binary, int pos, short frame) { }

	// RVA: 0x2629E74 Offset: 0x2625E74 VA: 0x2629E74
	private static void .cctor() { }
}
