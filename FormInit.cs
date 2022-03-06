using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingetGui
{
    public class FormInit
    {
        public static void FillSearchBox(List<AppDto> apps, ComboBox searchBox)
        {
            var appList = apps.GroupBy(a => a.packageName).Select(g => g.First()).OrderBy(a => a.packageName).ToList();

            foreach (var app in appList)
            {
                searchBox.Items.Add(app.packageName);
            }

            if (searchBox.Items.Count > 0)
            {
                searchBox.SelectedIndex = 0;
            }
        }

        public async Task<List<AppDto>> GetApps()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://arkkis.com:7119/apps");
            var result = await response.Content.ReadAsStringAsync();
            var apps = JsonSerializer.Deserialize<List<AppDto>>(result);
            return apps;
        }
    }

    public class AppDto
    {
        public string packageIdentifier { get; init; }
        public string packageName { get; init; }
        public string description { get; init; }
    }
}
