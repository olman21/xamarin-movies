using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Movies.Models;

namespace Xamarin.Movies.Converters
{
    public class MovieDbImageConverter : IValueConverter
    {
        private readonly InternalSettings internalSettings;
        public MovieDbImageConverter()
        {
            internalSettings = ServiceLocator.Current.GetInstance<InternalSettings>();
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageName = value as string;
            if (imageName == null) return string.Empty;

            return ImageSource.FromUri(new Uri($"{internalSettings.MovieDbImageBaseUrl}/{imageName}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageSource = value as UriImageSource;
            if (imageSource == null) return string.Empty;

            var url = imageSource.Uri.ToString();

            return url.Replace($"{internalSettings.MovieDbImageBaseUrl}/", string.Empty);

        }
    }
}
