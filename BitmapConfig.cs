using App2.Droid;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Android.Factories;
using AndroidBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;
using AndroidBitmapDescriptorFactory = Android.Gms.Maps.Model.BitmapDescriptorFactory;

public sealed class BitmapConfig : IBitmapDescriptorFactory
{
    public AndroidBitmapDescriptor ToNative(BitmapDescriptor descriptor)
    {
        int iconId = 0;
        switch (descriptor.Id)
        {
            case "Recycle":
                iconId = Resource.Drawable.recycle2;
                break;
        }
        return AndroidBitmapDescriptorFactory.FromResource(iconId);
    }
}