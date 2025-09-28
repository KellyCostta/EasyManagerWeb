using Microsoft.Extensions.Logging;

namespace EasyManagerWeb
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("CormorantGaramond-Italic-VariableFont_wght.ttf", "CormorantItalic");
                    fonts.AddFont("CormorantGaramond-VariableFont_wght.ttf", "Cormorant");
                    fonts.AddFont("Montserrat-Italic-VariableFont_wght.ttf", "MontserratItalic");
                    fonts.AddFont("Montserrat-VariableFont_wght.ttf", "Montserrat");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
