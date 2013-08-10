using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSettings
{
    public class BasePage : GlobalSettings.Common.LayoutAwarePage
    {
        public BasePage()
        {
            Windows.UI.ApplicationSettings.SettingsPane.GetForCurrentView().CommandsRequested += BasePage_CommandsRequested;
        }

        void BasePage_CommandsRequested(Windows.UI.ApplicationSettings.SettingsPane sender, Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs args)
        {
            args.Request.ApplicationCommands.Clear();

            Windows.UI.ApplicationSettings.SettingsCommand command1 = new Windows.UI.ApplicationSettings.SettingsCommand("HomePage", "Andre's blog", 
                async (x) => await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.andrealveslima.com.br")));
            Windows.UI.ApplicationSettings.SettingsCommand command2 = new Windows.UI.ApplicationSettings.SettingsCommand("brain4dev", "brain4dev",
                async (x) => await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.brain4dev.com")));

            args.Request.ApplicationCommands.Add(command1);
            args.Request.ApplicationCommands.Add(command2);
        }
    }
}
