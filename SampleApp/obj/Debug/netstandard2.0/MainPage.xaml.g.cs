//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SampleApp.MainPage.xaml", "MainPage.xaml", typeof(global::SampleApp.MainPage))]

namespace SampleApp {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SampleApp.CustomControl.CustomEntry txtShopId;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SampleApp.CustomControl.CustomEntry txtUserId;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SampleApp.CustomControl.CustomEntry txtPassword;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button ShopIDSubmit;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            txtShopId = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SampleApp.CustomControl.CustomEntry>(this, "txtShopId");
            txtUserId = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SampleApp.CustomControl.CustomEntry>(this, "txtUserId");
            txtPassword = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SampleApp.CustomControl.CustomEntry>(this, "txtPassword");
            ShopIDSubmit = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "ShopIDSubmit");
        }
    }
}