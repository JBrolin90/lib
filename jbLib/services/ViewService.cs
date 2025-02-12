
namespace jbLib.services;

public class ViewService : IViewService
{
    public void ShowView<TView>() where TView : class
    {
        var x = Activator.CreateInstance(typeof(TView));
        var viewInstance = Activator.CreateInstance(typeof(TView)) as IView;

    }
}
