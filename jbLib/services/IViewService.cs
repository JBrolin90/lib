using System;

namespace jbLib.services;

public interface IViewService
{
    void ShowView<TView>() where TView : class;
}
