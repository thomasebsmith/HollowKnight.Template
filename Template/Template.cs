using Modding;

namespace Template;

public class Template : Mod, ITogglableMod
{
    public Template() : base(nameof(Template))
    {
    }

    public override void Initialize()
    {
        Log("Initializing...");
    }

    public void Unload()
    {
        Log("Unloading...");
    }

    public override string GetVersion()
    {
        return "0.1";
    }
}
