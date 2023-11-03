using static Blazor.Charts.Client.Components.Chart;

namespace Blazor.Charts.Client.Components;

public static class ChartConfig
{
    public static object GetBarChartConfig(
        int[] data,
        string[] backgroundColor,
        string[] labels,
        string title)
    {
        return new
        {
            Type = ChartType.Bar.ToString().ToLower(),
            Options = new
            {
                Responsive = true,
                Scales = new
                {
                    YAxes = new[]
                    {
                        new
                        {
                            Ticks = new
                            {
                                BeginAtZero=true
                             }
                        }
                    }
                }
            },
            Data = new
            {
                Datasets = new[]
                {
                    new
                    {
                        Data = data,
                        BackgroundColor = backgroundColor,
                        Label = title,
                    }
                },
                Labels = labels
            }
        };
    }

    public static object GetPieChartConfig(
        int[] data,
        string[] backgroundColor,
        string[] labels,
        string title)
    {
        return new
        {
            Type = ChartType.Pie.ToString().ToLower(),
            Options = new
            {
                Title = new
                {
                    Display = true,
                    Text = title,
                }
            },
            Data = new
            {
                Datasets = new[]
                {
                    new
                    {
                        Data = data,
                        BackgroundColor = backgroundColor,
                        Label = title,
                    }
                },
                Labels = labels
            }
        };
    }
}
