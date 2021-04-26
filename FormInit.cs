using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingetGui
{
    public class FormInit
    {
        public static void FillSearchBox(List<WingetAppsLibrary.AppDto> apps, ComboBox searchBox)
        {
            var appList = apps.GroupBy(a => a.Name).Select(g => g.First()).OrderBy(a => a.Name).ToList();

            foreach (var app in appList)
            {
                searchBox.Items.Add(app.Name);
            }

            if (searchBox.Items.Count > 0)
            {
                searchBox.SelectedIndex = 0;
            }
        }

        public async Task<List<WingetAppsLibrary.AppDto>> GetApps()
        {
            var wingetApps = new WingetAppsLibrary.WingetApps();
            var appList = await wingetApps.GetWingetApps(60 * 24 * 30);
            return appList;
        }
    }
}
