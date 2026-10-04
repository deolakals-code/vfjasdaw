// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BoneClip // TypeDefIndex: 5303
{
	// Fields
	public BoneClip.MotionKeyFrame[] PositionX; // 0x10
	public BoneClip.MotionKeyFrame[] PositionY; // 0x18
	public BoneClip.MotionKeyFrame[] PositionZ; // 0x20
	public bool IsChangeRotationEuler; // 0x28
	public BoneClip.MotionKeyFrame[] RotationX; // 0x30
	public BoneClip.MotionKeyFrame[] RotationY; // 0x38
	public BoneClip.MotionKeyFrame[] RotationZ; // 0x40
	public BoneClip.MotionKeyFrame[] RotationW; // 0x48
	public BoneClip.MotionKeyFrame[] ScaleX; // 0x50
	public BoneClip.MotionKeyFrame[] ScaleY; // 0x58
	public BoneClip.MotionKeyFrame[] ScaleZ; // 0x60

	// Methods

	// RVA: 0x2628EBC Offset: 0x2624EBC VA: 0x2628EBC
	public void .ctor(List<BoneClip.MotionKeyFrame> posX, List<BoneClip.MotionKeyFrame> posY, List<BoneClip.MotionKeyFrame> posZ, List<BoneClip.MotionKeyFrame> rotX, List<BoneClip.MotionKeyFrame> rotY, List<BoneClip.MotionKeyFrame> rotZ, List<BoneClip.MotionKeyFrame> rotW, List<BoneClip.MotionKeyFrame> scaleX, List<BoneClip.MotionKeyFrame> scaleY, List<BoneClip.MotionKeyFrame> scaleZ) { }

	// RVA: 0x2628DD8 Offset: 0x2624DD8 VA: 0x2628DD8
	public static BoneClip.MotionKeyFrame AddKeyFrame(BinaryReader read, short frame) { }
}
