using binstarjs03.AerialOBJ.Core.Nbt.IO;

namespace binstarjs03.AerialOBJ.Core.Nbt;

public class NbtEnd : NbtBase
{
    public override NbtType NbtType => NbtType.NbtEnd;

    public override NbtTypeBase NbtTypeBase => NbtTypeBase.NbtBase;

    public override NbtEnd Clone()
    {
        return new();
    }

    protected override void Deserialize(NbtBinaryReader reader) { }
}
