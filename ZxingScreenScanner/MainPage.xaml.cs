using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZxingScreenScanner
{
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        zxing.OnScanResult += (result) =>
            Device.BeginInvokeOnMainThread(() =>
            {
                lblResult.Text = result.Text;
            });
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        zxing.IsScanning = true;
    }

    protected override void OnDisappearing()
    {
        zxing.IsScanning = false;

        base.OnDisappearing();
    }
}
}
