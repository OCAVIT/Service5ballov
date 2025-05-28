using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocatorProvider
{
    public static IService Locator { get; private set; }
    public static void SetLocator(IService locator) => Locator = locator;
}
