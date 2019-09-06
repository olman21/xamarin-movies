using AiForms.Dialogs;
using AiForms.Dialogs.Abstractions;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Movies.Models;
using Xamarin.Movies.Services;

namespace Xamarin.Movies.IoC
{
    public class XamarinMovieContainer
    {
        private XamarinMovieContainer() { }

        public static XamarinMovieContainer Create() => new XamarinMovieContainer();

        private UnityContainer Container = new UnityContainer();
        public XamarinMovieContainer Configure()
        {
            Container.RegisterType<IMovieService, MovieService>();
            Container.RegisterInstance(Loading.Instance);
            Container.RegisterInstance(new HttpClient());
            return this;
        }

        public XamarinMovieContainer SetInternalSettings(InternalSettings settings)
        {
            Container.RegisterInstance(settings);
            return this;
        }

        public void Build()
        {
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));
        }

    }
}
