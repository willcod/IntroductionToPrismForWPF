﻿using System;
using IntroductionToPrismForWPF.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using System.Windows.Controls;
using IntroductionToPrismForWPF.Core;
using IntroductionToPrismForWPF.Dialogs;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace IntroductionToPrismForWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterDialog<MessageDialog, MessageDialogViewModel>();
        }

        protected override Window CreateShell() {
            return Container.Resolve<NavigationView>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ForNaviModule.ForNaviModule>();
            moduleCatalog.AddModule<CallDialogModule.CallDialogModule>();
        }

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() {ModulePath = @".\Modules"};
        //}

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new ConfigurationModuleCatalog();
        //}

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            //ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            //{
            //    var viewName = viewType.FullName;
            //    var assemblyName = viewType.Assembly.FullName;
            //    var vmName = $"{viewName.Replace("Controls", "ViewModels")}ViewModel, {assemblyName}";

            //    return Type.GetType(vmName);
            //});
        }
    }
}