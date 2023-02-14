using Autodesk.Revit.UI;

using dosymep.WPF.ViewModels;

using RevitPluginTemplate.Models;

namespace RevitPluginTemplate.ViewModels {
    internal class MainViewModel : BaseViewModel {
		private readonly RevitRepository _revitRepository;
        private readonly RevitPluginTemplateConfig _revitPluginTemplateConfig;

        private string _errorText;

        public MainViewModel(RevitRepository revitRepository, RevitPluginTemplateConfig revitPluginTemplateConfig) {
            _revitRepository = revitRepository;
            _revitPluginTemplateConfig = revitPluginTemplateConfig;
        }

        public string ErrorText {
            get => _errorText;
            set => this.RaiseAndSetIfChanged(ref _errorText, value);
        }
    }
}