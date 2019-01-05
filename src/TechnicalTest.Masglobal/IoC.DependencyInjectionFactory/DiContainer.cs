//   -----------------------------------------------------------------------
//   <copyright file=DiContainer.cs company="Jeysson Ramirez">
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
    public class DiContainer
    {
        public DiContainer()
        {
            Current = new UnityContainer();
            Current.InitializeContainer();
        }

        public IUnityContainer Current { get; set; }
    }
}