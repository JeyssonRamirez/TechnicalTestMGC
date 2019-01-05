//   -----------------------------------------------------------------------
//   <copyright file=Factory.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 10:09 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Unity;

#endregion

namespace IoC.DependencyInjectionFactory
{
    public static class Factory
    {
        private static readonly DiContainer Container = new DiContainer();

        public static TService Resolve<TService>()
        {
            return Container.Current.Resolve<TService>();
        }
    }
}