namespace Content.Shared._Floof.Paint;

public abstract class SharedPaintSystem : EntitySystem
{
    public virtual void UpdateAppearance(EntityUid uid, PaintedComponent? component = null) { }
}
